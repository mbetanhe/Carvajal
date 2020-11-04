using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Carvajal.API.Utilities;
using Carvajal.CORE.Entities;
using Carvajal.CORE.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Carvajal.API.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;

        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }


        [HttpGet]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public IActionResult GetAll()
        {
            var response = new ApiResponse<IEnumerable<User>>(_userRepository.GetAll());

            response.StatusCode = response.Data == null ? (int)HttpStatusCode.NotFound : (int)HttpStatusCode.OK;

            return StatusCode(response.StatusCode, response.Data);
        }
    }
}