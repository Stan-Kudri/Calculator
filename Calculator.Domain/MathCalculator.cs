using System.Globalization;

namespace Calculator.Domain
{
    public class MathCalculator
    {
        public const int DecimalPlace = 6;
        public const char EqualTo = '=';

        private readonly static HashSet<char> Operation = new() { '+', '-', 'х', '/', '=' };

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
            return Round(_valueResult);
        }

        public decimal Eval(string outputValue, string inputValueOperand)
        {
            if (TryParseValue(outputValue, out var firstValue))
            {
                _valueResult = firstValue;
            }

            if (TryParseValue(inputValueOperand, out var secondValue))
            {
                _valueOperand = secondValue;

                if (Operation.Contains(_pastOperation))
                {

                    _valueResult = Calculate(_valueResult, secondValue, _pastOperation);
                }
            }
            else if (string.IsNullOrEmpty(inputValueOperand))
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

            return Round(_valueResult);
        }

        private bool TryParseValue(string txt, out decimal result)
            => decimal.TryParse(txt, NumberStyles.AllowDecimalPoint | NumberStyles.AllowLeadingSign, CultureInfo.InvariantCulture, out result);

        private static decimal Calculate(decimal left, decimal right, char operation)
        {
            return operation switch
            {
                '+' => left + right,
                '-' => left - right,
                'х' => left * right,
                '/' => right != 0 ? left / right : throw new ApplicationException("Деление на 0 невозможно"),
                '=' => (left == 0 && right == 0) ? 0 : right,
                _ => throw new OperationCanceledException("Неизвестный оператор")
            };
        }

        private static decimal Round(decimal value) => Math.Round(value, DecimalPlace);
    }
}
