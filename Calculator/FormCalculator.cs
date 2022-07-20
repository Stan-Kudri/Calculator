using Calculator.Domain;
using ApplicationException = Calculator.Domain.ApplicationException;

namespace Calculator
{
    public partial class FormCalculator : Form
    {
        private bool _numberSign = true;
        private MathCalculator _calculator;

        public FormCalculator()
        {
            InitializeComponent();
            _calculator = new MathCalculator();
        }

        private void btnNumber_Click(object sender, EventArgs e)
        {
            if (txtScoreboard.Text == "0")
                txtScoreboard.Text = string.Empty;
            txtScoreboard.Text = txtScoreboard.Text + ((Button)sender).Text;
        }

        private void btnDecimalPoint_Click(object sender, EventArgs e)
        {
            if (!txtScoreboard.Text.Contains(','))
                txtScoreboard.Text = txtScoreboard.Text + ',';
        }

        private void btnCleanEntry_Click(object sender, EventArgs e)
        {
            txtScoreboard.Text = string.Empty;
            txtBoxValue.Text = string.Empty;
            _calculator = new MathCalculator();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            var lenght = txtScoreboard.Text.Length;
            if (lenght != 0)
                txtScoreboard.Text = txtScoreboard.Text.Remove(lenght - 1);
        }

        private void btnNumberSign_Click(object sender, EventArgs e)
        {
            txtScoreboard.Text = _numberSign ? "-" + txtScoreboard.Text : txtScoreboard.Text.Replace("-", ""); _numberSign = !_numberSign;
        }

        private void btnArithmeticOperation_Click(object sender, EventArgs e)
        {
            if (CheckUsedOperation())
            {
                try
                {
                    var (textFromInput, textFromOutput) = GetValuesToCount();
                    var operation = char.Parse(((Button)sender).Text);

                    var valueTxtBox = _calculator.Eval(textFromOutput, textFromInput, operation);

                    txtBoxValue.Text = valueTxtBox.ToString();
                }
                catch (ApplicationException ex)
                {
                    txtBoxValue.Text = string.Empty;
                    MessageBox.Show(ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    Close();
                }
                finally
                {
                    txtScoreboard.Text = string.Empty;
                }
            }
        }

        private void btnEqualSign_Click(object sender, EventArgs e)
        {
            if (CheckUsedOperation())
            {
                try
                {
                    var (textFromInput, textFromOutput) = GetValuesToCount();

                    var valueTxtBox = _calculator.Eval(textFromOutput, textFromInput);

                    txtBoxValue.Text = valueTxtBox.ToString();
                }
                catch (ApplicationException ex)
                {
                    txtBoxValue.Text = string.Empty;
                    MessageBox.Show(ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    Close();
                }
                finally
                {
                    txtScoreboard.Text = string.Empty;
                }
            }
        }

        private void txtScoreboard_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
            if (txtScoreboard.Text.Contains(',') && e.KeyChar != ',')
            {
                e.Handled = true;
            }
        }

        private (string left, string right) GetValuesToCount() => (txtScoreboard.Text, txtBoxValue.Text);

        private bool CheckUsedOperation() => txtBoxValue.Text.Length != 0 || txtScoreboard.Text.Length != 0;
    }
}