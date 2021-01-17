using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Application;

namespace API.Controllers
{
    [Route("api/calculate")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        private readonly Calculator _calculator;

        public CalculatorController(){
            _calculator = new Calculator();
        }

        [HttpGet("index")]
        public ActionResult<string> Index() {
            return "Hello";
        }

        [HttpPost("add")]
        public ActionResult<int> Add(AddInput input) {
            return _calculator.Add(input);
            
        }

        [HttpPost("substract")]
        public ActionResult<int> Substract(SubstractInput input) {
            return _calculator.Substract(input);
        }

        [HttpPost("multiply")]
        public ActionResult<int> Multiply(MultiplyInput input) {
            return _calculator.Multiply(input);
        }

        [HttpPost("divide")]
        public ActionResult<double> Divide(DivideInput input) {
            return _calculator.Divide(input);
        }

        [HttpPost("splitEq")]
        public ActionResult<List<int>> SplitEq(SplitEqInput input) {
            return _calculator.SplitEq(input);
        }

        [HttpPost("splitNum")]
        public ActionResult<int> SplitNum(SplitNumInput input) {
            return _calculator.SplitNum(input);
        }
    }
}