using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Student
    {
        public string name;
        public string id;
        public string year;
        public void PrintInfo()       
          {
            int yyear = int.Parse(year)+1;
            Console.WriteLine(name+" "+id+" "+yyear);
          }

     }

    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.name = Console.ReadLine();
           s.id =Console.ReadLine();
            s.year = Console.ReadLine();
            s.PrintInfo();
        }
    }
}
