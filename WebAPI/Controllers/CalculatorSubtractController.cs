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
    public class CalculatorSubtractController : ControllerBase
    {
        //Get numbers to subtract
        [HttpGet]
        public double Subtract([FromQuery] double num1, [FromQuery] double num2)
        {
            return Class1.Subtraction(num1, num2);
        }

    }
}
