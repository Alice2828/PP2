using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        public static void PrintSpaces(int l)
        {
            for (int i = 0; i < l; i++)
                Console.Write("     ");
        }

        public static void Lol(DirectoryInfo dir, int l)
        {
            foreach (FileInfo f in dir.GetFiles())
            {
                PrintSpaces(l);
                Console.WriteLine(f.Name);
            }
            foreach (DirectoryInfo d in dir.GetDirectories())
            {
                PrintSpaces(l);
                Console.WriteLine(d.Name);
                Lol(d, l + 1);
            }
        }


        static void Main(string[] args)
        {
            DirectoryInfo dir = new DirectoryInfo("C:/Users/ASUS/Desktop/PP2/Week2/Task3/Папка");
            Lol(dir, 0);
            Console.ReadKey();
        }
    }
}
