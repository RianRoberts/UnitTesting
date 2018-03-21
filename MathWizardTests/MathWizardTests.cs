using System;
using MathWizard.Controllers;
using MathWizard.Models;
using Microsoft.AspNetCore.Mvc;
using Xunit;

namespace MathWizardTests {
    public class MathWizardTests {
        private MathController controller = new MathController ();

        [Fact]
        public void TestAddition () {
            //Arrange
            MathOp op = new MathOp ();
            op.LeftOperand = 30;
            op.RightOperand = 30;
            op.Operator = "plus";
            op.Result = 0;

            //Act
            ViewResult vr = (ViewResult) controller.DoMathOp (op);
            MathOp model = (MathOp) vr.Model;
            //Assert
            Assert.Equal (60, model.Result);

        }

         [Fact]
        public void TestSubtraction () {
            //Arrange
            MathOp op = new MathOp ();
            op.LeftOperand = 30;
            op.RightOperand = 20;
            op.Operator = "Minus";
            op.Result = 0;

            //Act
            ViewResult vr = (ViewResult) controller.DoMathOp (op);
            MathOp model = (MathOp) vr.Model;
            //Assert
            Assert.Equal (10, model.Result);

        }
         [Fact]
        public void TestMultiplication () {
            //Arrange
            MathOp op = new MathOp ();
            op.LeftOperand = 30;
            op.RightOperand = 30;
            op.Operator = "Times";
            op.Result = 0;

            //Act
            ViewResult vr = (ViewResult) controller.DoMathOp (op);
            MathOp model = (MathOp) vr.Model;
            //Assert
            Assert.Equal (900, model.Result);

        }

         [Fact]
        public void TestDivision () {
            //Arrange
            MathOp op = new MathOp ();
            op.LeftOperand = 30;
            op.RightOperand = 20;
            op.Operator = "Divided By";
            op.Result = 0;

            //Act
            ViewResult vr = (ViewResult) controller.DoMathOp (op);
            MathOp model = (MathOp) vr.Model;
            //Assert
            Assert.Equal (1.5, Math.Round(model.Result, 1) );

        }
    }
}