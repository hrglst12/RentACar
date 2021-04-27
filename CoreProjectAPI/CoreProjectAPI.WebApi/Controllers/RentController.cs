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
    public class RentController : ControllerBase
    {
        private readonly IService<Rents> _rentService;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="rentService"></param>
        public RentController(IService<Rents> rentService)
        {
            _rentService = rentService;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var data = await _rentService.GetAllAsync();
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
            var data = await _rentService.GetByIdAsync(id);
            if (data == null) return Ok();
            return Ok(data);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Rent"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Add(Rents Rent)
        {
            var data = await _rentService.AddAsync(Rent);
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
            var data = _rentService.GetByIdAsync(id).Result;
            _rentService.Remove(data);
            return NoContent();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Rent"></param>
        /// <returns></returns>
        [HttpPut]
        public IActionResult Update(Rents Rent)
        {
            var data =  _rentService.Update(Rent);
            return Ok(data);
        }
    }
}