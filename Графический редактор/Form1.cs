using System.Drawing;
using System.Windows.Forms;

namespace Графический_редактор
{
    public partial class Form1 : Form
    {
        private bool isMouse = false;
        string mode = "brush";
        int prevX, prevY, nowX, nowY;
        private class ArrayPoints
        {
            private int index = 0;
            private Point[] points;

            public ArrayPoints(int size)
            {
                if (size <= 0) size = 2;
                points = new Point[size];
            }

            public void SetPoint(int x, int y)
            {
                if (index >= points.Length) index = 0;
                points[index] = new Point(x, y);
                index++;
            }

            public void ResetPoints() => index = 0;

            public int GetCountPoints() => index;

            public Point[] GetPoints() => points;
        }
        private ArrayPoints arrayPoints = new ArrayPoints(2);
        Bitmap map = new Bitmap(100, 100);
        Graphics graphics;
        Pen pen = new Pen(Color.Black, 3f);
        private void SetSize()
        {
            Rectangle rectangle = Screen.PrimaryScreen.Bounds;
            map = new Bitmap(rectangle.Width, rectangle.Height);
            graphics = Graphics.FromImage(map);
            graphics.Clear(Color.White);
            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
        }
        private void validate(Bitmap bmp, Stack<Point> sp, int x, int y, Color oldColor, Color newColor)
        {
            Color backColor = bmp.GetPixel(x, y);
            if (backColor == oldColor)
            {
                sp.Push(new Point(x, y));
                bmp.SetPixel(x, y, newColor);
            }
        }
        public void Fill(Bitmap bitmap, int x, int y, Color newColor)
        {
            Color oldColor = bitmap.GetPixel(x, y);
            Stack<Point> pixel = new Stack<Point>();
            pixel.Push(new Point(x, y));
            bitmap.SetPixel(x, y, newColor);
            if (oldColor == newColor) return;

            while (pixel.Count > 0)
            {
                Point point = (Point)pixel.Pop();
                if (point.X > 0 && point.Y > 0 && point.X < bitmap.Width - 1 && point.Y < bitmap.Height - 1)
                {
                    validate(bitmap, pixel, point.X - 1, point.Y, oldColor, newColor);
                    validate(bitmap, pixel, point.X, point.Y - 1, oldColor, newColor);
                    validate(bitmap, pixel, point.X + 1, point.Y, oldColor, newColor);
                    validate(bitmap, pixel, point.X, point.Y + 1, oldColor, newColor);
                }
            }
        }
        private Point set_point(PictureBox pictureBox, Point point)
        {
            float pX = 1f;
            float pY = 1f;
            return new Point((int)(point.X * pX), (int)(point.Y * pY));
        }
        public Form1()
        {
            InitializeComponent();
            SetSize();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictBox_Move(object sender, EventArgs e)
        {

        }

        private void pictBox_MouseDown(object sender, MouseEventArgs e)
        {
            isMouse = true;
            arrayPoints.ResetPoints();
            prevX = e.X;
            prevY = e.Y;

        }

        private void pictBox_MouseUp(object sender, MouseEventArgs e)
        {
            isMouse = false;
            arrayPoints.ResetPoints();
            if (mode == "rectangle")
            {
                if (prevX > e.X && prevY > e.Y)
                {
                    graphics.DrawRectangle(pen, e.X, e.Y, prevX - e.X, prevY - e.Y);
                }
                if (prevX < e.X && prevY > e.Y)
                {
                    graphics.DrawRectangle(pen, prevX, e.Y, e.X - prevX, prevY - e.Y);
                }
                if (prevX > e.X && prevY < e.Y)
                {
                    graphics.DrawRectangle(pen, e.X, prevY, prevX - e.X, e.Y - prevY);
                }
                else
                {
                    graphics.DrawRectangle(pen, prevX, prevY, e.X - prevX, e.Y - prevY);
                }
                pictBox.Image = map;
            }
            if (mode == "ellipse")
            {
                if (prevX > e.X && prevY > e.Y)
                {
                    graphics.DrawEllipse(pen, e.X, e.Y, prevX - e.X, prevY - e.Y);
                }
                if (prevX < e.X && prevY > e.Y)
                {
                    graphics.DrawEllipse(pen, prevX, e.Y, e.X - prevX, prevY - e.Y);
                }
                if (prevX > e.X && prevY < e.Y)
                {
                    graphics.DrawEllipse(pen, e.X, prevY, prevX - e.X, e.Y - prevY);
                }
                else
                {
                    graphics.DrawEllipse(pen, prevX, prevY, e.X - prevX, e.Y - prevY);
                }
                pictBox.Image = map;

            }
            if (mode == "line")
            {
                graphics.DrawLine(pen, prevX, prevY, e.X, e.Y);
                pictBox.Image = map;
            }
        }

        private void pictBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (mode != "brush") pictBox.Cursor = Cursors.Cross;
            nowX = e.X; nowY = e.Y;
            if (!isMouse) return;
            arrayPoints.SetPoint(e.X, e.Y);
            pen.Width = penWidthBar.Value;
            if (mode == "brush")
            {
                if (arrayPoints.GetCountPoints() >= 2)
                {
                    graphics.DrawLines(pen, arrayPoints.GetPoints());
                    pictBox.Image = map;
                    arrayPoints.SetPoint(e.X, e.Y);
                }
            }
            pictBox.Refresh();

        }

