﻿using Calculator.Domain;
using System;
using Xunit;
using ApplicationException = Calculator.Domain.ApplicationException;

namespace TestProjectCalculator
{
    public class UnitTestByExceptionMathCalculator
    {
        [Theory]
        [InlineData(21, typeof(ApplicationException))]
        public void Division_By_Zero_Exception(decimal valueResult, Type expectType)
        {
            var mathCalculator = new MathCalculator();

            valueResult = mathCalculator.Eval(valueResult.ToString(), "0", '/');

            Assert.Throws(expectType, () =>
            {
                mathCalculator.Eval(valueResult.ToString(), "0");
            });
        }

    }
}