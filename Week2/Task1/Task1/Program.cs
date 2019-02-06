using System;
using System.Collections.Generic;
using System.IO; //add library
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader s = new StreamReader("C:/Users/ASUS/Desktop/PP2/Week2/Task2/1.txt");//creating a new streamreader to read from the linked txt file
            string a = s.ReadToEnd();//read info from streamreader's file
            s.Close();//close streamreader s

            char[] b = new char[a.Length]; //new array of chars length equal to file's line length 

            for (int i = 0; i < a.Length; i++)//array b is egual to array a
                b[i] = a[i];

            char[] c = new char[a.Length];//new array of chars length equal to file's line length 

            for (int i = 0; i < a.Length; i++)//array c is equal to a
                c[i] = b[i];

            Array.Reverse(c);// c is a reverse of b(a)

            bool y = true; //new boolean variable

            for (int i = 0; i < a.Length; i++)//cheking all members in b and c
            {
                if (c[i] != b[i])// if there are any non-equals the boolean variable is false
                    y = false;
            }

            if (y == true) // if bool var y is still true we wtire yes
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");//otherwise no

        }
    }
}
