using BabyKat.Core.Contracts;
using BabyKat.Core.Models.Postt;
using BabyKat.Core.Services;
using BabyKat.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Reflection;
using System.Security.Claims;
using System.Security.Permissions;

namespace BabyKat.Areas.Users.Controllers
{
    [Area("Users")]
    [Authorize(Roles = "User,Admin")]
    public class PostController : Controller
    {
      
        private readonly IPostService postService;
        public PostController(IPostService _postService)
        {
            postService = _postService;
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

        public async Task<IActionResult> Add(PostModel model)
        {

            try
            {
                var userId = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)?.Value;
                await postService.AddPost(model, userId);
                return RedirectToAction("All", "Post");
            }
            catch (Exception e)
            {
                var erroMassage = new ErrorViewModel { RequestId = e.Message };
                return View("Error", erroMassage);
            }
        }

        [HttpGet]

        public async Task<IActionResult> ShowPosts(int productId)
        {
            var model = await postService.GetPostsForProduct(productId);
            return View(model);
        }


        [HttpGet]

        public async Task<IActionResult> ShowUsersPosts()
        {
    
            var user= User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)?.Value;
            var model = await postService.GetPostsForUser(user);
            return View(model);
        }
        public async Task<IActionResult> RemovePost(int postId)
        {
            await postService.RemovePost(postId);
            return RedirectToAction("ShowUsersPosts", "Post");
        }
    }
}
