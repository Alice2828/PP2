using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Snake
{
    class Wall : GameObject
    {
        public Wall(char sign) : base(sign)
        {
            LoadLevel(1);
        }

        public void LoadLevel(int level)
        {
            
            string name = string.Format(@"C:\Users\ASUS\Desktop\PP2\Week6\Snake\Snake\Levels\Level{0}.txt", level);
           
            using (StreamReader reader = new StreamReader(name))
            {
                int r = 0;

                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    for (int c = 0; c < line.Length; ++c)
                    {
                        if (line[c] == '#')
                        {
                            body.Add(new Point { X = c, Y = r });
                        }
                    }

                    r++;
                }
            }
           
        }
        public bool CheckIntersection(List<Point> otherBody)
        {
            bool res = false;

            foreach (Point point in otherBody)
            {
                foreach (Point k in body)
                    if (point.X == k.X &&
                    point.Y == k.Y)
                {
                    res = true;
                    break;
                }

                if (res == true)
                {
                    break;
                }
            }

            return res;
        }
       

    }
}