using Calculator.Domain;
using Xunit;

namespace TestProjectCalculator
{
    public class UnitTestOperation
    {
        [Theory]
        [InlineData(21, 3, 5)]
        [InlineData(0, 2, 5)]
        public void Summation_To_Value_Operand_Number_Iterations(decimal valueResult, decimal valueOperand, int NumberIterations)
        {
            var mathCalculator = new MathCalculator();

            var expectResult = valueResult + (NumberIterations * valueOperand);


            for (var i = 0; i < NumberIterations; i++)
            {
                valueResult = mathCalculator.Eval(valueResult.ToString(), valueOperand.ToString(), '+');
            }

            Assert.Equal(expectResult, valueResult);
        }

        [Theory]
        [InlineData(5, 5, 3)]
        [InlineData(0, 2, 2)]
        public void Multiplication_To_Value_Operand_Number_Iterations(decimal valueResult, decimal valueOperand, int NumberIterations)
        {
            var mathCalculator = new MathCalculator();

            var expectResult = valueResult;

            for (var i = 0; i < NumberIterations; i++)
            {
                expectResult *= valueOperand;
                valueResult = mathCalculator.Eval(valueResult.ToString(), valueOperand.ToString(), '*');
            }

            Assert.Equal(expectResult, valueResult);
        }

        [Theory]
        [InlineData(145, 3, 3)]
        [InlineData(0, 2, 2)]
        public void Division_To_Value_Operand_Number_Iterations(decimal valueResult, decimal valueOperand, int NumberIterations)
        {
            var mathCalculator = new MathCalculator();

            var expectResult = valueResult;

            for (var i = 0; i < NumberIterations; i++)
            {
                expectResult /= valueOperand;
                valueResult = mathCalculator.Eval(valueResult.ToString(), valueOperand.ToString(), '/');
            }

            expectResult = System.Math.Round(expectResult, 6);

            Assert.Equal(expectResult, valueResult);
        }
    }
}