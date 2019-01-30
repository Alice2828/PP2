using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task11
{
    class Program 
    {
        static bool isPrime(string f)  //creating a method which returns true or false due to results of testing member of string array
        {
            int x = int.Parse(f);//turning a member of string array into integer
            if (x == 1) return false;//1 is not prime, but divides itself and 1, we need to accept it and return false if it appears
                for (int j = 2; j <= Math.Sqrt(x); ++j)//loop from 2 till square of the number
                {
                    if (x % j == 0) //if j divides x then it is not prime and the method returns false
                        return false;
                }

                return true; //else if no number divides x it returns true
            
        }

        static void Main(string[] args)
        {
            string a = Console.ReadLine();//reading 1st line
            string b = Console.ReadLine();//reading 2nd line
                        
            int aa = int.Parse(a); //turning 1st into integer

            string[] num = b.Split();//making string array from 2nd line 
            int k = 0;//new integer k
            for (int i = 0; i < num.Length; ++i)//loop from first till last member of the array
            {


                if (isPrime(num[i]) == true) //if method finds that the number is prime, it counts it into k
                {
                    k++;//adding 1 to the k

                }

            }
            Console.WriteLine(k);//writing out number of primes

            for (int i = 0; i < num.Length; ++i)
            {

          
                if (isPrime(num[i]) ==true)
                {
                    Console.WriteLine(num[i]+' ');//finding primes and writing them out

                }
                
            }
            
            
        }
    }
}
