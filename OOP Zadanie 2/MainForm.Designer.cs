using OOP_Zadanie_2.Models;

namespace OOP_Zadanie_2
{
    public partial class MainForm : Form
    {
        private System.ComponentModel.IContainer components = null; //  required designer variable.
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
            var menu = new ToolStripMenuItem("File");
            var saveMenuItem = new ToolStripMenuItem("Save");
            var loadMenuItem = new ToolStripMenuItem("Load");

            menu.DropDownItems.Add(saveMenuItem);
            menu.DropDownItems.Add(loadMenuItem);
            menuStrip.Items.Add(menu);
            Controls.Add(menuStrip);

            var redButton = new Button { Text = "Red", BackColor = Color.Red, Location = new Point(10, 30) };
            var greenButton = new Button { Text = "Green", BackColor = Color.Green, Location = new Point(90, 30) };
            var blueButton = new Button { Text = "Blue", BackColor = Color.Blue, Location = new Point(170, 30) };

            redButton.Click += (sender, e) => _currentColor = Color.Red;
            greenButton.Click += (sender, e) => _currentColor = Color.Green;
            blueButton.Click += (sender, e) => _currentColor = Color.Blue;

            Controls.Add(redButton);
            Controls.Add(greenButton);
            Controls.Add(blueButton);

            this.MouseDown += FormMouseDown;
            this.MouseMove += FormMouseMove;
            this.MouseUp += FormMouseUp;

            this.DoubleBuffered = true; // visual performance improvement for drawing
        }

        private void FormMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _startPoint = e.Location;
            }
        }

        private void FormMouseMove(object sender, MouseEventArgs e)
        {
            if (_startPoint == null)
            {
                return;
            }

            Invalidate(); // refresh window
            using (var graphics = CreateGraphics())
            {
                graphics.DrawLine(new Pen(_currentColor), _startPoint.Value, e.Location);
            }
        }

        private void FormMouseUp(object sender, MouseEventArgs e)
        {
            if (_startPoint == null)
            {
                return;
            }

            _lines.Add(new Line
            {
                Start = _startPoint.Value,
                End = e.Location,
                Color = _currentColor
            });
            _startPoint = null;
            Invalidate(); // refresh window
        }
    }
}
