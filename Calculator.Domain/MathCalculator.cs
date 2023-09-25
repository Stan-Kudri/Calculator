using System.Globalization;

namespace Calculator.Domain
{
    public class MathCalculator
    {
        public const int DecimalPlace = 6;
        public const char EqualTo = '=';

        private readonly static char[] Operation = new char[] { '+', '-', '*', '/', '=' };

        private char _pastOperation;
        private decimal _valueResult;
        private decimal _valueOperand;

        public decimal Eval(string outputValue, string inputValueOperand, char operation)
        {
            if (!Operation.Contains(operation))
            {
                throw new ArgumentException("Неверная арифметическая операция");
            }

            if (TryParseValue(outputValue, out var firstValue))
            {
                _valueResult = firstValue;
            }

            if (TryParseValue(inputValueOperand, out var secondValue))
            {
                if (outputValue.Length == 0)
                {
                    _valueResult = secondValue;
                }
                else if (Operation.Contains(_pastOperation))
                {
                    if (operation == EqualTo)
                    {
                        _pastOperation = operation;
                    }
                    _valueResult = Calculate(_valueResult, secondValue, _pastOperation);
                }
            }
            else if (outputValue.Length > 0 && inputValueOperand.Length > 0)
            {
                throw new ArgumentException("Неправильная числовая строка");
            }

            _pastOperation = operation;
            return Math.Round(_valueResult, DecimalPlace);
        }

        public decimal Eval(string outputValue, string inputValueOperand)
        {
            if (TryParseValue(outputValue, out var firstValue))
            {
                _valueResult = firstValue;
            }

            if (TryParseValue(inputValueOperand, out var secondValue))
            {
                if (_pastOperation == EqualTo)
                {
                    _valueResult = secondValue;
                }
                else
                {
                    _valueOperand = secondValue;

                    if (Operation.Contains(_pastOperation))
                    {
                        _valueResult = Calculate(_valueResult, secondValue, _pastOperation);
                    }
                }
            }
            else if (inputValueOperand.Length == 0)
            {
                if (_valueOperand == 0)
                {
                    _valueOperand = _valueResult;
                }

                _valueResult = Calculate(_valueResult, _valueOperand, _pastOperation);
            }
            else if (outputValue.Length > 0 && inputValueOperand.Length > 0)
            {
                throw new ArgumentException("Неправильная числовая строка");
            }

            if (!Operation.Contains(_pastOperation))
            {
                _pastOperation = EqualTo;
            }

            return Math.Round(_valueResult, DecimalPlace);
        }

        private bool TryParseValue(string txt, out decimal result)
        {
            if (decimal.TryParse(txt, NumberStyles.AllowDecimalPoint | NumberStyles.AllowLeadingSign, CultureInfo.InvariantCulture, out var values))
            {
                result = values;
                return true;
            }

            result = default;
            return false;
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
                    return left * right;
                case '/':
                    {
                        if (right == 0)
                        {
                            throw new ApplicationException("Деление на 0 невозможно");
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
