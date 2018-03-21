using System;
using Microsoft.AspNetCore.Mvc;
//using Microsoft.Extensions.Logging;
using MathWizard.Models;

namespace MathWizard.Controllers
{
    public class MathController : Controller
    {

        
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        

        public IActionResult AnotherWizard()
        {
            return View();
        }

        public IActionResult DoMathOp(MathOp mathOp)
        {

            //_logger.LogInformation("##### --> Operator Value: {0}", mathOp.Operator);

            if(ModelState.IsValid){

                switch(mathOp.Operator){

                    /*
                    Plus
                    Minus
                    Times
                    Divided By
                    Modulus
                    */

                    case "Plus":
                        mathOp.Result = 
                        mathOp.LeftOperand + mathOp.RightOperand;
                        break;
                    
                    case "Minus":
                        mathOp.Result = 
                        mathOp.LeftOperand - mathOp.RightOperand;                
                        break;

                    case "Times":
                        mathOp.Result = 
                        mathOp.LeftOperand * mathOp.RightOperand;                
                        break;
                    
                    case "Divided By":
                        //do not allow divide by zero
                        if(mathOp.RightOperand == 0)
                        {
                            //_logger.LogInformation("##### --> You tried to divide by: {0}", mathOp.RightOperand);
                            return View("Error");
                        }                    
                        mathOp.Result = 
                        mathOp.LeftOperand / mathOp.RightOperand;                
                        break;

                    case "Modulus":
                        mathOp.Result = 
                        mathOp.LeftOperand % mathOp.RightOperand;                
                        break;

                    default:
                        MathOp op = new MathOp();
                        op.LeftOperand = mathOp.LeftOperand;
                        op.RightOperand = mathOp.RightOperand;
                        op.Operator = mathOp.Operator;
                        op.Result = -999;
                        return View(op);
                        //break;
                        
                }                
            }
            else
            {
                //_logger.LogInformation("##### --> Model state error count: {0}", ModelState.ErrorCount);     
                return View("Error");
            }

            return View(mathOp);
        }
    }
}