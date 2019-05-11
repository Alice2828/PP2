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
        int x=30;
        int y=600;
   

        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.Black;



        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
       
            SolidBrush blue = new SolidBrush(Color.Blue);
            e.Graphics.FillRectangle(blue, 10, 10, 760, 300);
            SolidBrush green = new SolidBrush(Color.Green);
            e.Graphics.FillRectangle(green, 10, 320, 760, 300);
          

            CircleStar star1 = new CircleStar(40, 60, e);
            CircleStar star2 = new CircleStar(560, 200, e);
            CircleStar star3 = new CircleStar(250, 40, e);
            CircleStar star4 = new CircleStar(300, 240, e);
            CircleStar star5 = new CircleStar(410, 80, e);

            SolidBrush yellow = new SolidBrush(Color.Yellow);
            e.Graphics.FillEllipse(yellow, 40, 150, 100, 100);
            e.Graphics.FillEllipse(blue,70, 160, 70, 70);




            SolidBrush red = new SolidBrush(Color.Red);
            Pen pen = new Pen(Color.Red);
            e.Graphics.FillEllipse(red, x,310,30,30);
            e.Graphics.DrawLine(pen , x+15, 320, x+15, 400);
            e.Graphics.DrawLine(pen, x + 15, 400, x + 30, 450);
            e.Graphics.DrawLine(pen, x + 15, 400, x - 15, 450);

          
            e.Graphics.FillEllipse(red, y, 310, 30, 30);
            e.Graphics.DrawLine(pen, y + 15, 320, y + 15, 400);
            e.Graphics.DrawLine(pen, y + 15, 400, y + 30, 450);
            e.Graphics.DrawLine(pen, y + 15, 400, y - 15, 450);

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            
                x += 40;
                if (x == 780) x = 0;
            y = y - 40;
            if (y == 0) y = 780;
            Invalidate();
            
        }
       

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 800;
            this.Height = 600;
        }

        
    }
}
