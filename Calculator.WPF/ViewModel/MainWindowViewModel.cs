using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Text.RegularExpressions;
using System.Windows.Input;

namespace Calculator.Domain.ViewModel
{
    public partial class MainWindowViewModel : ObservableObject
    {
        public const string Zero = "0";

        private string _numberInput;
        private MathCalculator _calculator = new MathCalculator();

        public string NumberInput
        {
            get => _numberInput;
            set
            {
                if (IsTextAllowed(value))
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
                Regex regex = new Regex(@"^-?\d*[,.]?\d*$");
                string newText = NumberInput + e.Text;
                e.Handled = !regex.IsMatch(newText);
            }
        }

        // Проверка, что текст содержит только допустимые символы
        private bool IsTextAllowed(string text)
        {
            Regex regex = new Regex(@"^-?\d*[,.]?\d*$");
            return regex.IsMatch(text);
        }
    }
}
