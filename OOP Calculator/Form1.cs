using OOP_Calculator.Extensions;

namespace OOP_Calculator
{
    public partial class Form1 : Form
    {
        string input = string.Empty;
        string decimalPart = string.Empty;
        string firstOperand = string.Empty;
        string secondOperand = string.Empty;
        string tempResult = string.Empty;
        string? operation;
        double result = 0.0;

        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonNum1_Click(object sender, EventArgs e)
        {
            if (input.IsFloat())
            {
                HandleFloatInput("1");
                return;
            }

            ClearText();
            input += "1";
            CreateText();
        }

        private void ButtonNum2_Click(object sender, EventArgs e)
        {
            if (input.IsFloat())
            {
                HandleFloatInput("2");
                return;
            }

            ClearText();
            input += "2";
            CreateText();
        }

        private void ButtonNum3_Click(object sender, EventArgs e)
        {
            if (input.IsFloat())
            {
                HandleFloatInput("3");
                return;
            }

            ClearText();
            input += "3";
            CreateText();
        }

        private void ButtonNum4_Click(object sender, EventArgs e)
        {
            if (input.IsFloat())
            {
                HandleFloatInput("4");
                return;
            }

            ClearText();
            input += "4";
            CreateText();
        }

        private void ButtonNum5_Click(object sender, EventArgs e)
        {
            if (input.IsFloat())
            {
                HandleFloatInput("5");
                return;
            }

            ClearText();
            input += "5";
            CreateText();
        }

        private void ButtonNum6_Click(object sender, EventArgs e)
        {
            if (input.IsFloat())
            {
                HandleFloatInput("6");
                return;
            }

            ClearText();
            input += "6";
            CreateText();
        }

        private void ButtonNum7_Click(object sender, EventArgs e)
        {
            if (input.IsFloat())
            {
                HandleFloatInput("7");
                return;
            }

            ClearText();
            input += "7";
            CreateText();
        }

        private void ButtonNum8_Click(object sender, EventArgs e)
        {
            if (input.IsFloat())
            {
                HandleFloatInput("8");
                return;
            }

            ClearText();
            input += "8";
            CreateText();
        }

        private void ButtonNum9_Click(object sender, EventArgs e)
        {
            if (input.IsFloat())
            {
                HandleFloatInput("9");
                return;
            }

            ClearText();
            input += "9";
            CreateText();
        }

        private void ButtonNum0_Click(object sender, EventArgs e)
        {
            if (input.IsFloat())
            {
                HandleFloatInput("0");
                return;
            }

            ClearText();
            input += "0";
            CreateText();
        }

        private void ButtonToggleSign_Click(object sender, EventArgs e)
        {
            if (!input.HasValue())
            {
                return;
            }

            string oldInput;
            if (input.IsFloat())
            {
                if (decimalPart.HasValue())
                {
                    var parts = input.Split('.');
                    parts[^1] = decimalPart;
                    oldInput = string.Join('.', parts);
                }
                else
                {
                    oldInput = input;
                }
            }
            else
            {
                oldInput = input;
            }

            if (double.Parse(oldInput) == 0.0)
            {
                return;
            }

            var newInput = (Convert.ToDouble(oldInput) * -1.0).ToString();
            if (newInput.IsFloat())
            {
                var parts = newInput.Split('.');
                input = $"{parts.First()}.";
            }
            else
            {
                input = newInput;
            }

            if (operation.HasValue())
            {
                var parts = textBox1.Text.Split(operation);
                parts[^1] = parts[^1].Replace(oldInput, newInput);
                textBox1.Text = string.Join(operation, parts);
            }
            else
            {
                textBox1.Text = newInput;
            }
        }

        private void ButtonDot_Click(object sender, EventArgs e)
        {
            if (input.Contains('.'))
            {
                return;
            }

            input += ".";
            textBox1.Text += ".";
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            if (ShouldCalculateResult())
            {
                ButtonResult_Click(new { }, new EventArgs());
                return;
            }

            if (IsSameOperation("+"))
            {
                return;
            }

            if (input.IsFloat())
            {
                UpdateInputWithDecimalPart(ref input);
            }

            SetOperation("+");
        }

        private void ButtonSubtract_Click(object sender, EventArgs e)
        {
            if (ShouldCalculateResult())
            {
                ButtonResult_Click(new { }, new EventArgs());
                return;
            }

            if (IsSameOperation("-"))
            {
                return;
            }

            if (input.IsFloat())
            {
                UpdateInputWithDecimalPart(ref input);
            }

            SetOperation("-");
        }

        private void ButtonMultiply_Click(object sender, EventArgs e)
        {
            if (ShouldCalculateResult())
            {
                ButtonResult_Click(new { }, new EventArgs());
                return;
            }

            if (IsSameOperation("x"))
            {
                return;
            }

            if (input.IsFloat())
            {
                UpdateInputWithDecimalPart(ref input);
            }

            SetOperation("x");
        }

