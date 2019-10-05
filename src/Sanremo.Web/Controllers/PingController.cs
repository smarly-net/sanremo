﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Sanremo.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PingController : ControllerBase
    {
        [HttpGet]
        public ActionResult<string> Get()
        {
            return "Pong";
        }

        [HttpPost]
        public ActionResult<string> Post([FromBody] string value)
        {
            return $"Pong for 'value' {value}";
        }
    }
}
