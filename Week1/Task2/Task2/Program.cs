using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Student         //creating a new structure named "Student"
    {
        public string name;   //adding parametrs (name) 
        public string id;//adding id
        public string year;//adding year
        public void PrintInfo()       //the method
          {
            int yyear = int.Parse(year)+1; //increasing the year
            Console.WriteLine(name+" "+id+" "+yyear); // to write(to access) name, id and increment the year of study
        }

     }

    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();   //creating an example pf the structure Student
            s.name = Console.ReadLine(); // reading name
           s.id =Console.ReadLine();// reading id
            s.year = Console.ReadLine();// reading year
            s.PrintInfo(); //calling the method of printing information
        }
    }
}
