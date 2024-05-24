using IdentityServer.Dtos;
using IdentityServer.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using static IdentityServer4.IdentityServerConstants;

namespace IdentityServer.Controllers
{
    [Authorize(LocalApi.PolicyName)]
    [Route("api/[controller]")]
    [ApiController]
    public class RegistrationController : ControllerBase
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public RegistrationController(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpPost]
        public async Task<IActionResult> Register(UserRegisterDto request)
        {
            var user = new ApplicationUser()
            {
                UserName = request.Username,
                Email = request.Email,
                Name = request.FirstName,
                Surname = request.LastName
            };
            var result = await _userManager.CreateAsync(user,request.Password);
            if (result.Succeeded)
                return Ok("User is added successfully.");
            else
                return Ok("There is a problem. Please try again.");
        }
    }
}
