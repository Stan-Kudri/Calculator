using System.Globalization;

namespace Calculator.Domain
{
    public class MathCalculator
    {
        private readonly static char[] Operation = new char[] { '+', '-', '*', '/', '=' };
        private char _pastOperation = '=';
        private decimal _valueResult;
        private decimal _valueOperand;

        public decimal ArithmeticOperation(string x, string y, char operation)
        {
            if (!Operation.Contains(operation))
                throw new ArgumentException("Неверная арифметическая операция");

            if (decimal.TryParse(x, NumberStyles.Any, CultureInfo.InvariantCulture, out var firstValue))
                _valueResult = firstValue;

            if (decimal.TryParse(y, NumberStyles.Any, CultureInfo.InvariantCulture, out var value))
            {
                if (x.Length == 0)
                {
                    _valueResult = value;
                }
                else
                {
                    if (operation == '=')
                    {
                        _pastOperation = operation;
                    }
                    _valueResult = Eval(_valueResult, value, _pastOperation);
                }
            }
            else if (x.Length == 0)
            {
                throw new ArgumentException("Неправильная числовая строка");
            }

            _pastOperation = operation;
            return _valueResult;
        }

        public decimal GetNumericResult(string x, string y)
        {
            if (decimal.TryParse(x, NumberStyles.Any, CultureInfo.InvariantCulture, out var firstValue))
                _valueResult = firstValue;

            if (decimal.TryParse(y, NumberStyles.Any, CultureInfo.InvariantCulture, out var value))
            {
                if (_pastOperation == '=')
                {
                    return value;
                }
                else
                {
                    _valueOperand = value;
                    return Eval(_valueResult, value, _pastOperation);
                }
            }
            else if (y.Length == 0)
            {
                if (_valueOperand == 0)
                    _valueOperand = _valueResult;
                return Eval(_valueResult, _valueOperand, _pastOperation);
            }
            else if (x.Length == 0)
            {
                throw new ArgumentException("Неправильная числовая строка");
            }

            return _valueResult;
        }

        private static decimal Eval(decimal a, decimal b, char operation)
        {
            switch (operation)
            {
                case '+':
                    return a + b;
                case '-':
                    return a - b;
                case '*':
                    {
                        return a == 0 ? b : a * b;
                    }
                case '/':
                    {
                        if (b == 0)
                        {
                            throw new ArgumentException("Деление на 0 невозможно");
                        }
                        return a / b;
                    }
                case '=':
                    {
                        if (a == 0 || b == 0)
                        {
                            return 0;
                        }
                        return b;
                    }
            }
            throw new OperationCanceledException("Неизвестный оператор");
        }
    }
}
