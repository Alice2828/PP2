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
       
            Graphics g;
            int x;
            int y;
            SolidBrush brush = new SolidBrush(Color.White);

            public CircleStar(int x, int y, PaintEventArgs e)
            {
                this.x = x;
                this.y = y;
                g = e.Graphics;
                g.FillEllipse(brush, x, y, 20, 20);
            }
        }
}
