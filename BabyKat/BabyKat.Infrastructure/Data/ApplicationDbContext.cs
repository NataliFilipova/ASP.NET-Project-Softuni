using BabyKat.Infrastructure.Data.Configuration;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BabyKat.Infrastructure.Data
{
    public class ApplicationDbContext : IdentityDbContext<User, IdentityRole, string>
    {
        private bool seedDb;
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options, bool seed = true)
            : base(options)
        {
            if (this.Database.IsRelational())
            {
                this.Database.Migrate();
            }
            else
            {
                this.Database.EnsureCreated();
            }
            this.seedDb = seed;
        }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Article> Articles { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {



            builder.Entity<Post>()
            .HasOne(e => e.Product)
            .WithMany(c => c.Posts)
            .OnDelete(DeleteBehavior.Restrict);



            builder.Entity<User>()
                .Property(u => u.Email)
                .HasMaxLength(60)
                .IsRequired();

            if (this.seedDb)
            {

                builder.ApplyConfiguration(new UserConfiguration());
                builder.ApplyConfiguration(new CategoryConfiguration());
                builder.ApplyConfiguration(new ProductConfiguration());
                builder.ApplyConfiguration(new ArticleConfiguration());
                builder.ApplyConfiguration(new RoleConfiguration());
                builder.ApplyConfiguration(new UserRoleConfiguration());


            }


            base.OnModelCreating(builder);

        }

    }
}