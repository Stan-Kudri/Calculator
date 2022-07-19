using System.Globalization;

namespace Calculator.Domain
{
    public class MathCalculator
    {
        private readonly static char[] Operation = new char[] { '+', '-', '*', '/', '=' };
        private char _pastOperation;
        private decimal _valueResult;
        private decimal _valueOperand;

        public decimal Eval(string outputValue, string inputValueOperand, char operation)
        {
            if (!Operation.Contains(operation))
                throw new ArgumentException("Неверная арифметическая операция");

            if (decimal.TryParse(outputValue, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out var firstValue))
                _valueResult = firstValue;

            if (decimal.TryParse(inputValueOperand, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out var secondValue))
            {
                if (outputValue.Length == 0)
                {
                    _valueResult = secondValue;
                }
                else if (Operation.Contains(_pastOperation))
                {
                    if (operation == '=')
                    {
                        _pastOperation = operation;
                    }
                    _valueResult = Calculate(_valueResult, secondValue, _pastOperation);
                }
            }
            else if (outputValue.Length == 0)
            {
                throw new ArgumentException("Неправильная числовая строка");
            }

            _pastOperation = operation;
            return Math.Round(_valueResult, 6);
        }

        public decimal Eval(string outputValue, string inputValueOperand)
        {
            if (decimal.TryParse(outputValue, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out var firstValue))
                _valueResult = firstValue;

            if (decimal.TryParse(inputValueOperand, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out var secondValue))
            {
                if (_pastOperation == '=')
                {
                    _valueResult = secondValue;
                }
                else
                {
                    _valueOperand = secondValue;
                    if (Operation.Contains(_pastOperation))
                        _valueResult = Calculate(_valueResult, secondValue, _pastOperation);
                }
            }
            else if (inputValueOperand.Length == 0)
            {
                if (_valueOperand == 0)
                    _valueOperand = _valueResult;
                _valueResult = Calculate(_valueResult, _valueOperand, _pastOperation);
            }
            else if (outputValue.Length == 0)
            {
                throw new ArgumentException("Неправильная числовая строка");
            }

            return Math.Round(_valueResult, 6);
        }

        private static decimal Calculate(decimal left, decimal right, char operation)
        {
            switch (operation)
            {
                case '+':
                    return left + right;
                case '-':
                    return left - right;
                case '*':
                    {
                        return left == 0 ? left : left * right;
                    }
                case '/':
                    {
                        if (right == 0)
                        {
                            throw new DivideByZeroException("Деление на 0 невозможно");
                        }
                        return left / right;
                    }
                case '=':
                    {
                        if (left == 0 || right == 0)
                        {
                            return 0;
                        }
                        return right;
                    }
            }
            throw new OperationCanceledException("Неизвестный оператор");
        }
    }
}
