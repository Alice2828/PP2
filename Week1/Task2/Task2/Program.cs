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
        public Student(string n,string i)
        {
            name = n;
            id = i;
            year ="1";
        }
        public void PrintInfo()       //the method
        {
            
            Console.WriteLine(name+" "+id+" "+year); // to write(to access) name, id and increment the year of study
        }
        public void Increment()
        {
             year = (int.Parse(year) + 1).ToString(); //increasing the year
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
           string name = Console.ReadLine(); // reading name
            string id = Console.ReadLine();// reading id
           
            Student s = new Student(name,id);   //creating an example pf the structure Student

           
                s.PrintInfo(); //calling the method of printing information
            
                s.Increment();
            s.PrintInfo();
            Console.ReadKey();
        }
    }
}
