using BabyKat.Core.Contracts;
using BabyKat.Core.Models.Userr;
using BabyKat.Core.Services;
using BabyKat.Infrastructure.Data;
using BabyKat.Models;

using Library.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BabyKat.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class UserController : Controller
    {
        private readonly UserManager<User> userManager;

        private readonly IUserService userService;
        private readonly RoleManager<IdentityRole> roleManager;


        public UserController(
            UserManager<User> _userManager,
             RoleManager<IdentityRole> _roleManager, IUserService _userService)
        {
            userManager = _userManager;
            userService = _userService;
            roleManager = _roleManager;
        }

        public async Task<IActionResult> UserSetting()
        {
            var users = await userService.GetAllUsers();

            return View(users);
        }

     
       public async Task<IActionResult> Roles(string id)
       {
          var user = await userService.GetUserById(id);
           var model = new UserChangeRoleModel()
         {
               Id = id,
               UserName = user.UserName
         };


         ViewBag.RoleItems = roleManager.Roles
         .ToList()
         .Select(r => new SelectListItem()
         {
               Text = r.Name,
               Value = r.Name,
               Selected = userManager.IsInRoleAsync(user, r.Name).Result
          }).ToList();

        return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Roles(UserChangeRoleModel model)
        {
           var user = await userService.GetUserById(model.Id);
           var userRoles = await userManager.GetRolesAsync(user);
           await userManager.RemoveFromRolesAsync(user, userRoles);

         if (model.roles?.Length > 0)
          {
              await userManager.AddToRolesAsync(user, model.roles);
          }

            return RedirectToAction(nameof(UserSetting));
        }

    }
}
