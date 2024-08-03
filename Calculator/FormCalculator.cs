using Calculator.Domain;

namespace Calculator
{
    public partial class FormCalculator : Form
    {
        public const string Zero = "0";
        public const char Comma = ',';

        private bool _numberSign = true;
        private MathCalculator _calculator = new MathCalculator();

        public FormCalculator() => InitializeComponent();

        private void BtnNumber_Click(object sender, EventArgs e)
        {
            if (txtScoreboard.Text == Zero)
            {
                txtScoreboard.Text = string.Empty;
            }

            txtScoreboard.Text = txtScoreboard.Text + ((Button)sender).Text;
        }

        private void BtnDecimalPoint_Click(object sender, EventArgs e)
        {
            if (!txtScoreboard.Text.Contains(Comma))
            {
                txtScoreboard.Text = txtScoreboard.Text + Comma;
            }
        }

        private void BtnCleanEntry_Click(object sender, EventArgs e)
        {
            txtScoreboard.Text = string.Empty;
            txtBoxValue.Text = string.Empty;
            _calculator = new MathCalculator();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            var length = txtScoreboard.Text.Length;

            if (length != 0)
            {
                txtScoreboard.Text = txtScoreboard.Text.Remove(length - 1);
            }
        }

        private void BtnNumberSign_Click(object sender, EventArgs e)
        {
            txtScoreboard.Text = _numberSign ? "-" + txtScoreboard.Text : txtScoreboard.Text.Replace("-", "");
            _numberSign = !_numberSign;
        }

        private void BtnArithmeticOperation_Click(object sender, EventArgs e)
        {
            if (CheckUsedOperation())
            {
                try
                {
                    var (left, right) = GetValuesToCount();

                    var operation = char.Parse(((Button)sender).Text);

                    var valueTxtBox = _calculator.Eval(right, left, operation);

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

        private void BtnEqualSign_Click(object sender, EventArgs e)
        {
            if (CheckUsedOperation())
            {
                try
                {
                    var (left, right) = GetValuesToCount();

                    var valueTxtBox = _calculator.Eval(right, left);

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

        private void TxtScoreboard_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != Comma))
            {
                e.Handled = true;
            }

            if (txtScoreboard.Text.Contains(Comma) && e.KeyChar != Comma)
            {
                e.Handled = true;
            }
        }

        private (string left, string right) GetValuesToCount() => (txtScoreboard.Text, txtBoxValue.Text);

        private bool CheckUsedOperation()
            => txtBoxValue.Text.Length != 0
                || txtScoreboard.Text.Length != 0;
    }
}