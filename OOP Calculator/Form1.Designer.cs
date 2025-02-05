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
        buttonNum1 = new Button();
        buttonNum2 = new Button();
        buttonNum3 = new Button();
        buttonNum4 = new Button();
        buttonNum5 = new Button();
        buttonNum6 = new Button();
        buttonNum7 = new Button();
        buttonNum8 = new Button();
        buttonNum9 = new Button();
        buttonNum0 = new Button();
        buttonToggleSign = new Button();
        buttonDot = new Button();
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
        // buttonNum1
        // 
        buttonNum1.BackColor = SystemColors.ControlDark;
        buttonNum1.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
        buttonNum1.Location = new Point(16, 331);
        buttonNum1.Margin = new Padding(4, 5, 4, 5);
        buttonNum1.Name = "buttonNum1";
        buttonNum1.Size = new Size(87, 80);
        buttonNum1.TabIndex = 0;
        buttonNum1.Text = "1";
        buttonNum1.UseVisualStyleBackColor = false;
        buttonNum1.Click += ButtonNum1_Click;
        // 
        // buttonNum2
        // 
        buttonNum2.BackColor = SystemColors.ControlDark;
        buttonNum2.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
        buttonNum2.Location = new Point(111, 331);
        buttonNum2.Margin = new Padding(4, 5, 4, 5);
        buttonNum2.Name = "buttonNum2";
        buttonNum2.Size = new Size(87, 80);
        buttonNum2.TabIndex = 2;
        buttonNum2.Text = "2";
        buttonNum2.UseVisualStyleBackColor = false;
        buttonNum2.Click += ButtonNum2_Click;
        // 
        // buttonNum3
        // 
        buttonNum3.BackColor = SystemColors.ControlDark;
        buttonNum3.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
        buttonNum3.Location = new Point(207, 332);
        buttonNum3.Margin = new Padding(4, 5, 4, 5);
        buttonNum3.Name = "buttonNum3";
        buttonNum3.Size = new Size(87, 80);
        buttonNum3.TabIndex = 3;
        buttonNum3.Text = "3";
        buttonNum3.UseVisualStyleBackColor = false;
        buttonNum3.Click += ButtonNum3_Click;
        // 
        // buttonNum4
        // 
        buttonNum4.BackColor = SystemColors.ControlDark;
        buttonNum4.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
        buttonNum4.Location = new Point(16, 242);
        buttonNum4.Margin = new Padding(4, 5, 4, 5);
        buttonNum4.Name = "buttonNum4";
        buttonNum4.Size = new Size(87, 80);
        buttonNum4.TabIndex = 4;
        buttonNum4.Text = "4";
        buttonNum4.UseVisualStyleBackColor = false;
        buttonNum4.Click += ButtonNum4_Click;
        // 
        // buttonNum5
        // 
        buttonNum5.BackColor = SystemColors.ControlDark;
        buttonNum5.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
        buttonNum5.Location = new Point(111, 242);
        buttonNum5.Margin = new Padding(4, 5, 4, 5);
        buttonNum5.Name = "buttonNum5";
        buttonNum5.Size = new Size(87, 80);
        buttonNum5.TabIndex = 5;
        buttonNum5.Text = "5";
        buttonNum5.UseVisualStyleBackColor = false;
        buttonNum5.Click += ButtonNum5_Click;
        // 
        // buttonNum6
        // 
        buttonNum6.BackColor = SystemColors.ControlDark;
        buttonNum6.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
        buttonNum6.Location = new Point(205, 242);
        buttonNum6.Margin = new Padding(4, 5, 4, 5);
        buttonNum6.Name = "buttonNum6";
        buttonNum6.Size = new Size(87, 80);
        buttonNum6.TabIndex = 6;
        buttonNum6.Text = "6";
        buttonNum6.UseVisualStyleBackColor = false;
        buttonNum6.Click += ButtonNum6_Click;
        // 
        // buttonNum7
        // 
        buttonNum7.BackColor = SystemColors.ControlDark;
        buttonNum7.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
        buttonNum7.Location = new Point(16, 152);
        buttonNum7.Margin = new Padding(4, 5, 4, 5);
        buttonNum7.Name = "buttonNum7";
        buttonNum7.Size = new Size(87, 80);
        buttonNum7.TabIndex = 7;
        buttonNum7.Text = "7";
        buttonNum7.UseVisualStyleBackColor = false;
        buttonNum7.Click += ButtonNum7_Click;
        // 
        // buttonNum8
        // 
        buttonNum8.BackColor = SystemColors.ControlDark;
        buttonNum8.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
        buttonNum8.Location = new Point(110, 152);
        buttonNum8.Margin = new Padding(4, 5, 4, 5);
        buttonNum8.Name = "buttonNum8";
        buttonNum8.Size = new Size(87, 80);
        buttonNum8.TabIndex = 8;
        buttonNum8.Text = "8";
        buttonNum8.UseVisualStyleBackColor = false;
        buttonNum8.Click += ButtonNum8_Click;
        // 
        // buttonNum9
        // 
        buttonNum9.BackColor = SystemColors.ControlDark;
        buttonNum9.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
        buttonNum9.Location = new Point(205, 152);
        buttonNum9.Margin = new Padding(4, 5, 4, 5);
        buttonNum9.Name = "buttonNum9";
        buttonNum9.Size = new Size(87, 80);
        buttonNum9.TabIndex = 9;
        buttonNum9.Text = "9";
        buttonNum9.UseVisualStyleBackColor = false;
        buttonNum9.Click += ButtonNum9_Click;
        // 
        // buttonNum0
        // 
        buttonNum0.BackColor = SystemColors.ControlDark;
        buttonNum0.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
        buttonNum0.Location = new Point(111, 421);
        buttonNum0.Margin = new Padding(4, 5, 4, 5);
        buttonNum0.Name = "buttonNum0";
        buttonNum0.Size = new Size(87, 80);
        buttonNum0.TabIndex = 10;
        buttonNum0.Text = "0";
        buttonNum0.UseVisualStyleBackColor = false;
        buttonNum0.Click += ButtonNum0_Click;
        // 
        // buttonToggleSign
        // 
        buttonToggleSign.BackColor = SystemColors.ControlDark;
        buttonToggleSign.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
        buttonToggleSign.Location = new Point(16, 421);
        buttonToggleSign.Margin = new Padding(4, 5, 4, 5);
        buttonToggleSign.Name = "buttonToggleSign";
        buttonToggleSign.Size = new Size(87, 80);
        buttonToggleSign.TabIndex = 11;
        buttonToggleSign.Text = "+/-";
        buttonToggleSign.UseVisualStyleBackColor = false;
        buttonToggleSign.Click += ButtonToggleSign_Click;
        // 
        // buttonDot
        // 
        buttonDot.BackColor = SystemColors.ControlDark;
        buttonDot.Font = new Font("Consolas", 14.25F);
        buttonDot.Location = new Point(207, 421);
        buttonDot.Margin = new Padding(4, 5, 4, 5);
        buttonDot.Name = "buttonDot";
        buttonDot.Size = new Size(87, 80);
        buttonDot.TabIndex = 12;
        buttonDot.Text = ".";
        buttonDot.UseVisualStyleBackColor = false;
        buttonDot.Click += ButtonDot_Click;
        // 
        // buttonAdd
        // 
        buttonAdd.BackColor = SystemColors.ControlDarkDark;
        buttonAdd.Font = new Font("Consolas", 14.25F);
        buttonAdd.Location = new Point(300, 422);
        buttonAdd.Margin = new Padding(4, 5, 4, 5);
        buttonAdd.Name = "buttonAdd";
        buttonAdd.Size = new Size(87, 80);
        buttonAdd.TabIndex = 13;
        buttonAdd.Text = "+";
        buttonAdd.UseVisualStyleBackColor = false;
        buttonAdd.Click += ButtonAdd_Click;
        // 
        // buttonSubtract
        // 
        buttonSubtract.BackColor = SystemColors.ControlDarkDark;
        buttonSubtract.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        buttonSubtract.Location = new Point(300, 332);
        buttonSubtract.Margin = new Padding(4, 5, 4, 5);
        buttonSubtract.Name = "buttonSubtract";
        buttonSubtract.Size = new Size(87, 80);
        buttonSubtract.TabIndex = 14;
        buttonSubtract.Text = "-";
        buttonSubtract.UseVisualStyleBackColor = false;
        buttonSubtract.Click += ButtonSubtract_Click;
        // 
        // buttonMultiply
        // 
        buttonMultiply.BackColor = SystemColors.ControlDarkDark;
        buttonMultiply.Font = new Font("Consolas", 14.25F);
        buttonMultiply.Location = new Point(300, 242);
        buttonMultiply.Margin = new Padding(4, 5, 4, 5);
        buttonMultiply.Name = "buttonMultiply";
        buttonMultiply.Size = new Size(87, 80);
        buttonMultiply.TabIndex = 12;
        buttonMultiply.Text = "x";
        buttonMultiply.UseVisualStyleBackColor = false;
        buttonMultiply.Click += ButtonMultiply_Click;
        // 
        // buttonDivide
        // 
        buttonDivide.BackColor = SystemColors.ControlDarkDark;
        buttonDivide.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        buttonDivide.Location = new Point(302, 152);
        buttonDivide.Margin = new Padding(4, 5, 4, 5);
        buttonDivide.Name = "buttonDivide";
        buttonDivide.Size = new Size(85, 80);
        buttonDivide.TabIndex = 15;
        buttonDivide.Text = "÷";
        buttonDivide.UseVisualStyleBackColor = false;
        buttonDivide.Click += ButtonDivide_Click;
        // 
        // buttonBack
        // 
        buttonBack.BackColor = SystemColors.ButtonShadow;
        buttonBack.Font = new Font("Consolas", 12.25F);
        buttonBack.Location = new Point(395, 152);
        buttonBack.Margin = new Padding(4, 5, 4, 5);
        buttonBack.Name = "buttonBack";
        buttonBack.Size = new Size(87, 80);
        buttonBack.TabIndex = 17;
        buttonBack.Text = "BACK";
        buttonBack.UseVisualStyleBackColor = false;
        buttonBack.Click += ButtonBack_Click;
        // 
        // buttonC
        // 
        buttonC.BackColor = SystemColors.ControlDark;
        buttonC.Font = new Font("Consolas", 14.25F);
        buttonC.Location = new Point(395, 242);
        buttonC.Margin = new Padding(4, 5, 4, 5);
        buttonC.Name = "buttonC";
        buttonC.Size = new Size(87, 80);
        buttonC.TabIndex = 18;
        buttonC.Text = "C";
        buttonC.UseVisualStyleBackColor = false;
        buttonC.Click += ButtonC_Click;
        // 
        // buttonResult
        // 
        buttonResult.BackColor = Color.RoyalBlue;
        buttonResult.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        buttonResult.Location = new Point(395, 331);
        buttonResult.Margin = new Padding(4, 5, 4, 5);
        buttonResult.Name = "buttonResult";
        buttonResult.Size = new Size(85, 170);
        buttonResult.TabIndex = 19;
        buttonResult.Text = "=";
        buttonResult.UseVisualStyleBackColor = false;
        buttonResult.Click += ButtonResult_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(32, 32, 32);
        ClientSize = new Size(500, 524);
        Controls.Add(textBox1);
        Controls.Add(buttonNum1);
        Controls.Add(buttonNum2);
        Controls.Add(buttonNum3);
        Controls.Add(buttonNum4);
        Controls.Add(buttonNum5);
        Controls.Add(buttonNum6);
        Controls.Add(buttonNum7);
        Controls.Add(buttonNum8);
        Controls.Add(buttonNum9);
        Controls.Add(buttonNum0);
        Controls.Add(buttonToggleSign);
        Controls.Add(buttonDot);
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
    private Button buttonNum1;
    private Button buttonNum2;
    private Button buttonNum3;
    private Button buttonNum4;
    private Button buttonNum5;
    private Button buttonNum6;
    private Button buttonNum7;
    private Button buttonNum8;
    private Button buttonNum9;
    private Button buttonNum0;
    private Button buttonToggleSign;
    private Button buttonDot;
    private Button buttonAdd;
    private Button buttonSubtract;
    private Button buttonMultiply;
    private Button buttonDivide;
    private Button buttonBack;
    private Button buttonC;
    private Button buttonResult;
}