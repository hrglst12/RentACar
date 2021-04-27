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
    public class FirmController : ControllerBase
    {
        private readonly IService<Firms> _firmService;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="firmService"></param>
        public FirmController(IService<Firms> firmService)
        {
            _firmService = firmService;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var data = await _firmService.GetAllAsync();
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
            var data = await _firmService.GetByIdAsync(id);
            if (data == null) return Ok();
            return Ok(data);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Firm"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Add(Firms Firm)
        {
            var data = await _firmService.AddAsync(Firm);
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
            var data =  _firmService.GetByIdAsync(id).Result;
            _firmService.Remove(data);
            return NoContent();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Firm"></param>
        /// <returns></returns>
        [HttpPut]
        public IActionResult Update(Firms Firm)
        {
            var data =  _firmService.Update(Firm);
            return Ok(data);
        }
    }
}