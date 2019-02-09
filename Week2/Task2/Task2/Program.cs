using System;
using System.Collections.Generic;
using System.IO;//adding library
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static bool IsPrime(string i)  //creating a method which returns true or false due to results of testing member of string array
        {

            int x = int.Parse(i);//turning a member of string array into integer
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
            List<string> res = new List<string>(); //creating a new list of string

            StreamReader s = new StreamReader("C:/Users/ASUS/Desktop/PP2/Week2/Task2/Task2/bin/1.txt");//creating new streamreader from link
            string[] nums = s.ReadToEnd().Split();//new array of members of streamreader splited by gaps
              
            foreach (var x in nums)//for each member use the method and if it is true add it to the res array
            {
                if (IsPrime(x))
                {
                    res.Add(x);
                }
            }

            s.Close(); //close streamreader

            StreamWriter w = new StreamWriter("C:/Users/ASUS/Desktop/PP2/Week2/Task2/Task2/bin/2.txt");//open new streamwriter to output file

            foreach (var x in res)//write each member of res array spliting them by gaps into file
            {
                w.Write(x + " ");

            }
            w.Close(); //close the streamwriter
        }
    }
}
