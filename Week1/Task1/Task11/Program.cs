using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task11
{
    class Program
    {
        static bool isPrime(string f)
        {
            int x = int.Parse(f);
            if (x == 1) return false;
                for (int j = 2; j < x; ++j)
                {
                    if (x % j == 0) 
                        return false;
                }

                return true;
            
        }

        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();
                        
            int aa = int.Parse(a);

            string[] num = b.Split();
            int k = 0;
            for (int i = 0; i < num.Length; ++i)
            {


                if (isPrime(num[i]) == true)
                {
                    k++;

                }

            }
            Console.WriteLine(k);

            for (int i = 0; i < num.Length; ++i)
            {

          
                if (isPrime(num[i]) ==true)
                {
                    Console.WriteLine(num[i]+' ');

                }
                
            }
            
            
        }
    }
}
