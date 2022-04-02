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
    public class CarsController : ControllerBase
    {
        ICarService _carService;

        public CarsController(ICarService productService)
        {
            _carService = productService;
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            // Dependency chain
            var result = _carService.GetAll();
            if (result.Success)
            {
                return Ok(result); // result.Data vs. Ok();
            }
            return BadRequest(result); // result.message de yazılablir
        }

        [HttpGet("getcarsbycolorid")]
        public IActionResult GetCarsByColorId(int id)
        {
            // Dependency chain
            var result = _carService.GetCarsByColorId(id);
            if (result.Success)
            {
                return Ok(result); // result.Data vs. Ok();
            }
            return BadRequest(result); // result.message de yazılablir
        }

        [HttpGet("getcardetails")]
        public IActionResult GetCarDetails()
        {
            // Dependency chain
            var result = _carService.GetCarDetails();
            if (result.Success)
            {
                return Ok(result); // result.Data vs. Ok();
            }
            return BadRequest(result); // result.message de yazılablir
        }

        [HttpPost("add")]
        public IActionResult Add(Car car)
        {
            // Dependency chain
            var result = _carService.Add(car);
            if (result.Success)
            {
                return Ok(result); // result.Data vs. Ok();
            }
            return BadRequest(result); // result.message de yazılablir
        }
    }
}
