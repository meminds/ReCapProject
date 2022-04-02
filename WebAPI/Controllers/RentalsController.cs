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
    public class RentalsController : ControllerBase
    {
        IRentalService _rentalService;

        public RentalsController(IRentalService rentalService)
        {
            _rentalService = rentalService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            // Dependency chain
            var result = _rentalService.GetAll();
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
            var result = _rentalService.GetById(id);
            if (result.Success)
            {
                return Ok(result); // result.Data vs. Ok();
            }
            return BadRequest(result); // result.message de yazılablir
        }

        [HttpPost("add")]
        public IActionResult Add(Rental rental)
        {
            // Dependency chain
            var result = _rentalService.Add(rental);
            if (result.Success)
            {
                return Ok(result); // result.Data vs. Ok();
            }
            return BadRequest(result); // result.message de yazılablir
        }

        [HttpPost("update")]
        public IActionResult Update(Rental rental)
        {
            // Dependency chain
            var result = _rentalService.Update(rental);
            if (result.Success)
            {
                return Ok(result); // result.Data vs. Ok();
            }
            return BadRequest(result); // result.message de yazılablir
        }

        [HttpPost("delete")]
        public IActionResult Delete(Rental rental)
        {
            // Dependency chain
            var result = _rentalService.Delete(rental);
            if (result.Success)
            {
                return Ok(result); // result.Data vs. Ok();
            }
            return BadRequest(result); // result.message de yazılablir
        }
    }
}
