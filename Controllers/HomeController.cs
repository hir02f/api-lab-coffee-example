﻿using Microsoft.AspNetCore.Mvc;

namespace API_Interactive_Lab_1.Controllers
{
    [ApiController]
  //  [Route("[controller]")]
    [Route("")]
    [Route("Home")]
    [Route("Home/Index")]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "Welcome to the Drinks API!";
        }
    }
}
