using OOP_Zadanie_2.Models;

namespace OOP_Zadanie_2
{
    public partial class MainForm : Form
    {        
        private System.ComponentModel.IContainer components = null; //  Required designer variable.
        private Color _currentColor = Color.Black;
        private Point? _startPoint = null;
        private List<Line> _lines = new List<Line>();

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "MainForm";
        }

        private void SetupUI()
        {
            var menuStrip = new MenuStrip();
            var fileMenu = new ToolStripMenuItem("File");
            var saveMenuItem = new ToolStripMenuItem("Save");
            var loadMenuItem = new ToolStripMenuItem("Load");

            fileMenu.DropDownItems.Add(saveMenuItem);
            fileMenu.DropDownItems.Add(loadMenuItem);
            menuStrip.Items.Add(fileMenu);
            Controls.Add(menuStrip);

            var redButton = new Button { Text = "Red", BackColor = Color.Red, Location = new Point(10, 30) };
            var greenButton = new Button { Text = "Green", BackColor = Color.Green, Location = new Point(90, 30) };
            var blueButton = new Button { Text = "Blue", BackColor = Color.Blue, Location = new Point(170, 30) };

            redButton.Click += (s, e) => _currentColor = Color.Red;
            greenButton.Click += (s, e) => _currentColor = Color.Green;
            blueButton.Click += (s, e) => _currentColor = Color.Blue;

            Controls.Add(redButton);
            Controls.Add(greenButton);
            Controls.Add(blueButton);

            this.DoubleBuffered = true;
        }
    }
}
