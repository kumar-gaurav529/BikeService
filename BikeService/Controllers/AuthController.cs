using BikeService.Interfaces;
using BikeService.Utility;
using BikeService.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BikeService.Controllers
{
 
    [Route("api")]
    [ApiController]
    public class AuthController : Controller
    {
        #region variables
        private readonly IAuthService authService;



        #endregion

        #region constructor
        public AuthController(IAuthService _authService)
        {
            authService = _authService;
        }
        #endregion


        [HttpPost, Route("createToken")]
        public ActionResult CreateToken([FromBody] LoginViewModal modal)
        {
            if (!ModelState.IsValid) return BadRequest(new ApiError(ModelState));
            var (token, succeeded, message) = authService.GetToken(modal);
            if (succeeded) return Ok(new { token.TokenString, token.ExpireOn });
            return BadRequest(message);
        }
    }
}
