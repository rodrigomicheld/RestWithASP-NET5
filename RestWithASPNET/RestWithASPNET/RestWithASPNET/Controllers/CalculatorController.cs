using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestWithASPNET.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculatorController : ControllerBase
    {
        private readonly ILogger<CalculatorController> _logger;

        public CalculatorController(ILogger<CalculatorController> logger)
        {
            _logger = logger;
        }

        [HttpGet("sum/{firstNumber}/{secondNumber}")]
        public IActionResult Sum(string firstNumeber, string secondNumber)
        {

            if (IsNumeric(firstNumeber) && IsNumeric(secondNumber))
            {

                var result = decimal.Parse(firstNumeber) + decimal.Parse(secondNumber);
                return Ok(result.ToString());

            }
            return BadRequest("Invalid Input");
        }

        [HttpGet("subtraction/{firstNumber}/{secondNumber}")]
        public IActionResult Subtraction(string firstNumeber, string secondNumber)
        {

            if (IsNumeric(firstNumeber) && IsNumeric(secondNumber))
            {

                var result = decimal.Parse(firstNumeber) - decimal.Parse(secondNumber);
                return Ok(result.ToString());

            }
            return BadRequest("Invalid Input");
        }

        [HttpGet("multiplication/{firstNumber}/{secondNumber}")]
        public IActionResult Multiplication(string firstNumber, string secondNumber)
        {

            if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
            {

                var result = decimal.Parse(firstNumber) * decimal.Parse(secondNumber);
                return Ok(result.ToString());

            }
            return BadRequest("Invalid Input");
        }

        [HttpGet("division/{firstNumber}/{secondNumber}")]
        public IActionResult Division(string firstNumber, string secondNumber)
        {

            if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
            {

                var result = decimal.Parse(firstNumber) / decimal.Parse(secondNumber);
                return Ok(result.ToString());

            }
            return BadRequest("Invalid Input");
        }

        [HttpGet("average/{firstNumber}/{secondNumber}")]
        public IActionResult Average(string firstNumber, string secondNumber)
        {

            if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
            {

                var result = (decimal.Parse(firstNumber) + decimal.Parse(secondNumber)) / 2;
                return Ok(result.ToString());

            }
            return BadRequest("Invalid Input");
        }

        [HttpGet("square-root/{firstNumber}")]
        public IActionResult SquareRoot(string firstNumber)
        {

            if (IsNumeric(firstNumber))
            {

                var result = Math.Sqrt(double.Parse(firstNumber));
                return Ok(result.ToString());

            }
            return BadRequest("Invalid Input");
        }

        private bool IsNumeric(string strNumber)
        {
            double number;
            bool isNumber = double.TryParse(strNumber, System.Globalization.NumberStyles.Any, System.Globalization.NumberFormatInfo.InvariantInfo, out number);
            return isNumber;
        }
    }

        
    
}
