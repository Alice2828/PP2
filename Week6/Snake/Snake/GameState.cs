using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
      class GameState
    {
        Worm worm = new Worm('O');
        Wall wall = new Wall('#');
        Food food = new Food('@');
        int level = 1;
       
        public GameState()
        {
            Console.CursorVisible = false;
            Console.SetWindowSize(40, 40);
            Console.SetBufferSize(40, 40);
        }

        public void PressedKey(ConsoleKeyInfo consoleKeyInfo)
        {
            switch (consoleKeyInfo.Key)
            {
                case ConsoleKey.UpArrow:
                    worm.Move(0, -1);
                    break;
                case ConsoleKey.DownArrow:
                    worm.Move(0, 1);
                    break;
                case ConsoleKey.LeftArrow:
                    worm.Move(-1, 0);
                    break;
                case ConsoleKey.RightArrow:
                    worm.Move(1, 0);
                    break;
                case ConsoleKey.Escape:
                    Console.Clear();
                    Console.SetCursorPosition(20, 30);
                    Console.WriteLine("Exit?");
                    Environment.Exit(0); 
                    break;
                case ConsoleKey.F2:
                    Console.Clear();
                    worm.body.Clear();
                    worm.body.Add(new Point { X = 20, Y = 20 });
                    wall.LoadLevel(2);
                    food.Generate(wall.body, worm.body);
                    level = 2;
                    break;
                case ConsoleKey.F3:
                    Console.Clear();
                    worm.body.Clear();
                    worm.body.Add(new Point { X = 20, Y = 20 });
                    wall.LoadLevel(3);
                    food.Generate(wall.body, worm.body);
                    level = 3;
                    break;
            }

            CheckColision();
            CheckWallColision();
            CheckSelfCollision();   

        }

        void CheckColision()
        {
            if (worm.CheckIntersection(food.body) == true)
            {
                worm.Eat(food.body);
                food.Generate(worm.body,wall.body);
                
            }

        }
        void CheckWallColision()
        {
            if (wall.CheckIntersection(worm.body) == true)
            {
                worm.Clear();
                food.Clear();
                wall.Clear();
                Console.WriteLine("     ");
                Console.WriteLine("Game over");
                Environment.Exit(0);
            }

        }
        void CheckSelfCollision()
        {
            if (worm.body.Count>1 && worm.CheckIntersection2() == true)
            {
                worm.Clear();
                food.Clear();
                wall.Clear();
                Console.Clear();
               
                Console.WriteLine("Game over");
                Environment.Exit(0);

            }
        }



        public void Draw()
        {
            worm.Draw();
            wall.Draw();
            if (food.body.Count==0)
            {
                food.Generate(worm.body, wall.body);
            }
            food.Draw();       
        }
        public int Score()
        {
            return worm.body.Count;
        }
        public int Level()
        {
            return level;
        }

    }
}
