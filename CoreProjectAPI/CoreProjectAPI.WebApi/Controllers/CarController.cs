using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreProjectAPI.Core.Entities;
using CoreProjectAPI.Core.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoreProjectAPI.WebApi.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class CarController : ControllerBase
    {
        private readonly IService<Cars> _carService;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="carService"></param>
        public CarController(IService<Cars> carService)
        {
           _carService = carService;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var data = await _carService.GetAllAsync();
            return Ok(data);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var data = await _carService.GetByIdAsync(id);
            if (data == null) return Ok();
            return Ok(data);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="car"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Add(Cars car)
        {
            var data = await _carService.AddAsync(car);
            return Ok(data);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var data = _carService.GetByIdAsync(id).Result;
            _carService.Remove(data);
            return NoContent();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="car"></param>
        /// <returns></returns>
        [HttpPut]
        public IActionResult Update(Cars car)
        {
            var data =  _carService.Update(car);
            return Ok(data);
        }
    }
}