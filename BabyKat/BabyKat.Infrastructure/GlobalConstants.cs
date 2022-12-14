using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BabyKat.Infrastructure
{
     public class GlobalConstants
    {
        public class ArticleConstants
        {
            public const int TitleMaxLength = 100;
            public const int TitleMinLength = 5;

            public const int ImageUrlMaxLength = 400;

            public const int DescriptionMaxLength = 10000;
            public const int DescriptionMinLength = 500;


        }
        public class CategoryConstants
        {
            public const int ImageUrlMaxLength = 400;
            public const int CategoryNameMaxLength = 50;
            public const int CategoryNameMinLength = 3;
        }

        public class CommentConstants
        {
            public const int AuthorMaxLength = 50;
            public const int AuthorMinLength = 3;

            public const int DescriptionMinLength = 40;
            public const int DescriptionMaxLength = 300;

            public const int TitleMinLength = 30;
            public const int TitleMaxLength = 300;

        }
        public class PostConstants
        {
            public const int TitleMaxLength = 50;
            public const int TitleMinLength = 10;

            public const int DescriptionMaxLength = 5000;
            public const int DescriptionMinLength = 40;

            public const int RatingMax = 6;


        }
        public class ProductConstants
        {
            public const int NameMaxLength = 50;
            public const int NameMinLength = 10;

            public const int DescriptionMinLength = 40;
            public const int DescriptionMaxLength = 1300;

            public const int ImageUrlMaxLength = 200;

            public const int PriceMax = 10000;
        }

        public class UserConstants
        {
            public const int UserNameMaxLength = 50;
            public const int UserNameMinLength = 5;

            public const int EmailMaxLength = 40;
            public const int EmailMinLength = 10;

            public const int PasswordMinLength = 5;
            public const int PasswordMaxLength = 15;


            public const int FirstNameMaxLength = 20;
            public const int FirstNameMinLength = 2;

            public const int LastNameMaxLength = 20;
            public const int LastNameMinLength = 2;

            public const int CountryMaxLength = 20;
            public const int CountryMinLength = 2;
        }
    }
}
