using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {//creating a 1.txt file with words through the streamwriter
            StreamWriter textFile = new StreamWriter("C:/Users/ASUS/Desktop/PP2/Week2/Task4/path/1.txt");
            textFile.WriteLine("Hello World!");
            textFile.WriteLine("And goodbye");
            textFile.Close();

            string m=Console.ReadLine(); //entering a command copy

            if (m=="copy")
            {
                string fileName = "1.txt";//creating new directions to file and 2 folders
                string sourcePath = "C:/Users/ASUS/Desktop/PP2/Week2/Task4/path";
                string targetPath = "C:/Users/ASUS/Desktop/PP2/Week2/Task4/path1";

                string sourceFile = Path.Combine(sourcePath, fileName);// Use Path class to manipulate file and directory paths.
                string destFile =Path.Combine(targetPath, fileName);
               
                if (!Directory.Exists(targetPath))   // cheking if the target directory exists
                {
                    Directory.CreateDirectory(targetPath);
                }

                
                File.Copy(sourceFile, destFile, true); // coping a folder's contents to a new location:
            }

            string f = Console.ReadLine(); //again read key-word
            if (f=="delete")
            {
                // Delete a file by using File class static method...
                if (File.Exists("C:/Users/ASUS/Desktop/PP2/Week2/Task4/path1/1.txt"))
                {
                    // Use a try block to catch IOExceptions, to
                    // handle the case of the file already being
                    // opened by another process.
                    try
                    {
                        File.Delete("C:/Users/ASUS/Desktop/PP2/Week2/Task4/path/1.txt");
                    }
                    catch (IOException e)
                    {
                        Console.WriteLine(e.Message);
                        return;
                    }
                }


            }

        }
    }
}
