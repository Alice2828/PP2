using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Task2
{
   public class Mark
   {
        public string Points
        {
            get;
            set;
        }
        public string Letters
        {
            get;
            set;
        }
        public void GetLetter()
        {
           
                if (int.Parse(Points) <= 100 && int.Parse(Points) >= 95)
                {
                Letters = "A";
                }
                else if (int.Parse(Points) < 95 && int.Parse(Points) >= 90)
                {
                Letters = "A-";
                }
                else if (int.Parse(Points) < 90 && int.Parse(Points) >= 85)
                {
                Letters = "B";
                }
                else if (int.Parse(Points) < 85 && int.Parse(Points) >= 80)
                {
                Letters = "B-";
                }
                else if (int.Parse(Points) < 80 && int.Parse(Points) >= 75)
                {
                Letters = "C";
                }
                else if (int.Parse(Points) < 75 && int.Parse(Points) >= 70)
                {
                Letters = "C-";
                }
                else if (int.Parse(Points) < 70 && int.Parse(Points) >= 65)
                {
                Letters = "D";
                }
                else if (int.Parse(Points) < 65 && int.Parse(Points) >= 60)
                {
                Letters = "D-";
                }
                else if (int.Parse(Points) < 60 && int.Parse(Points) >= 55)
                {
                Letters = "E";
                }
                else if (int.Parse(Points) < 55 && int.Parse(Points) >= 50)
                {
                Letters = "E-";

                }
                else 
                {
                Letters = "F";
                }
        }
        public Mark()
        {

        }
             public override string ToString()
        {
            return string.Format("{0} {1}", Points, Letters);
        }
              
}
class Program
{
    static void Main(string[] args)
    {
        List<Mark> marks = new List<Mark>();
            Mark s1 = new Mark();
          Mark s2= new Mark();
            Mark s3= new Mark();
            s1.Points = "70";
            s2.Points = "100";
            s3.Points = "0";
            s1.GetLetter();
            s2.GetLetter();
            s3.GetLetter();
            marks.Add(s1);
            marks.Add(s2);
            marks.Add(s3);

            FileStream fs = new FileStream(@"C:\Users\ASUS\Desktop\PP2\Week4\Task2\students.xml", FileMode.Create, FileAccess.Write);
        XmlSerializer xs = new XmlSerializer(typeof(List<Mark>));
        xs.Serialize(fs, marks);
        fs.Close();
    }
}
}