        private void ButtonDivide_Click(object sender, EventArgs e)
        {
            if (ShouldCalculateResult())
            {
                ButtonResult_Click(new { }, new EventArgs());
            }

            if (IsSameOperation("÷"))
            {
                return;
            }

            if (input.IsFloat())
            {
                UpdateInputWithDecimalPart(ref input);
            }

            SetOperation("÷");
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            var hasOperation = operation.HasValue() && firstOperand.HasValue();
            if (hasOperation)
            {
                if (input.HasValue())
                {
                    Reset(ref input);
                }
                else
                {
                    Reset(ref operation);
                    input = firstOperand;
                    Reset(ref firstOperand);
                }
            }
            else
            {
                Reset(ref input);
            }

            ClearText();
            CreateText();
        }

        private void ButtonC_Click(object sender, EventArgs e)
        {
            Reset(ref input);
            Reset(ref tempResult);
            Reset(ref decimalPart);
            Reset(ref firstOperand);
            Reset(ref secondOperand);
            Reset(ref operation);
            textBox1.Text = "";
        }

        private void ButtonResult_Click(object sender, EventArgs e)
        {
            if (!input.HasValue() || !operation.HasValue())
            {
                return;
            }

            if (input.IsFloat())
            {
                UpdateInputWithDecimalPart(ref input);
            }

            secondOperand = input;
            double.TryParse(firstOperand, out var num1);
            double.TryParse(secondOperand, out var num2);
            string result;

            switch (operation)
            {
                case "+":
                    result = HandleAddition(num1, num2);
                    break;
                case "-":
                    result = HandleSubtraction(num1, num2);
                    break;
                case "x":
                    result = HandleMultiplication(num1, num2);
                    break;
                case "÷":
                    if (!TryHandleDivision(num1, num2, out var divisionResult))
                    {
                        textBox1.Text = divisionResult.ToString();
                        return;
                    }
                    result = divisionResult;
                    break;
                default:
                    return;
            }

            SaveResultAndCleanup(result);
        }

        private string HandleAddition(double num1, double num2)
        {
            result = num1 + num2;
            return result.ToString();
        }

        private string HandleSubtraction(double num1, double num2)
        {
            result = num1 - num2;
            return result.ToString();
        }

        private string HandleMultiplication(double num1, double num2)
        {
            result = num1 * num2;
            return result.ToString();
        }

        private bool TryHandleDivision(double num1, double num2, out string divisionResult)
        {
            divisionResult = string.Empty;

            if (num2 == 0)
            {
                divisionResult = "ERROR DIV BY ZERO";
                return false;
            }

            divisionResult = (num1 / num2).ToString();
            return true;
        }

        private void Reset(ref string valueToReset)
        {
            if (!valueToReset.HasValue())
            {
                return;
            }

            valueToReset = string.Empty;
        }

        private void ClearText()
        {
            textBox1.Text = string.Empty;
        }

        private void CreateText()
        {
            textBox1.Text = $"{firstOperand}{operation}{input}";
        }

        private void RemoveLastChar(ref string value)
        {
            value = value.Remove(value.Length - 1);
        }

        private void HandleFloatInput(string numInput)
        {
            decimalPart += numInput;
            textBox1.Text += numInput;
        }

        private bool ShouldCalculateResult()
        {
            return firstOperand.HasValue() && operation.HasValue() && input.HasValue();
        }

        private bool IsSameOperation(string newOperation)
        {
            return operation == newOperation;
        }

        private void UpdateInputWithDecimalPart(ref string input)
        {

            if (decimalPart.HasValue())
            {
                input += decimalPart;
            }
            else
            {
                RemoveLastChar(ref input);
                var text = textBox1.Text;
                textBox1.Text = textBox1.Text.RemoveLastChar();
            }
        }

        private void SetOperation(string newOperation)
        {
            if (operation.HasValue())
            {
                UpdateOperation(newOperation);
                return;
            }

            AddOperation(newOperation);
        }

        private void UpdateOperation(string newOperation)
        {
            operation = newOperation;
            textBox1.Text = textBox1.Text.RemoveLastChar();
            textBox1.Text += newOperation;

            return;
        }

        private void AddOperation(string newOperation)
        {
            operation = newOperation;
            firstOperand = input;
            Reset(ref input);
            Reset(ref decimalPart);
            textBox1.Text += operation;
        }

        private void SaveResultAndCleanup(string result)
        {
            tempResult = result.ToString();
            if (tempResult.IsFloat())
            {
                var parts = tempResult.Split('.');
                input = $"{parts.First()}.";
                decimalPart = parts.Last();
                ResetOperandsAndOperation();
            }
            else
            {
                input = tempResult;
                Reset(ref decimalPart);
            }

            textBox1.Text = tempResult;
            ResetOperandsAndOperation();
        }

        private void ResetOperandsAndOperation()
        {
            Reset(ref firstOperand);
            Reset(ref secondOperand);
            Reset(ref operation);
        }
    }
}
