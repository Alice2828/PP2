using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            int aa = int.Parse(a);
            for (int i = 0; i < aa; ++i)
            {
                for (int j = 0; j < i+1; ++j)
                {
                    Console.Write("[*]");
                }
                Console.WriteLine();
            }
        }
    }
}
