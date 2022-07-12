using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CalculatorLogic;


namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        //Takes numbers for addition
        [HttpGet]
        public double Add([FromQuery] double num1, [FromQuery] double num2)
        {
            return Class1.Addition(num1, num2);
        }

    }
}
