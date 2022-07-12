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
    public class CalculatorDivideController : ControllerBase
    {
      //Takes numbers for the division
        public double Divide([FromQuery] double num1, [FromQuery] double num2)
        {
            return Class1.Division(num1, num2);
        }

    }
}
