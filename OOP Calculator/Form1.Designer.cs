namespace OOP_Calculator;

public partial class Form1 : Form
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);                
    }

    protected void InitializeComponent()
    {
        textBox1 = new TextBox();
        button1 = new Button();
        button2 = new Button();
        button3 = new Button();
        button4 = new Button();
        button5 = new Button();
        button6 = new Button();
        button7 = new Button();
        button8 = new Button();
        button9 = new Button();
        button10 = new Button();
        buttonToggleSign = new Button();
        buttonFloat = new Button();
        buttonAdd = new Button();
        buttonSubtract = new Button();
        buttonMultiply = new Button();
        buttonDivide = new Button();
        buttonBack = new Button();
        buttonC = new Button();
        buttonResult = new Button();
        SuspendLayout();
        // 
        // textBox1
        // 
        textBox1.Font = new Font("Consolas", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        textBox1.Location = new Point(16, 29);
        textBox1.Margin = new Padding(4, 5, 4, 5);
        textBox1.Multiline = true;
        textBox1.Name = "textBox1";
        textBox1.Size = new Size(463, 93);
        textBox1.TabIndex = 1;
        // 
        // button1
        // 
        button1.BackColor = SystemColors.ControlDark;
        button1.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
        button1.Location = new Point(16, 331);
        button1.Margin = new Padding(4, 5, 4, 5);
        button1.Name = "button1";
        button1.Size = new Size(87, 80);
        button1.TabIndex = 0;
        button1.Text = "1";
        button1.UseVisualStyleBackColor = false;
        // 
        // button2
        // 
        button2.BackColor = SystemColors.ControlDark;
        button2.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
        button2.Location = new Point(111, 331);
        button2.Margin = new Padding(4, 5, 4, 5);
        button2.Name = "button2";
        button2.Size = new Size(87, 80);
        button2.TabIndex = 2;
        button2.Text = "2";
        button2.UseVisualStyleBackColor = false;
        // 
        // button3
        // 
        button3.BackColor = SystemColors.ControlDark;
        button3.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
        button3.Location = new Point(207, 332);
        button3.Margin = new Padding(4, 5, 4, 5);
        button3.Name = "button3";
        button3.Size = new Size(87, 80);
        button3.TabIndex = 3;
        button3.Text = "3";
        button3.UseVisualStyleBackColor = false;
        // 
        // button4
        // 
        button4.BackColor = SystemColors.ControlDark;
        button4.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
        button4.Location = new Point(16, 242);
        button4.Margin = new Padding(4, 5, 4, 5);
        button4.Name = "button4";
        button4.Size = new Size(87, 80);
        button4.TabIndex = 4;
        button4.Text = "4";
        button4.UseVisualStyleBackColor = false;
        // 
        // button5
        // 
        button5.BackColor = SystemColors.ControlDark;
        button5.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
        button5.Location = new Point(111, 242);
        button5.Margin = new Padding(4, 5, 4, 5);
        button5.Name = "button5";
        button5.Size = new Size(87, 80);
        button5.TabIndex = 5;
        button5.Text = "5";
        button5.UseVisualStyleBackColor = false;
        // 
        // button6
        // 
        button6.BackColor = SystemColors.ControlDark;
        button6.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
        button6.Location = new Point(205, 242);
        button6.Margin = new Padding(4, 5, 4, 5);
        button6.Name = "button6";
        button6.Size = new Size(87, 80);
        button6.TabIndex = 6;
        button6.Text = "6";
        button6.UseVisualStyleBackColor = false;
        // 
        // button7
        // 
        button7.BackColor = SystemColors.ControlDark;
        button7.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
        button7.Location = new Point(16, 152);
        button7.Margin = new Padding(4, 5, 4, 5);
        button7.Name = "button7";
        button7.Size = new Size(87, 80);
        button7.TabIndex = 7;
        button7.Text = "7";
        button7.UseVisualStyleBackColor = false;
        // 
        // button8
        // 
        button8.BackColor = SystemColors.ControlDark;
        button8.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
        button8.Location = new Point(110, 152);
        button8.Margin = new Padding(4, 5, 4, 5);
        button8.Name = "button8";
        button8.Size = new Size(87, 80);
        button8.TabIndex = 8;
        button8.Text = "8";
        button8.UseVisualStyleBackColor = false;
        // 
        // button9
        // 
        button9.BackColor = SystemColors.ControlDark;
        button9.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
        button9.Location = new Point(205, 152);
        button9.Margin = new Padding(4, 5, 4, 5);
        button9.Name = "button9";
        button9.Size = new Size(87, 80);
        button9.TabIndex = 9;
        button9.Text = "9";
        button9.UseVisualStyleBackColor = false;
        // 
        // button10
        // 
        button10.BackColor = SystemColors.ControlDark;
        button10.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
        button10.Location = new Point(111, 421);
        button10.Margin = new Padding(4, 5, 4, 5);
        button10.Name = "button10";
        button10.Size = new Size(87, 80);
        button10.TabIndex = 10;
        button10.Text = "0";
        button10.UseVisualStyleBackColor = false;
        // 
        // button11
        // 
        buttonToggleSign.BackColor = SystemColors.ControlDark;
        buttonToggleSign.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
        buttonToggleSign.Location = new Point(16, 421);
        buttonToggleSign.Margin = new Padding(4, 5, 4, 5);
        buttonToggleSign.Name = "button11";
        buttonToggleSign.Size = new Size(87, 80);
        buttonToggleSign.TabIndex = 11;
        buttonToggleSign.Text = "+/-";
        buttonToggleSign.UseVisualStyleBackColor = false;
        // 
        // buttonFloat
        // 
        buttonFloat.BackColor = SystemColors.ControlDark;
        buttonFloat.Font = new Font("Consolas", 14.25F);
        buttonFloat.Location = new Point(207, 421);
        buttonFloat.Margin = new Padding(4, 5, 4, 5);
        buttonFloat.Name = "button12";
        buttonFloat.Size = new Size(87, 80);
        buttonFloat.TabIndex = 12;
        buttonFloat.Text = ".";
        buttonFloat.UseVisualStyleBackColor = false;
        // 
        // buttonAdd
        // 
        buttonAdd.BackColor = SystemColors.ControlDarkDark;
        buttonAdd.Font = new Font("Consolas", 14.25F);
        buttonAdd.Location = new Point(300, 152);
        buttonAdd.Margin = new Padding(4, 5, 4, 5);
        buttonAdd.Name = "button13";
        buttonAdd.Size = new Size(87, 80);
        buttonAdd.TabIndex = 13;
        buttonAdd.Text = "+";
        buttonAdd.UseVisualStyleBackColor = false;
        // 
        // buttonSubtract
        // 
        buttonSubtract.BackColor = SystemColors.ControlDarkDark;
        buttonSubtract.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        buttonSubtract.Location = new Point(300, 332);
        buttonSubtract.Margin = new Padding(4, 5, 4, 5);
        buttonSubtract.Name = "button14";
        buttonSubtract.Size = new Size(87, 80);
        buttonSubtract.TabIndex = 14;
        buttonSubtract.Text = "-";
        buttonSubtract.UseVisualStyleBackColor = false;
        // 
        // buttonMultiply
        // 
        buttonMultiply.BackColor = SystemColors.ControlDarkDark;
        buttonMultiply.Font = new Font("Consolas", 14.25F);
        buttonMultiply.Location = new Point(300, 242);
        buttonMultiply.Margin = new Padding(4, 5, 4, 5);
        buttonMultiply.Name = "button15";
        buttonMultiply.Size = new Size(87, 80);
        buttonMultiply.TabIndex = 12;
        buttonMultiply.Text = "x";
        buttonMultiply.UseVisualStyleBackColor = false;                
        // 
        // buttonDivide
        // 
        buttonDivide.BackColor = SystemColors.ControlDarkDark;
        buttonDivide.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        buttonDivide.Location = new Point(302, 422);
        buttonDivide.Margin = new Padding(4, 5, 4, 5);
        buttonDivide.Name = "button16";
        buttonDivide.Size = new Size(85, 80);
        buttonDivide.TabIndex = 15;
        buttonDivide.Text = "÷";
        buttonDivide.UseVisualStyleBackColor = false;
        // 
        // buttonBack
        // 
        buttonBack.BackColor = SystemColors.ButtonShadow;
        buttonBack.Font = new Font("Consolas", 12.25F);
        buttonBack.Location = new Point(395, 152);
        buttonBack.Margin = new Padding(4, 5, 4, 5);
        buttonBack.Name = "button17";
        buttonBack.Size = new Size(87, 80);
        buttonBack.TabIndex = 17;
        buttonBack.Text = "BACK";
        buttonBack.UseVisualStyleBackColor = false;
        // 
        // buttonC
        // 
        buttonC.BackColor = SystemColors.ControlDark;
        buttonC.Font = new Font("Consolas", 14.25F);
        buttonC.Location = new Point(395, 242);
        buttonC.Margin = new Padding(4, 5, 4, 5);
        buttonC.Name = "button18";
        buttonC.Size = new Size(87, 80);
        buttonC.TabIndex = 18;
        buttonC.Text = "C";
        buttonC.UseVisualStyleBackColor = false;
        // 
        // buttonResult
        // 
        buttonResult.BackColor = Color.RoyalBlue;
        buttonResult.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        buttonResult.Location = new Point(395, 335);
        buttonResult.Margin = new Padding(4, 5, 4, 5);
        buttonResult.Name = "button19";
        buttonResult.Size = new Size(85, 166);
        buttonResult.TabIndex = 19;
        buttonResult.Text = "=";
        buttonResult.UseVisualStyleBackColor = false;
        
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(32, 32, 32);
        ClientSize = new Size(500, 524);
        Controls.Add(textBox1);
        Controls.Add(button1);
        Controls.Add(button2);
        Controls.Add(button3);
        Controls.Add(button4);
        Controls.Add(button5);
        Controls.Add(button6);
        Controls.Add(button7);
        Controls.Add(button8);
        Controls.Add(button9);
        Controls.Add(button10);
        Controls.Add(buttonToggleSign);
        Controls.Add(buttonFloat);
        Controls.Add(buttonAdd);
        Controls.Add(buttonSubtract);
        Controls.Add(buttonMultiply);
        Controls.Add(buttonDivide);
        Controls.Add(buttonBack);
        Controls.Add(buttonC);
        Controls.Add(buttonResult);
        Margin = new Padding(4, 5, 4, 5);
        Name = "Form1";
        Text = "Calculator";
        ResumeLayout(false);
        PerformLayout();
    }

    private TextBox textBox1;
    private Button button1;
    private Button button2;
    private Button button3;
    private Button button4;
    private Button button5;
    private Button button6;
    private Button button7;
    private Button button8;
    private Button button9;
    private Button button10;
    private Button buttonToggleSign;
    private Button buttonFloat;
    private Button buttonAdd;
    private Button buttonSubtract;
    private Button buttonMultiply;
    private Button buttonDivide;
    private Button buttonBack;
    private Button buttonC;
    private Button buttonResult;
}