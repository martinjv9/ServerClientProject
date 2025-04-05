using System.IdentityModel.Tokens.Jwt;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ServerProject.Dtos;
using StinkyModule;

namespace ServerProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController(UserManager<WorldCitiesUser> userManager, JwtHandler jwtHandler) : ControllerBase
    {
        [HttpPost("Login")]
        public async Task<ActionResult> LoginAsync(LoginRequest request)
        {
            WorldCitiesUser user = await userManager.FindByNameAsync(request.UserName);
            if (user == null) {
                return Unauthorized("Error: Unknown User"); // Just for testing
            }

            bool success = await userManager.CheckPasswordAsync(user, request.Password);
            if (!success) {
                return Unauthorized("Error: Bad Password");
            }

            JwtSecurityToken token = await jwtHandler.GetTokenAsync(user);

            string tokenString = new JwtSecurityTokenHandler().WriteToken(token);

            return Ok(new LoginResult
            {
                Success = true,
                Message = "Mom loves me",
                Token = tokenString
            });

        }
    }
}
