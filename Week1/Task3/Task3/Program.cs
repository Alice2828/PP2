using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            string l1 = Console.ReadLine();
            string l2 = Console.ReadLine();

            int n = int.Parse(l1);
            string[] num = l2.Split(); 

            for (int i = 0; i < num.Length; ++i)
            {
                int x = int.Parse(num[i]);
                for (int j = 0; j < 2; ++j)
                {
                    Console.Write(x + " ");
                }
            }
        }
    }
}
