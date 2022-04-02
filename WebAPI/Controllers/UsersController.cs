using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        IUserService _userService;

        public UsersController(IUserService rentalService)
        {
            _userService = rentalService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            // Dependency chain
            var result = _userService.GetAll();
            if (result.Success)
            {
                return Ok(result); // result.Data vs. Ok();
            }
            return BadRequest(result); // result.message de yazılablir
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            // Dependency chain
            var result = _userService.GetById(id);
            if (result.Success)
            {
                return Ok(result); // result.Data vs. Ok();
            }
            return BadRequest(result); // result.message de yazılablir
        }

        [HttpPost("add")]
        public IActionResult Add(User user)
        {
            // Dependency chain
            var result = _userService.Add(user);
            if (result.Success)
            {
                return Ok(result); // result.Data vs. Ok();
            }
            return BadRequest(result); // result.message de yazılablir
        }

        [HttpPost("update")]
        public IActionResult Update(User user)
        {
            // Dependency chain
            var result = _userService.Update(user);
            if (result.Success)
            {
                return Ok(result); // result.Data vs. Ok();
            }
            return BadRequest(result); // result.message de yazılablir
        }
    }
}
