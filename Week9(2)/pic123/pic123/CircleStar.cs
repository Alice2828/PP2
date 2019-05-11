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
    class CircleStar
    {

        int x, y;
       
        SolidBrush yellow = new SolidBrush(Color.White);

            public CircleStar(int x, int y, PaintEventArgs e)
            {
            this.x = x;
            this.y = y;
          
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
        }
        }
}
