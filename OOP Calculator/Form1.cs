namespace OOP_Calculator
{
    public partial class Form1 : Form
    {
        string input = string.Empty;
        string firstOperand = string.Empty;
        string secondOperand = string.Empty;
        string displayText = string.Empty;
        string? operation;
        double result = 0.0;

        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonNum1_Click(object sender, EventArgs e)
        {
            input += "1";
            textBox1.Text += input;
        }

        private void ButtonNum2_Click(object sender, EventArgs e)
        {
            input += "2";
            textBox1.Text += input;
        }

        private void ButtonNum3_Click(object sender, EventArgs e)
        {
            input += "3";
            textBox1.Text += input;
        }

        private void ButtonNum4_Click(object sender, EventArgs e)
        {
            input += "4";
            textBox1.Text += input;
        }

        private void ButtonNum5_Click(object sender, EventArgs e)
        {
            input += "5";
            textBox1.Text += input;
        }

        private void ButtonNum6_Click(object sender, EventArgs e)
        {
            input += "6";
            textBox1.Text += input;
        }

        private void ButtonNum7_Click(object sender, EventArgs e)
        {
            input += "7";
            textBox1.Text += input;
        }

        private void ButtonNum8_Click(object sender, EventArgs e)
        {
            input += "8";
            textBox1.Text += input;
        }

        private void ButtonNum9_Click(object sender, EventArgs e)
        {
            input += "9";
            textBox1.Text += input;
        }

        private void ButtonNum0_Click(object sender, EventArgs e)
        {
            input += "0";
            textBox1.Text += input;
        }

        private void ButtonToggleSign_Click(object sender, EventArgs e)
        {
            if (double.Parse(input) != 0.0)
            {
                input = (Convert.ToDouble(input) * -1.0).ToString();
            }

            // change sign of the last number in the textBox
            textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1) + input;
        }

        private void ButtonDot_Click(object sender, EventArgs e)
        {
            input += ".";
            textBox1.Text += ".";
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            firstOperand = input;
            input = string.Empty;
            operation = "+";
            textBox1.Text += operation;
        }

        private void ButtonSubtract_Click(object sender, EventArgs e)
        {
            firstOperand = input;
            input = string.Empty;
            operation = "-";
            textBox1.Text += operation;
        }

        private void ButtonMultiply_Click(object sender, EventArgs e)
        {
            firstOperand = input;
            input = string.Empty;
            operation = "*";
            textBox1.Text += operation;
        }

        private void ButtonDivide_Click(object sender, EventArgs e)
        {
            firstOperand = input;
            input = string.Empty;
            operation = "/";
            textBox1.Text += operation;
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            input = input.Remove(input.Length - 1);
            var oldText = textBox1.Text;
            textBox1.Text = oldText.Remove(oldText.Length - 1);
        }

        private void ButtonC_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            input = string.Empty;
            firstOperand = string.Empty;
            secondOperand = string.Empty;
        }

        private void ButtonResult_Click(object sender, EventArgs e)
        {
            secondOperand = input;
            double.TryParse(firstOperand, out var num1);
            double.TryParse(secondOperand, out var num2);

            switch (operation)
            {
                case "+":
                    HandleAddition(num1, num2);
                    break;
                case "-":
                    HandleSubtraction(num1, num2);
                    break;
                case "*":
                    HandleMultiplication(num1, num2);
                    break;
                case "/":
                    HandleDivision(num1, num2);
                    break;
                default:
                    break;
            }
        }        

        private void HandleAddition(double num1, double num2)
        {
            result = num1 + num2;
            textBox1.Text = result.ToString();
        }

        private void HandleSubtraction(double num1, double num2)
        {
            result = num1 - num2;
            textBox1.Text = result.ToString();
        }

        private void HandleMultiplication(double num1, double num2)
        {
            result = num1 * num2;
            textBox1.Text = result.ToString();
        }

        private void HandleDivision(double num1, double num2)
        {
            if (num2 != 0)
            {
                result = num1 / num2;
                textBox1.Text = result.ToString();
            }
            else
            {
                textBox1.Text = "ERROR DIV BY ZERO";
            }
        }
    }
}
