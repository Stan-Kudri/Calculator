using Calculator.Domain;
using Xunit;

namespace TestProjectCalculator
{
    public class UnitTestCustomCalculations
    {
        [Theory]
        [InlineData(21, 5, 126)]
        [InlineData(0, 4, 0)]
        public void Perform_Summing_Previous_Operand_When_Pressing_Equals(decimal valueResult, int numberIterations, decimal expectResult)
        {
            var mathCalculator = new MathCalculator();

            valueResult = mathCalculator.Eval(valueResult.ToString(), string.Empty, '+');

            for (var i = 0; i < numberIterations; i++)
            {
                valueResult = mathCalculator.Eval(valueResult.ToString(), string.Empty);
            }

            Assert.Equal(expectResult, valueResult);
        }

        [Theory]
        [InlineData(21, 4, 5, 41)]
        [InlineData(0, 3, 4, 12)]
        public void Performing_Summation_Without_Operand_When_Pressing_Equals(decimal valueResult, decimal valueOperand, int numberIterations, decimal expectResult)
        {
            var mathCalculator = new MathCalculator();

            valueResult = mathCalculator.Eval(valueResult.ToString(), valueOperand.ToString(), '+');
            valueResult = mathCalculator.Eval(valueResult.ToString(), valueOperand.ToString());

            for (var i = 0; i < numberIterations - 1; i++)
            {
                valueResult = mathCalculator.Eval(valueResult.ToString(), string.Empty);
            }

            Assert.Equal(expectResult, valueResult);
        }
    }
}
