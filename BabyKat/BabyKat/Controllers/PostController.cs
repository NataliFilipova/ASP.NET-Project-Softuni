using BabyKat.Core.Contracts;
using BabyKat.Core.Models.Post;
using BabyKat.Core.Services;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;
using System.Security.Claims;
using System.Security.Permissions;

namespace BabyKat.Controllers
{
    public class PostController : Controller
    {
        private readonly IPostService postService;
        public PostController(IPostService _postService)
        {
            this.postService = _postService;
        }

        [HttpGet]
        public async Task<IActionResult> All()
        {
            var model = await postService.GetAllPosts();
            return View(model);
        }


        [HttpGet]

        public IActionResult Add(int productId)
        {
            var model = new PostModel()
            {
                ProductId = productId

            };
            return View(model);
        }

        [HttpPost]

        public async Task <IActionResult> Add(PostModel model)
        {
            var userId = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)?.Value;
            await postService.AddPost(model, userId);
            return RedirectToAction("All","Post");
        }
    }
}
