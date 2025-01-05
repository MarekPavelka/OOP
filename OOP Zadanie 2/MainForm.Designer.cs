using Newtonsoft.Json;
using OOP_Zadanie_2.Models;
using System.Text.Json;

namespace OOP_Zadanie_2
{
    public partial class MainForm : Form
    {
        private System.ComponentModel.IContainer components = null; //  required designer variable
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
            SuspendLayout();
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1412, 710);
            Margin = new Padding(3, 2, 3, 2);
            Name = "MainForm";
            Text = "MainForm";
            ResumeLayout(false);
        }

        private void SetupUI()
        {
            var menuStrip = new MenuStrip();
            
            var fileMenu = new ToolStripMenuItem("File");
            var saveMenuItem = new ToolStripMenuItem("Save");
            var loadMenuItem = new ToolStripMenuItem("Load");
            saveMenuItem.Click += SaveDrawing;
            loadMenuItem.Click += LoadDrawing;
            fileMenu.DropDownItems.Add(saveMenuItem);
            fileMenu.DropDownItems.Add(loadMenuItem);
            menuStrip.Items.Add(fileMenu);
            
            var clearMenu = new ToolStripMenuItem("Clear");
            var clearAllMenuItem = new ToolStripMenuItem("All lines");
            var clearLasMenuItem = new ToolStripMenuItem("Last line");
            clearAllMenuItem.Click += ClearAllLines;
            clearLasMenuItem.Click += ClearLastLine;
            clearMenu.DropDownItems.Add(clearAllMenuItem);
            clearMenu.DropDownItems.Add(clearLasMenuItem);
            menuStrip.Items.Add(clearMenu);

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
            if (_currentLine == null)
            {
                return;
            }

            using var pen = new Pen(_currentLine.Color);
            e.Graphics.DrawLine(pen, _currentLine.Start, _currentLine.End);
        }

        private void ResetCurrentLine()
        {
            _currentLine = null;
            _startPoint = null;
        }

        private void ClearAllLines(object sender, EventArgs e)
        {
        }

        private void ClearLastLine(object sender, EventArgs e)
        {
        }

        private void SaveDrawing(object sender, EventArgs e)
        {
            using var saveFileDialog = new SaveFileDialog { Filter = "JSON Files (*.json)|*.json" };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                var json = JsonConvert.SerializeObject(_lines);
                File.WriteAllText(saveFileDialog.FileName, json);
            }

            _lines.Clear();
            RefreshWindow();
        }

        private void LoadDrawing(object sender, EventArgs e)
        {
            using var openFileDialog = new OpenFileDialog { Filter = "JSON Files (*.json)|*.json" };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var json = File.ReadAllText(openFileDialog.FileName);
                _lines = JsonConvert.DeserializeObject<List<Line>>(json);
            }

            RefreshWindow();
        }

        private void RefreshWindow()
        {
            Invalidate();
        }
    }
}
