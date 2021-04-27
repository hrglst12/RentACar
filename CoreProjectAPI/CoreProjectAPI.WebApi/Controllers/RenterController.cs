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
    public class RenterController : ControllerBase
    {
        private readonly IService<Renters> _renterService;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="renterService"></param>
        public RenterController(IService<Renters> renterService)
        {
            _renterService = renterService;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var data = await _renterService.GetAllAsync();
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
            var data = await _renterService.GetByIdAsync(id);
            if (data == null) return Ok();
            return Ok(data);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Renter"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Add(Renters Renter)
        {
            var data = await _renterService.AddAsync(Renter);
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
            var data = _renterService.GetByIdAsync(id).Result;
            _renterService.Remove(data);
            return NoContent();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Renter"></param>
        /// <returns></returns>
        [HttpPut]
        public IActionResult Update(Renters Renter)
        {
            var data = _renterService.Update(Renter);
            return Ok(data);
        }
    }
}