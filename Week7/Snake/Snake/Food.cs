using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Snake
{
    class Food : GameObject
    {
        public Food(char sign) : base(sign)
        {
            
        }

        public void Generate(List <Point> worm1, List <Point> wall1)
        {
            body.Clear();
            Random random = new Random(DateTime.Now.Second);
            Point p = new Point
            {
                X = random.Next(0, 39),
                Y = random.Next(0, 30)
            };

             while ((BadPoint(p,worm1)==true) || (BadPoint(p,wall1)==true))
            {
                 p = new Point
                {
                    X = random.Next(0, 39),
                    Y = random.Next(0, 30)
                };
               
            }
            body.Add(p);

        }

        private bool BadPoint(Point p, List<Point> otherBody)
        {
            if (CheckIntersection(p,otherBody) == true)
                return true;
            else
                return false;
        }

        private bool CheckIntersection(Point p, List<Point> otherBody)
        {
            bool res = false;

            foreach (Point point in otherBody)
            {
                if (point.X == p.X &&
                    point.Y == p.Y)
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
