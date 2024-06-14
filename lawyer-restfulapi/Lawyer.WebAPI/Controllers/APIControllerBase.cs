using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Lawyer.WebAPI.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public abstract class APIControllerBase : ControllerBase
    {
        protected int GetUserIdLogin()
        {
            var userId = HttpContext.User.Identity.Name;

            if (String.IsNullOrEmpty(userId))
            {
                return 0;
            }

            return int.Parse(userId);
        }

    }
}
