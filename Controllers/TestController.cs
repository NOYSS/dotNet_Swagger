﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WebCoreAPI.Services;
using WebCoreAPI.Services.Central;

namespace WebCoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpGet]
        [ApiExplorerSettings(GroupName = "v1")]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
      [HttpGet("{id}")]
        [ApiExplorerSettings(GroupName = "v1")]
        public async Task<IActionResult> Get(int id)
        {
            DicService c = new DicService();

            var responseContent = await c.getById(id);
                return Ok(responseContent);
            
        }

        // POST api/values
        [HttpPost]
        [ApiExplorerSettings(GroupName = "v2")]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        [ApiExplorerSettings(GroupName = "v2")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        [ApiExplorerSettings(GroupName = "v2")]
        public void Delete(int id)
        {
        }
    }
}