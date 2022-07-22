using Calculator.Domain;
using System.Globalization;
using Xunit;

namespace TestProjectCalculator
{
    public class UnitTestOperation
    {
        [Theory]
        [InlineData(21, 3, 5, 36)]
        [InlineData(0, 2, 5, 10)]
        public void Summation_To_Value_Operand_Number_Iterations(decimal valueResult, decimal valueOperand, int NumberIterations, decimal expectResult)
        {
            var mathCalculator = new MathCalculator();

            for (var i = 0; i <= NumberIterations; i++)
            {
                valueResult = mathCalculator.Eval(valueResult.ToString(CultureInfo.InvariantCulture), valueOperand.ToString(CultureInfo.InvariantCulture), '+');
            }

            Assert.Equal(expectResult, valueResult);
        }

        [Theory]
        [InlineData(21, 3, 5, 6)]
        [InlineData(0, 2, 5, -10)]
        public void Subtraction_To_Value_Operand_Number_Iterations(decimal valueResult, decimal valueOperand, int NumberIterations, decimal expectResult)
        {
            var mathCalculator = new MathCalculator();

            for (var i = 0; i <= NumberIterations; i++)
            {
                valueResult = mathCalculator.Eval(valueResult.ToString(CultureInfo.InvariantCulture), valueOperand.ToString(CultureInfo.InvariantCulture), '-');
            }

            Assert.Equal(expectResult, valueResult);
        }

        [Theory]
        [InlineData(5, 5, 3, 625)]
        [InlineData(0, 2, 2, 0)]
        public void Multiplication_To_Value_Operand_Number_Iterations(decimal valueResult, decimal valueOperand, int NumberIterations, decimal expectResult)
        {
            var mathCalculator = new MathCalculator();

            for (var i = 0; i <= NumberIterations; i++)
            {
                valueResult = mathCalculator.Eval(valueResult.ToString(CultureInfo.InvariantCulture), valueOperand.ToString(CultureInfo.InvariantCulture), '*');
            }

            expectResult = System.Math.Round(expectResult, 6);

            Assert.Equal(expectResult, valueResult);
        }

        [Theory]
        [InlineData(150, 5, 2, 6)]
        [InlineData(0, 2, 2, 0)]
        public void Division_To_Value_Operand_Number_Iterations(decimal valueResult, decimal valueOperand, int NumberIterations, decimal expectResult)
        {
            var mathCalculator = new MathCalculator();

            for (var i = 0; i <= NumberIterations; i++)
            {
                valueResult = mathCalculator.Eval(valueResult.ToString(CultureInfo.InvariantCulture), valueOperand.ToString(CultureInfo.InvariantCulture), '/');
            }

            expectResult = System.Math.Round(expectResult, 6);

            Assert.Equal(expectResult, valueResult);
        }
    }
}