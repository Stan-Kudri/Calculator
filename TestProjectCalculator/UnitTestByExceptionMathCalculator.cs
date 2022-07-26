using Calculator.Domain;
using System;
using System.Globalization;
using Xunit;

namespace TestProjectCalculator
{
    public class UnitTestByExceptionMathCalculator
    {
        [Theory]
        [InlineData(21)]
        public void Division_By_Zero_Exception(decimal valueResult)
        {
            var mathCalculator = new MathCalculator();

            valueResult = mathCalculator.Eval(valueResult.ToString(CultureInfo.InvariantCulture), "0", '/');

            Assert.Throws<ApplicationException>(() =>
            {
                mathCalculator.Eval(valueResult.ToString(CultureInfo.InvariantCulture), "0");
            });
        }

        [Theory]
        [InlineData("kpl", "lp")]
        public void Bad_Format_Strings(string txtResult, string txtOperand)
        {
            var mathCalculator = new MathCalculator();

            Assert.Throws<ArgumentException>(() =>
            {
                mathCalculator.Eval(txtResult.ToString(CultureInfo.InvariantCulture), txtOperand.ToString(CultureInfo.InvariantCulture));
            });
        }
    }
}
