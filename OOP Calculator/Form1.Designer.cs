
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
        EnableResizing();
        SizeChanged += Form1_SizeChanged;

        mainLayout = new TableLayoutPanel();
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
        textBox1.ReadOnly = true;
        textBox1.TabStop = false;
        // 
        // buttonNum1
        // 
        buttonNum1.BackColor = SystemColors.ControlDark;
        buttonNum1.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
        buttonNum1.Location = new Point(16, 331);
        buttonNum1.Margin = new Padding(4, 5, 4, 5);
        buttonNum1.Name = "buttonNum1";
        buttonNum1.Size = new Size(87, 80);
        buttonNum1.Text = "1";
        buttonNum1.UseVisualStyleBackColor = false;
        buttonNum1.Dock = DockStyle.Fill;
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
        buttonNum2.Text = "2";
        buttonNum2.UseVisualStyleBackColor = false;
        buttonNum2.Dock = DockStyle.Fill;
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
        buttonNum3.Text = "3";
        buttonNum3.UseVisualStyleBackColor = false;
        buttonNum3.Dock = DockStyle.Fill;
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
        buttonNum4.Text = "4";
        buttonNum4.UseVisualStyleBackColor = false;
        buttonNum4.Dock = DockStyle.Fill;
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
        buttonNum5.Text = "5";
        buttonNum5.UseVisualStyleBackColor = false;
        buttonNum5.Dock = DockStyle.Fill;
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
        buttonNum6.Text = "6";
        buttonNum6.UseVisualStyleBackColor = false;
        buttonNum6.Dock = DockStyle.Fill;
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
        buttonNum7.Text = "7";
        buttonNum7.UseVisualStyleBackColor = false;
        buttonNum7.Dock = DockStyle.Fill;
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
        buttonNum8.Text = "8";
        buttonNum8.UseVisualStyleBackColor = false;
        buttonNum8.Dock = DockStyle.Fill;
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
        buttonNum9.Text = "9";
        buttonNum9.UseVisualStyleBackColor = false;
        buttonNum9.Dock = DockStyle.Fill;
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
        buttonNum0.Text = "0";
        buttonNum0.UseVisualStyleBackColor = false;
        buttonNum0.Dock = DockStyle.Fill;
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
        buttonToggleSign.Text = "+/-";
        buttonToggleSign.UseVisualStyleBackColor = false;
        buttonToggleSign.Dock = DockStyle.Fill;
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
        buttonDot.Text = ".";
        buttonDot.UseVisualStyleBackColor = false;
        buttonDot.Dock = DockStyle.Fill;
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
        buttonAdd.Text = "+";
        buttonAdd.UseVisualStyleBackColor = false;
        buttonAdd.Dock = DockStyle.Fill;
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
        buttonSubtract.Text = "-";
        buttonSubtract.UseVisualStyleBackColor = false;
        buttonSubtract.Dock = DockStyle.Fill;
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
        buttonMultiply.Text = "x";
        buttonMultiply.UseVisualStyleBackColor = false;
        buttonMultiply.Dock = DockStyle.Fill;
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
        buttonDivide.Text = "÷";
        buttonDivide.UseVisualStyleBackColor = false;
        buttonDivide.Dock = DockStyle.Fill;
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
        buttonBack.Text = "BACK";
        buttonBack.UseVisualStyleBackColor = false;
        buttonBack.Dock = DockStyle.Fill;
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
        buttonC.Text = "C";
        buttonC.UseVisualStyleBackColor = false;
        buttonC.Dock = DockStyle.Fill;
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
        buttonResult.Text = "=";
        buttonResult.UseVisualStyleBackColor = false;
        buttonResult.Dock = DockStyle.Fill;
        buttonResult.Click += ButtonResult_Click;
        //
        // mainLayout
        //        
        mainLayout.Dock = DockStyle.Fill;
        mainLayout.RowCount = 5; // 1 row for textbox, 4 rows for buttons
        mainLayout.ColumnCount = 5;
        mainLayout.Padding = new Padding(5);
        SetProportionalResize(mainLayout);
        AddElementsToLayout(mainLayout);
        UpdateButtonFonts();
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(32, 32, 32);
        ClientSize = new Size(500, 600);
        Margin = new Padding(4, 5, 4, 5);
        Name = "Form1";
        Text = "Calculator";

        Controls.Add(mainLayout);

        ResumeLayout(false);
        PerformLayout();
    }

    private void EnableResizing()
    {
        this.FormBorderStyle = FormBorderStyle.Sizable;
        this.MaximizeBox = true;
        this.MinimumSize = new Size(300, 400);
    }

    private void SetProportionalResize(TableLayoutPanel layout)
    {
        PreventDuplicateStyles();

        layout.RowStyles.Add(new RowStyle(SizeType.Percent, 20F)); // 20% for textbox

        for (int i = 1; i < layout.RowCount; i++)
        {
            layout.RowStyles.Add(new RowStyle(SizeType.Percent, 20F)); // 4 x 20% for buttons
        }

        for (int i = 0; i < layout.ColumnCount; i++)
        {
            layout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
        }

        #region local
        void PreventDuplicateStyles()
        {
            layout.ColumnStyles.Clear();
            layout.RowStyles.Clear();
        }
        #endregion
    }


    private void AddElementsToLayout(TableLayoutPanel layout)
    {
        layout.Controls.Add(textBox1, column: 0, row: 0);
        layout.SetColumnSpan(textBox1, 5);
        textBox1.Dock = DockStyle.Fill;

        var buttons = GetOrderedButtons();
        int buttonIndex = 0;

        for (int rowIndex = 1; rowIndex < layout.RowCount; rowIndex++)
        {
            for (int colIndex = 0; colIndex < layout.ColumnCount; colIndex++)
            {
                if (rowIndex == 3 && colIndex == 4)
                {
                    continue; // leave empty space for "=" button
                }

                if (buttonIndex < buttons.Count)
                {
                    layout.Controls.Add(buttons[buttonIndex], colIndex, rowIndex);
                    buttonIndex++;
                }
            }
        }

        layout.Controls.Add(buttons[18], 4, 3);
        mainLayout.SetRowSpan(buttons[18], 2); // span "=" button
        SetTabIndexes(buttons);
    }

    private List<Button> GetOrderedButtons()
    {
        return new List<Button>
        {
            buttonNum7, buttonNum8, buttonNum9, buttonDivide, buttonBack,
            buttonNum4, buttonNum5, buttonNum6, buttonMultiply, buttonC,
            buttonNum1, buttonNum2, buttonNum3, buttonSubtract,            
            buttonToggleSign, buttonNum0, buttonDot, buttonAdd, buttonResult
        };
    }

    private void SetTabIndexes(List<Button> buttons)
    {
        for (int i = 0; i < buttons.Count; i++)
        {
            buttons[i].TabIndex = i;
        }
    }

    private TableLayoutPanel mainLayout;
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