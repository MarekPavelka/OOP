using OOP_Zadanie_2.Models;

namespace OOP_Zadanie_2
{
    public partial class MainForm : Form
    {
        private System.ComponentModel.IContainer components = null; //  required designer variable.
        private Color _currentColor = Color.Red;
        private Point? _startPoint = null;
        private List<Line> _lines = new List<Line>();
        private Line _currentLine;

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            DrawAllLines(e);
            DrawCurrentLine(e);
        }

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

            var redButton = new Button { Text = "Red", BackColor = Color.Red, ForeColor = Color.White, Location = new Point(10, 30) };
            var greenButton = new Button { Text = "Green", BackColor = Color.Green, ForeColor = Color.White, Location = new Point(90, 30) };
            var blueButton = new Button { Text = "Blue", BackColor = Color.Blue, ForeColor = Color.White, Location = new Point(170, 30) };

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
            if (e.Button != MouseButtons.Left)
            {
                return;
            }

            _startPoint = e.Location;
            _currentLine = new Line { Start = _startPoint.Value, Color = _currentColor };
        }

        private void FormMouseMove(object sender, MouseEventArgs e)
        {
            if (_startPoint == null)
            {
                return;
            }

            _currentLine.End = e.Location;
            RefreshWindow();
        }

        private void FormMouseUp(object sender, MouseEventArgs e)
        {
            if (_startPoint == null)
            {
                return;
            }

            _lines.Add(_currentLine);
            ResetCurrentLine();
            RefreshWindow();
        }

        private void DrawAllLines(PaintEventArgs e)
        {
            foreach (var line in _lines)
            {
                using var pen = new Pen(line.Color);
                e.Graphics.DrawLine(pen, line.Start, line.End);
            }
        }

        private void DrawCurrentLine(PaintEventArgs e)
        {
            if (_currentLine != null)
            {
                using var pen = new Pen(_currentLine.Color);
                e.Graphics.DrawLine(pen, _currentLine.Start, _currentLine.End);
            }
        }

        private void ResetCurrentLine()
        {
            _currentLine = null;
            _startPoint = null;
        }

        private void RefreshWindow()
        {
            Invalidate();
        }
    }
}
