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
            string l1 = Console.ReadLine(); //reading 1st line - a number which is a string for programm
            string l2 = Console.ReadLine(); //reading 2nd line - sequence of numbers

            int n = int.Parse(l1); //turning 1st number to integer
            string[] num = l2.Split(); //making second line string the string array num

            for (int i = 0; i < num.Length; ++i)//loop which goes through the array
            {
                int x = int.Parse(num[i]);//converting members to the integer
                for (int j = 0; j < 2; ++j)
                {
                    Console.Write(x + " ");//writing them twice
                }
            }
        }
    }
}