        private void bRed_Click(object sender, EventArgs e)
        {
            pen.Color = ((Button)sender).BackColor;
            bUserColor.BackColor = pen.Color;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                pen.Color = colorDialog.Color;
                bUserColor.BackColor = colorDialog.Color;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            pen.Color = pictBox.BackColor;
        }

        private void цветФонаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Все содержмое рисунка будет стёрто. Вы хотите продолжить?", "Цвет фона", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    pictBox.BackColor = colorDialog.Color;
                    graphics.Clear(colorDialog.Color);
                    pictBox.Refresh();
                }
            }
        }

        private void pictBox_Click(object sender, EventArgs e)
        {
            pen.Width = penWidthBar.Value;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            mode = "rectangle";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            mode = "brush";
        }

        private void bEllipse_Click(object sender, EventArgs e)
        {
            mode = "ellipse";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bLine_Click(object sender, EventArgs e)
        {
            mode = "line";
        }

        private void bFill_Click(object sender, EventArgs e)
        {
            mode = "fill";
        }

        private void pictBox_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            if (isMouse)
            {
                if (mode == "rectangle")
                {
                    if (prevX > nowX && prevY > nowY)
                    {
                        g.DrawRectangle(pen, nowX, nowY, prevX - nowX, prevY - nowY);
                    }
                    if (prevX < nowX && prevY > nowY)
                    {
                        g.DrawRectangle(pen, prevX, nowY, nowX - prevX, prevY - nowY);
                    }
                    if (prevX > nowX && prevY < nowY)
                    {
                        g.DrawRectangle(pen, nowX, prevY, prevX - nowX, nowY - prevY);
                    }
                    else
                    {
                        g.DrawRectangle(pen, prevX, prevY, nowX - prevX, nowY - prevY);
                    }
                }
                if (mode == "ellipse")
                {
                    if (prevX > nowX && prevY > nowY)
                    {
                        g.DrawEllipse(pen, nowX, nowY, prevX - nowX, prevY - nowY);
                    }
                    if (prevX < nowX && prevY > nowY)
                    {
                        g.DrawEllipse(pen, prevX, nowY, nowX - prevX, prevY - nowY);
                    }
                    if (prevX > nowX && prevY < nowY)
                    {
                        g.DrawEllipse(pen, nowX, prevY, prevX - nowX, nowY - prevY);
                    }
                    else
                    {
                        g.DrawEllipse(pen, prevX, prevY, nowX - prevX, nowY - prevY);
                    }
                }
                if (mode == "line")
                {
                    g.DrawLine(pen, prevX, prevY, nowX, nowY);
                }
            }
        }

        private void pictBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (mode == "fill")
            {
                Point point = set_point(pictBox, e.Location);
                Fill(map, point.X, point.Y, pen.Color);
                mode = "brush";
                pictBox.Refresh();
            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {

            saveFD.DefaultExt = ".jpg";
            if (saveFD.ShowDialog() == DialogResult.OK)
            {
                pictBox.Image.Save(saveFD.FileName);
                MessageBox.Show("Рисунок успешно сохранён.", "Сохранение");
                toolStripStatusLabel1.Text = saveFD.FileName;
            }
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFD.ShowDialog() == DialogResult.OK)
            {
                Image image = Image.FromFile(openFD.FileName);
                int imWidth = image.Width;
                int imHeight = image.Height;
                map = new Bitmap(image, pictBox.Width, pictBox.Height);
                graphics = Graphics.FromImage(map);
                pictBox.Image = map;
                image.Dispose();
                toolStripStatusLabel1.Text = openFD.FileName;
            }
        }

        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (toolStripStatusLabel1.Text == "безымянный")
            {
                if (MessageBox.Show("Вы хотите сохранить файл?", "Сохранение", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    сохранитьToolStripMenuItem_Click(sender, e);
            }
            this.Close();
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Выполнил студент 2231122 группы Шнайдер Артур", "Справка");
        }
    }
}
