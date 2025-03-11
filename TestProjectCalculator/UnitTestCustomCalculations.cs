using Calculator.Domain;
using System.Globalization;
using Xunit;

namespace TestProjectCalculator
{
    public class UnitTestCustomCalculations
    {
        [Theory]
        [InlineData(21, 5, 126)]
        [InlineData(0, 4, 0)]
        public void Perform_Summation_Previous_Operand_When_Pressing_Equals(decimal valueResult, int numberIterations, decimal expectResult)
        {
            var mathCalculator = new MathCalculator();

            valueResult = mathCalculator.Eval(ValueToString(valueResult), string.Empty, '+');

            for (var i = 0; i < numberIterations; i++)
            {
                valueResult = mathCalculator.Eval(ValueToString(valueResult), string.Empty);
            }

            Assert.Equal(expectResult, valueResult);
        }

        [Theory]
        [InlineData(21, 4, 5, 41)]
        [InlineData(0, 3, 4, 12)]
        public void Performing_Summation_Without_Operand_When_Pressing_Equals(decimal valueResult, decimal valueOperand, int numberIterations, decimal expectResult)
        {
            var mathCalculator = new MathCalculator();

            valueResult = mathCalculator.Eval(ValueToString(valueResult), ValueToString(valueOperand), '+');
            valueResult = mathCalculator.Eval(ValueToString(valueResult), ValueToString(valueOperand));

            for (var i = 0; i < numberIterations - 1; i++)
            {
                valueResult = mathCalculator.Eval(ValueToString(valueResult), string.Empty);
            }

            Assert.Equal(expectResult, valueResult);
        }

        [Theory]
        [InlineData(21, 5, -84)]
        [InlineData(0, 4, 0)]
        public void Perform_Subtraction_Previous_Operand_When_Pressing_Equals(decimal valueResult, int numberIterations, decimal expectResult)
        {
            var mathCalculator = new MathCalculator();

            valueResult = mathCalculator.Eval(ValueToString(valueResult), string.Empty, '-');

            for (var i = 0; i < numberIterations; i++)
            {
                valueResult = mathCalculator.Eval(ValueToString(valueResult), string.Empty);
            }

            Assert.Equal(expectResult, valueResult);
        }

        [Theory]
        [InlineData(21, 4, 6, -3)]
        [InlineData(0, 3, 4, -12)]
        public void Performing_Subtraction_Without_Operand_When_Pressing_Equals(decimal valueResult, decimal valueOperand, int numberIterations, decimal expectResult)
        {
            var mathCalculator = new MathCalculator();

            valueResult = mathCalculator.Eval(ValueToString(valueResult), ValueToString(valueOperand), '-');
            valueResult = mathCalculator.Eval(ValueToString(valueResult), valueOperand.ToString());

            for (var i = 0; i < numberIterations - 1; i++)
            {
                valueResult = mathCalculator.Eval(ValueToString(valueResult), string.Empty);
            }

            Assert.Equal(expectResult, valueResult);
        }

        [Theory]
        [InlineData(21, 1, 441)]
        [InlineData(0, 4, 0)]
        public void Perform_Multiplication_Previous_Operand_When_Pressing_Equals(decimal valueResult, int numberIterations, decimal expectResult)
        {
            var mathCalculator = new MathCalculator();

            valueResult = mathCalculator.Eval(ValueToString(valueResult), string.Empty, 'х');

            for (var i = 0; i < numberIterations; i++)
            {
                valueResult = mathCalculator.Eval(ValueToString(valueResult), string.Empty);
            }

            Assert.Equal(expectResult, valueResult);
        }

        [Theory]
        [InlineData(21, 3, 4, 1701)]
        [InlineData(0, 3, 2, 0)]
        public void Performing_Multiplication_Without_Operand_When_Pressing_Equals(decimal valueResult, decimal valueOperand, int numberIterations, decimal expectResult)
        {
            var mathCalculator = new MathCalculator();

            valueResult = mathCalculator.Eval(ValueToString(valueResult), ValueToString(valueOperand), 'х');
            valueResult = mathCalculator.Eval(ValueToString(valueResult), ValueToString(valueOperand));

            for (var i = 0; i < numberIterations - 1; i++)
            {
                valueResult = mathCalculator.Eval(valueResult.ToString(CultureInfo.InvariantCulture), string.Empty);
            }

            Assert.Equal(expectResult, valueResult);
        }

        [Theory]
        [InlineData(21, 2, 0.047619)]
        public void Perform_Division_Previous_Operand_When_Pressing_Equals(decimal valueResult, int numberIterations, decimal expectResult)
        {
            var mathCalculator = new MathCalculator();

            valueResult = mathCalculator.Eval(ValueToString(valueResult), string.Empty, '/');

            for (var i = 0; i < numberIterations; i++)
            {
                valueResult = mathCalculator.Eval(ValueToString(valueResult), string.Empty);
            }

            Assert.Equal(expectResult, valueResult);
        }

        [Theory]
        [InlineData(21, 3, 3, 0.777778)]
        public void Performing_Division_Without_Operand_When_Pressing_Equals(decimal valueResult, decimal valueOperand, int numberIterations, decimal expectResult)
        {
            var mathCalculator = new MathCalculator();

            valueResult = mathCalculator.Eval(ValueToString(valueResult), ValueToString(valueOperand), '/');
            valueResult = mathCalculator.Eval(ValueToString(valueResult), ValueToString(valueOperand));

            for (var i = 0; i < numberIterations - 1; i++)
            {
                valueResult = mathCalculator.Eval(ValueToString(valueResult), string.Empty);
            }

            Assert.Equal(expectResult, valueResult);
        }

        private static string ValueToString(decimal value) => value.ToString(CultureInfo.InvariantCulture);
    }
}
