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
            string a = Console.ReadLine();//reading line which is string for programm
            int aa = int.Parse(a);//turning line into integer(we know exactly there is a number)
            for (int i = 0; i < aa; ++i)//loop which means lines
            {
                for (int j = 0; j < i+1; ++j)//loop which means quantity of [*]
                {
                    Console.Write("[*]");//writing [*]
                }
                Console.WriteLine();//going to another line
            }
        }
    }
}
