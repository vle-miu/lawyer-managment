using Lawyer.Service.UserService;
using Lawyer.WebAPI.Configurations;
using Lawyer.WebAPI.Models;
using Lawyer.WebAPI.Utils;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace Lawyer.WebAPI.Controllers
{
    public class LoginController : APIControllerBase
    {
        private IUserService _userService;

        private readonly ApplicationSettings _appSettings;

        public LoginController(IOptions<ApplicationSettings> appSettings, IUserService userService)
        {
            _appSettings = appSettings.Value;
            _userService = userService;
        }

        [AllowAnonymous]
        [HttpPost("")]
        public IActionResult Login([FromBody]LoginModel model)
        {
            var user = _userService.authentication(model.UserName, EncodeUtils.EncodePassword(model.Password));

            if (user == null)
            {
                return BadRequest(new { message = "Username or password is incorrect" });
            }

            string tokenString = TokenUtils.GenerateJSONWebToken(user, _appSettings.JWT_secret);

            return Ok(new
            {
                ID = user.ID,
                UserName = user.UserName,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Token = tokenString
            });
        }
    }
}
