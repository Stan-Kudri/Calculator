using Calculator.WPF.Extension;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Windows;
using System.Windows.Input;

namespace Calculator.Domain.ViewModel
{
    public partial class MainWindowViewModel : ObservableObject
    {
        public const string Zero = "0";
        public const char Comma = ',';

        public const char PlusOperator = '+';
        public const char MinusOperator = '-';
        public const char DivisionOperator = '/';
        public const char MultiplicationOperator = '*';

        private MathCalculator _calculator = new MathCalculator();
        private string _numberInput = string.Empty;

        private bool _isPlusNumberSign = true;

        [ObservableProperty] private string _numberOutput = string.Empty;


        public string NumberInput
        {
            get => _numberInput;
            set
            {
                if (value.TryIsMatchStr())
                {
                    SetProperty(ref _numberInput, value);
                }
            }
        }

        [RelayCommand]
        private void OnPreviewTextInput(object parameter)
        {
            if (parameter is TextCompositionEventArgs e)
            {
                // Разрешаем цифры, точку, запятую и минус
                string newStr = NumberInput + e.Text;
                e.Handled = !newStr.TryIsMatchStr();
            }
        }

        [RelayCommand]
        private void ClearEntry()
        {
            NumberOutput = string.Empty;
            NumberInput = string.Empty;
            _calculator = new MathCalculator();
        }

        [RelayCommand]
        private void Cancel()
        {
            var length = NumberInput.Length;

            if (length != 0)
            {
                NumberInput = NumberInput.Remove(length - 1);
            }
        }

        [RelayCommand]
        private void NumberSign()
        {
            NumberInput = _isPlusNumberSign ? "-" + NumberInput : NumberInput.Replace("-", "");
            _isPlusNumberSign = !_isPlusNumberSign;
        }

        [RelayCommand]
        private void EqualSign()
        {
            if (CheckUsedOperation())
            {
                try
                {
                    var (left, right) = GetValuesToCount();
                    var valueTxtBox = _calculator.Eval(right, left);

                    NumberOutput = valueTxtBox.ToString();
                }
                catch (ApplicationException ex)
                {
                    NumberOutput = string.Empty;
                    MessageBox.Show(ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
                finally
                {
                    NumberInput = string.Empty;
                }
            }
        }

        [RelayCommand]
        private void AddZeroNumber() => AddNumber(0);

        [RelayCommand]
        private void AddOneNumber() => AddNumber(1);

        [RelayCommand]
        private void AddTwoNumber() => AddNumber(2);

        [RelayCommand]
        private void AddThreeNumber() => AddNumber(3);

        [RelayCommand]
        private void AddFourNumber() => AddNumber(4);

        [RelayCommand]
        private void AddFiveNumber() => AddNumber(5);

        [RelayCommand]
        private void AddSixNumber() => AddNumber(6);

        [RelayCommand]
        private void AddSevenNumber() => AddNumber(7);

        [RelayCommand]
        private void AddEightNumber() => AddNumber(8);

        [RelayCommand]
        private void AddNinetNumber() => AddNumber(9);


        private void AddNumber(int number) => NumberInput = NumberInput + number;

        [RelayCommand]
        private void PlusOperation() => ArithmeticOperation(PlusOperator);

        [RelayCommand]
        private void MinusOperation() => ArithmeticOperation(MinusOperator);

        [RelayCommand]
        private void DivisionOperation() => ArithmeticOperation(DivisionOperator);

        [RelayCommand]
        private void MultiplicationOperation() => ArithmeticOperation(MultiplicationOperator);

        private void ArithmeticOperation(char operation)
        {
            if (CheckUsedOperation())
            {
                try
                {
                    var (left, right) = GetValuesToCount();
                    var valueTxtBox = _calculator.Eval(right, left, operation);

                    NumberOutput = valueTxtBox.ToString();
                }
                catch (ApplicationException ex)
                {
                    NumberOutput = string.Empty;
                    MessageBox.Show(ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
                finally
                {
                    NumberInput = string.Empty;
                }
            }
        }

        private (string left, string right) GetValuesToCount() => (NumberInput, NumberOutput);

        private bool CheckUsedOperation() => NumberInput.Length != 0 || NumberOutput.Length != 0;
    }
}
