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
        {//creating a 1.txt file with words through the streamwriter
            System.IO.StreamWriter textFile = new System.IO.StreamWriter("C:/Users/ASUS/Desktop/PP2/Week2/Task4/path/1.txt");
            textFile.WriteLine("Hello World!");
            textFile.WriteLine("And goodbye");
            textFile.Close();

            string m=Console.ReadLine(); //entering a command copy

            if (m=="copy")
            {
                string fileName = "1.txt";//creating new directions to file and 2 folders
                string sourcePath = "C:/Users/ASUS/Desktop/PP2/Week2/Task4/path";
                string targetPath = "C:/Users/ASUS/Desktop/PP2/Week2/Task4/path1";

                string sourceFile = System.IO.Path.Combine(sourcePath, fileName);// Use Path class to manipulate file and directory paths.
                string destFile = System.IO.Path.Combine(targetPath, fileName);
               
                if (!System.IO.Directory.Exists(targetPath))   // coping a folder's contents to a new location:
                {
                    System.IO.Directory.CreateDirectory(targetPath);
                }

                
                System.IO.File.Copy(sourceFile, destFile, true); // To copy a file to another location and 
            }

            string f = Console.ReadLine(); //again read key-word
            if (f=="delete")
            {
                // Delete a file by using File class static method...
                if (System.IO.File.Exists("C:/Users/ASUS/Desktop/PP2/Week2/Task4/path1/1.txt"))
                {
                    // Use a try block to catch IOExceptions, to
                    // handle the case of the file already being
                    // opened by another process.
                    try
                    {
                        System.IO.File.Delete("C:/Users/ASUS/Desktop/PP2/Week2/Task4/path1/1.txt");
                    }
                    catch (System.IO.IOException e)
                    {
                        Console.WriteLine(e.Message);
                        return;
                    }
                }


            }

        }
    }
}
