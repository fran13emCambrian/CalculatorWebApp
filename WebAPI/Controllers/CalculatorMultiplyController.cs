using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CalculatorLogic;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorMultiplyController : ControllerBase
    {
        //Get two numbers to multiply
        [HttpGet]
        public double Multiply([FromQuery] double num1, [FromQuery] double num2)
        {
            return Class1.Multiplication(num1, num2);
        }

    }
}
