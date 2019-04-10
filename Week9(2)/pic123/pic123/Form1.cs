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

namespace pic123
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.Blue;

        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {

            GraphicsPath path = new GraphicsPath();
            GraphicsPath path2 = new GraphicsPath();
            Point[] point =
            {
                new Point(40, 60),
                new Point(20, 90),
                new Point(60, 90)
            };
            Point[] point2 =
          {
                new Point(40, 100),
                new Point(20, 70),
                new Point(60, 70)
            };


            SolidBrush solidBrush = new SolidBrush(Color.FromArgb(255, 250, 200, 0));

            e.Graphics.FillEllipse(solidBrush, 30, 30, 20, 20);
            e.Graphics.FillEllipse(solidBrush, 100, 150, 20, 20);
            e.Graphics.FillEllipse(solidBrush, 160, 40, 20, 20);
            e.Graphics.FillEllipse(solidBrush, 300, 190, 20, 20);
            e.Graphics.FillEllipse(solidBrush, 500, 200, 20, 20);
            e.Graphics.FillEllipse(solidBrush, 400, 20, 20, 20);
            e.Graphics.FillEllipse(solidBrush, 470, 60, 20, 20);

            path.StartFigure();
            path.AddLine(50, 20, 5, 90);
            path.AddLine(50, 150, 150, 180);
            path.CloseFigure();
            e.Graphics.DrawPath(new Pen(Color.FromArgb(255, 255, 0, 0), 2), path);

            path2.StartFigure();
            path2.AddPolygon(point);
            path2.AddPolygon(point2);
            path2.CloseFigure();
            e.Graphics.DrawPath(new Pen(Color.FromArgb(255, 255, 0, 0), 2), path2);

        }

    }

}
