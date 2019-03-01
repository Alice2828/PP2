using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Task1
{
    [Serializable]
    public class Number
    {
        public double a;
        public double b;
        public Number()
        {

        }
        public void PrintInfo()
        {
            
            Console.WriteLine($"{a} + {b} i");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Number s = new Number
            {
                a = 2.0,
                b = 3.5
            };
            

            FileStream fs = new FileStream(@"C:\Users\ASUS\Desktop\PP2\Week4\Task1\student.xml", FileMode.Create, FileAccess.Write);
            XmlSerializer xs = new XmlSerializer(typeof(Number));
            xs.Serialize(fs, s);
            fs.Close();

            FileStream f = new FileStream(@"C:\Users\ASUS\Desktop\PP2\Week4\Task1\student.xml", FileMode.Open, FileAccess.Read);
            XmlSerializer x = new XmlSerializer(typeof(Number));
            Number m = x.Deserialize(f) as Number;
            m.PrintInfo();
            f.Close();
        }
    
    }
}
