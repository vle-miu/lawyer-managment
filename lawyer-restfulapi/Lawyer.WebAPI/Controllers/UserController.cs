using Lawyer.DomainEntities;
using Lawyer.Service.UserService;
using Lawyer.WebAPI.Models;
using Lawyer.WebAPI.Utils;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lawyer.WebAPI.Controllers
{
    public class UserController : APIControllerBase
    {
        private IUserService _userService;

        private readonly ILogger<UserController> _log;

        public UserController(IUserService userService, ILogger<UserController> log)
        {
            _userService = userService;
            _log = log;
        }

        [HttpGet("")]
        public IActionResult GetAllUsers()
        {
            _log.LogInformation("Get all users");

            List<UserModel> userModels = new List<UserModel>();

            _userService.GetAlls().ToList().ForEach(u =>
            {
                UserModel userModel = new UserModel
                {
                    ID = u.ID,
                    UserName = u.UserName,
                    Email = u.Email,
                    Age = u.Age,
                    Address = u.Address,
                    FirstName = u.FirstName,
                    LastName = u.LastName,
                    Role = u.Role
                };

                userModels.Add(userModel);
            });

            return Ok(userModels);
        }

        [HttpGet("{id}")]
        public IActionResult GetUserByID(int? id)
        {

            if (id.HasValue && id != 0)
            {
                var user = _userService.Get(id.Value);

                if (user != null)
                {
                    UserModel userModel = new UserModel
                    {
                        ID = user.ID,
                        UserName = user.UserName,
                        Email = user.Email,
                        Address = user.Address,
                        Age = user.Age,
                        FirstName = user.FirstName,
                        LastName = user.LastName,
                        Role = user.Role
                    };
                    return Ok(userModel);
                }

                return NotFound(new { message = "Not found User" });

            }

            return BadRequest(new { message = "UserID is invalid" });

        }

        [HttpPost]
        public IActionResult AddUser([FromBody] UserModel model)
        {
            var userId = GetUserIdLogin();
            User user = new User
            {
                UserName = model.UserName,
                Password = EncodeUtils.EncodePassword(model.Password),
                Email = model.Email,
                Address = model.Address,
                Age = model.Age,
                FirstName = model.FirstName,
                LastName = model.LastName,
                Role = model.Role,
                CreatedUser = userId,
                UpdatedUser = userId
            };

            _userService.Insert(user);
            return Ok(user);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] UserModel model)
        {
            var userId = GetUserIdLogin();

            User user = _userService.Get(id);

            user.Email = model.Email;
            user.FirstName = model.FirstName;
            user.LastName = model.LastName;
            user.Age = model.Age;
            user.Address = model.Address;
            user.UpdatedUser = userId;

            _userService.Update(user);

            return Ok(user);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _userService.Delete(id);
            return Ok();
        }
    }
}
