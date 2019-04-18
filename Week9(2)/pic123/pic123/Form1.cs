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
        System.Timers.Timer timer = new System.Timers.Timer(2000);
        System.Timers.Timer timer2 = new System.Timers.Timer(2000);
        Star s1 = new Star(120, 200);
        Star s2 = new Star(400, 300);

        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.Black;

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
       
            SolidBrush blue = new SolidBrush(Color.Blue);
            e.Graphics.FillRectangle(blue, 10, 10, 760, 520);

            CircleStar star1 = new CircleStar(40, 60, e);
            CircleStar star2 = new CircleStar(60, 300, e);
            CircleStar star3 = new CircleStar(250, 40, e);
            CircleStar star4 = new CircleStar(230, 270, e);
            CircleStar star5 = new CircleStar(410, 80, e);
            CircleStar star6 = new CircleStar(530, 200, e);
            CircleStar star7 = new CircleStar(600, 120, e);
            CircleStar star8 = new CircleStar(600, 300, e);

            int y = 200, x = 300;
            Point[] spaceship =
            {
                new Point(x,y),
                new Point(x+40,y+20),
                new Point(x+40,y+50),
                new Point(x,y+70),
                new Point(x-40,y+50),
                 new Point(x-40,y+20)
            };
            SolidBrush yellow = new SolidBrush(Color.Yellow);
            e.Graphics.FillPolygon(yellow, spaceship);

          
            
            x = 360;
            y = 180;
            Point[] newstar =
            {
                    new Point(x,y),
                    new Point(x+5,y+25),
                    new Point(x+20,y+30),
                    new Point(x+5,y+35),
                    new Point(x,y+60),

                    new Point(x-5,y+35),
                    new Point(x-20,y+30),
                    new Point(x-5,y+25),

            };
            e.Graphics.FillClosedCurve(yellow, newstar);

            SolidBrush red = new SolidBrush(Color.Red);

            e.Graphics.FillPath(red, s1.gp1);
            e.Graphics.FillPath(red, s1.gp2);
            e.Graphics.FillPath(red, s2.gp1);
            e.Graphics.FillPath(red, s2.gp2);

            timer.Elapsed += Timer_Elapsed;
            timer.Start();
            timer2.Elapsed += Timer2_Elapsed;
            timer2.Start();
          


        }

        private void Timer_Elapsed(object sender, EventArgs e)
        {
           
            s1.Clear();
            s1.Move(5);
            
           s1.Draw();
            Invalidate();
            
        }


        private void Timer2_Elapsed(object sender, EventArgs e)
        {
            s2.Clear();
            s2.Move(-5);
           
            s2.Draw();
           
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 800;
            this.Height = 600;
        }
    }
}
