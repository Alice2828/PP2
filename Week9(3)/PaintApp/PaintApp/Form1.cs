using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintApp
{
  
    enum Tool
    {
        Pencil,
        Line,
        Eraser,
        Pipette,
        Rectangle,
        Ellipse,
        Triangle,
        Star,
        Fill,
        Fill2
    }
    public partial class Form1 : Form
    {
        
        Bitmap bitmap;
        Graphics graphics;
        Point firstPoint;
        Point secondPoint;
        Pen pen = new Pen(Color.Red, 2);
        Pen eraser = new Pen(Color.White, 2);
        Tool activeTool = Tool.Pencil;
        public Form1()
        {
            InitializeComponent();
            bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            graphics = Graphics.FromImage(bitmap);
            graphics.Clear(Color.White);
            pictureBox1.Image = bitmap;
            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            eraser.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            eraser.EndCap = System.Drawing.Drawing2D.LineCap.Round;
        }
        private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            firstPoint = e.Location;

            if (activeTool == Tool.Fill)
            {
                DummyFill dummyFill = new DummyFill();
                dummyFill.Fill(bitmap, e.Location, pen.Color);
                pictureBox1.Refresh();
            }
            else if (activeTool == Tool.Fill2)
            {
                MapFill mapFill = new MapFill();
                mapFill.Fill(graphics, e.Location, pen.Color, ref bitmap);
                graphics = Graphics.FromImage(bitmap);
                pictureBox1.Image = bitmap;
            }
            else if(activeTool == Tool.Pipette)
            {
                pen.Color = bitmap.GetPixel(firstPoint.X, firstPoint.Y);
            }
        }

        private void PictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                secondPoint = e.Location;
                switch (activeTool)
                {
                    case Tool.Pencil:
                        graphics.DrawLine(pen, firstPoint, secondPoint);
                        firstPoint = secondPoint;
                        break;
                    case Tool.Eraser:
                        graphics.DrawLine(eraser, firstPoint, secondPoint);
                        firstPoint = secondPoint;
                        break;
                    case Tool.Line:
                        break;
                    case Tool.Triangle:
                        break;
                    case Tool.Rectangle:
                        break;
                    case Tool.Ellipse:
                        break;
                    case Tool.Fill:
                        break;
                    case Tool.Pipette:
                        pen.Color = bitmap.GetPixel(firstPoint.X, firstPoint.Y);
                        firstPoint = secondPoint;
                        break;
                    default:
                        break;
                }
                pictureBox1.Refresh();

            }

        }

        private void PenBtn_Click(object sender, EventArgs e)
        {
            activeTool = Tool.Pencil;
        }

        private void LineBtn_Click(object sender, EventArgs e)
        {
            activeTool = Tool.Line;
        }

        private void RecBtn_Click(object sender, EventArgs e)
        {
            activeTool = Tool.Rectangle;
        }

        private void EllipseBtn_Click(object sender, EventArgs e)
        {
            activeTool = Tool.Ellipse;
        }
        private void EraserBtn_Click(object sender, EventArgs e)
        {
            activeTool = Tool.Eraser;
        }

        private void FillBtn_Click(object sender, EventArgs e)
        {
            activeTool = Tool.Fill;
        }
        private void PipetteBtn_Click(object sender, EventArgs e)
        {
            activeTool = Tool.Pipette;
        }
        private void TriangleBtn_Click(object sender, EventArgs e)
        {
            activeTool = Tool.Triangle;
        }
        private void StarBtn_Click(object sender, EventArgs e)
        {
            activeTool = Tool.Star;
        }

        private void PictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            switch (activeTool)
            {
                case Tool.Pencil:
                    break;
                case Tool.Line:
                    secondPoint = e.Location;
                    graphics.DrawLine(pen, firstPoint, secondPoint);
                    pictureBox1.Refresh();
                    break;
                case Tool.Rectangle:
                    graphics.DrawRectangle(pen, GetRectangle(firstPoint, secondPoint));
                    break;
                case Tool.Ellipse:
                    graphics.DrawEllipse(pen, GetRectangle(firstPoint, secondPoint));
                    break;
                case Tool.Eraser:
                    break;
                case Tool.Pipette:
                    break;
                case Tool.Fill:
                    break;
                case Tool.Triangle:
                    graphics.DrawPolygon(pen, GetTriangle(firstPoint, secondPoint));
                    break;
                case Tool.Star:
                    graphics.DrawPath(pen, GetStar(firstPoint, secondPoint));
                    break;
                default:
                    break;
            }
        }

        private void PictureBox1_Paint(object sender, PaintEventArgs e)
        {
            switch (activeTool)
            {
                case Tool.Pencil:
                    break;
                case Tool.Line:
                    e.Graphics.DrawLine(pen, firstPoint, secondPoint);
                    break;
                case Tool.Rectangle:
                    e.Graphics.DrawRectangle(pen, GetRectangle(firstPoint, secondPoint));
                    break;
                case Tool.Ellipse:
                    e.Graphics.DrawEllipse(pen, GetRectangle(firstPoint, secondPoint));
                    break;
                case Tool.Triangle:
                    e.Graphics.DrawPolygon(pen, GetTriangle(firstPoint, secondPoint));
                    break;
                case Tool.Star:
                    e.Graphics.DrawPath(pen, GetStar(firstPoint, secondPoint));
                    break;
                case Tool.Fill:
                    break;
                default:
                    break;
            }
        }

        Rectangle GetRectangle(Point p1, Point p2)
        {
            Rectangle res = new Rectangle();
            res.X = Math.Min(p1.X, p2.X);
            res.Y = Math.Min(p1.Y, p2.Y);
            res.Width = Math.Abs(p1.X - p2.X);
            res.Height = Math.Abs(p1.Y - p2.Y);
            return res;
        }

        Point[] GetTriangle(Point p1, Point p2)
        {
           
            Point p3=new Point();
            Point p4 = new Point();
            Point p5 = new Point();
            if (p2.Y <= p1.Y)
            {
                p3.X = (p1.X + p2.X) / 2;
                p3.Y = p2.Y;
                p4.X = p2.X;
                p4.Y = p1.Y;
                p5.X = p1.X;
                p5.Y = p1.Y;
            }
            else
            {
                p3.X = (p1.X + p2.X) / 2;
                p3.Y = p1.Y;
                p4.X = p2.X;
                p4.Y = p2.Y;
                p5.X = p1.X;
                p5.Y = p4.Y;
            }
            Point[] pop =
          {
                p3,
                p4,
                p5
            };

            return pop;
        }

        GraphicsPath GetStar(Point m1, Point m2)
        {
            GraphicsPath path = new GraphicsPath();
            Point p1 = new Point();
            Point p2 = new Point();
            Point p3 = new Point();
            Point p4 = new Point();
            Point p5 = new Point();
            Point p6 = new Point();
            Point p7 = new Point();
            Point p8 = new Point();
            Point p9 = new Point();
            Point p10 = new Point();
            if (m2.Y <= m1.Y)
            {
                p1.X=(m2.X+5*(m1.X)) / 6;
                p1.Y = m1.Y;
                p2.X= (m2.X + 2 * (m1.X)) / 3;
                p2.Y= (2*m2.Y + 3 * (m1.Y)) / 5;
                p3.X = m1.X;
                p3.Y = (2*(m1.Y) + 3 * (m2.Y)) / 5;
                p4.X = p2.X;
                p4.Y = p3.Y;
                p5.X =(m1.X+ m2.X)/2;
                p5.Y = m2.Y;
                p6.X = (2*(m2.X) + (m1.X)) / 3;
                p6.Y = p3.Y;
                p7.X = m2.X;
                p7.Y = p3.Y;
                p8.X = p6.X;
                p8.Y = p2.Y;
                p9.X= (m2.X*5+m1.X)/6;
                p9.Y = p1.Y;
                p10.X = p5.X;
                p10.Y= (m1.Y * 4 + m2.Y) / 5;
                path=DrawThing(path,p1,p2,p3,p4,p5,p6,p7,p8,p9,p10);
                
            }
            else
            {
                p1.X = (m1.X + 5 * (m2.X)) / 6;
                p1.Y = m2.Y;
                p2.X = (m1.X + 2 * (m2.X)) / 3;
                p2.Y = (2 * m1.Y + 3 * (m2.Y)) / 5;
                p3.X = m2.X;
                p3.Y = (2 * (m2.Y) + 3 * (m1.Y)) / 5;
                p4.X = p2.X;
                p4.Y = p3.Y;
                p5.X = (m2.X + m1.X) / 2;
                p5.Y = m1.Y;
                p6.X = (2 * (m1.X) + (m2.X)) / 3;
                p6.Y = p3.Y;
                p7.X = m1.X;
                p7.Y = p3.Y;
                p8.X = p6.X;
                p8.Y = p2.Y;
                p9.X = (m1.X * 5 + m2.X) / 6;
                p9.Y = p1.Y;
                p10.X = p5.X;
                p10.Y = (m2.Y * 4 + m1.Y) / 5;
                path = DrawThing(path, p1, p2, p3, p4, p5, p6, p7, p8, p9, p10);

            }

            return path;
        }
        private GraphicsPath DrawThing(GraphicsPath path, Point p1, Point p2, Point p3, Point p4, Point p5, Point p6, Point p7, Point p8, Point p9, Point p10)
        {
            path.StartFigure();
            path.AddLine(p1.X, p1.Y, p2.X, p2.Y);
            path.AddLine(p2.X, p2.Y, p3.X, p3.Y);
            path.AddLine(p3.X, p3.Y, p4.X, p4.Y);
            path.AddLine(p4.X, p4.Y, p5.X, p5.Y);
            path.AddLine(p5.X, p5.Y, p6.X, p6.Y);
            path.AddLine(p6.X, p6.Y, p7.X, p7.Y);
            path.AddLine(p7.X, p7.Y, p8.X, p8.Y);
            path.AddLine(p8.X, p8.Y, p9.X, p9.Y);
            path.AddLine(p9.X, p9.Y, p10.X, p10.Y);
            path.AddLine(p10.X, p10.Y, p1.X, p1.Y);
            path.CloseFigure();
            return path;
        }
        private void Fill2_Click(object sender, EventArgs e)
        {
            activeTool = Tool.Fill2;
        }

        private void FromColorDialogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pen.Color = colorDialog1.Color;
            }
        }
        private void FileOpenMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialog1.FileName;
            }
        }
        private void FileSaveMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = saveFileDialog1.FileName;
            }
        }
        private void SizePlusMenuItem_Click(object sender, EventArgs e)
        {
            pen.Width++;
            eraser.Width++;
        }
        private void SizeMinusMenuItem_Click(object sender, EventArgs e)
        {
            pen.Width--;
            eraser.Width--;
        }
    }
}

