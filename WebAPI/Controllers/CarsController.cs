﻿using Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities.Concrete;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        private ICarService _carService;
        public CarsController(ICarService carService)
        {
            _carService = carService;
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _carService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _carService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpGet("getallbybrandid")]
        public IActionResult GetAllByBrandId(int id)
        {
            var result = _carService.GetAllByBrandId(id);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpGet("getallbycolorid")]
        public IActionResult GetAllByColorId(int id)
        {
            var result = _carService.GetAllByColorId(id);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpGet("getbydailyprice")]
        public IActionResult GetByDailyPrice(decimal min, decimal max)
        {
            var result = _carService.GetByDailyPrice(min, max);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpGet("getcarsdetails")]
        public IActionResult GetCarsDetails()
        {
            var result = _carService.GetCarsDetails();
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpGet("getcardetails")]
        public IActionResult GetCarDetails(int id)
        {
            var result = _carService.GetCarDetails(id);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpGet("getcarsdetailsbybrand")]
        public IActionResult GetCarsDetailsByBrand(int id)
        {
            var result = _carService.GetCarsDetailsByBrand(id);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpGet("getcarsdetailsbycolor")]
        public IActionResult GetCarsDetailsByColor(int id)
        {
            var result = _carService.GetCarsDetailsByColor(id);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpGet("getcarsdetailsbybrandandcolor")]
        public IActionResult GetCarsDetailsByBrandAndColor(int brandId, int colorId)
        {
            var result = _carService.GetCarsDetailsByBrandAndColor(brandId, colorId);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(Car car)
        {
            var result = _carService.Add(car);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(Car car)
        {
            var result = _carService.Update(car);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(Car car)
        {
            var result = _carService.Delete(car);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }
    }
}
