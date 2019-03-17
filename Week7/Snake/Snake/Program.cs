using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    
   
    class Program
    {
        static void Main(string[] args)
        {
            GameState game = new GameState();
            Console.WriteLine("Your name");
            string name = Console.ReadLine();
            Console.Clear();
            game.Run2();

            while (true)
            {                
                
                ConsoleKeyInfo consoleKeyInfo = Console.ReadKey();
                game.PressedKey(consoleKeyInfo);
                Console.SetCursorPosition(1, 32);
                int score = game.Score();
                int level = game.Level();
                Console.Write("Player {0}  Score  {1}  Level {2}" ,name, score, level);


            }


        }
    }
}
