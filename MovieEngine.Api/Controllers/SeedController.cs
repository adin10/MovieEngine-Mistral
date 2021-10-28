using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MovieEngine.Infrastructure.Roles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieEngine.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SeedController : ControllerBase
    {
        private readonly UserManager<IdentityUser<int>> _userManager;
        private readonly RoleManager<IdentityRole<int>> _roleManager;

        public SeedController(UserManager<IdentityUser<int>> userManager, RoleManager<IdentityRole<int>> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync()
        {
            var user = new IdentityUser<int>
            {
                Email = "adin.smajkic@edu.fit.ba",
                EmailConfirmed = true,
                UserName = "adinsmajkic",
            };

            var userResult = await _userManager.CreateAsync(user, "Test123*");
            var roleResult = await _roleManager.CreateAsync(new IdentityRole<int>(Role.Admin.ToString()));
            var userRoleResult = await _userManager.AddToRoleAsync(user, Role.Admin.ToString());
            //user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, "test");
            //await _userManager.CreateAsync(user, "test");

            //var role = userrole.CreateAsync(new IdentityRole<int>
            //{
            //    ConcurrencyStamp = Guid.NewGuid().ToString(),
            //    Name = Role.Admin.ToString()
            //});
            //await _userManager.AddToRoleAsync(user, Role.Admin.ToString());

            return Ok();
        }
    }
}
