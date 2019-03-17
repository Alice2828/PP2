using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
namespace Snake
{
      class GameState
    {
        System.Timers.Timer timer = new System.Timers.Timer(120);
        System.Timers.Timer gameTime = new System.Timers.Timer(1000);

        Worm worm = new Worm('O');
        Wall wall = new Wall('#');
        Food food = new Food('@');
        int level = 1;
       
        public GameState()
        {

            Console.CursorVisible = false;
            Console.SetWindowSize(40, 40);
            Console.SetBufferSize(40, 40);
            food.Generate(worm.body, wall.body);
        }
        public void Run()
        {
            ThreadStart action = new ThreadStart(ChangeFrame);
            Thread task = new Thread(action);
            task.Start();
            food.Draw();
            wall.Draw();
        }
        public void Run2()
        {
            timer.Elapsed += Timer_Elapsed;
            timer.Start();

            gameTime.Elapsed += GameTime_Elapsed;
            gameTime.Start();
            
            wall.Draw();
            if (food.body.Count == 0)
            {
                food.Generate(worm.body, wall.body);
            }
            
            food.Draw();
           
        }
        private void GameTime_Elapsed(object sender, ElapsedEventArgs e)
        {
            ShowStatusBar2(DateTime.Now.Second.ToString());
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            worm.Clear();
            worm.Move();
            worm.Draw();
            CheckColision();
            CheckWallColision();
            CheckSelfCollision();
            ShowStatusBar(worm.body.Count.ToString());
        }

        private void ChangeFrame()
        {
            while (true)
            {
                worm.Clear();
                worm.Move();
                worm.Draw();
                CheckColision();
                CheckWallColision();
                CheckSelfCollision();


                Console.SetCursorPosition(10, 37);
                Console.Write(message);
                Console.SetCursorPosition(10, 38);
                Console.Write(message2);


                Thread.Sleep(400);
            }
        }

        public void PressedKey(ConsoleKeyInfo consoleKeyInfo)
        {
            switch (consoleKeyInfo.Key)
            {
                case ConsoleKey.UpArrow:
                    worm.Dx = 0;
                    worm.Dy = -1;
                    break;
                case ConsoleKey.DownArrow:
                    worm.Dx = 0;
                    worm.Dy = 1;
                    break;
                case ConsoleKey.LeftArrow:
                    worm.Dx = -1;
                    worm.Dy = 0;
                    break;
                case ConsoleKey.RightArrow:
                    worm.Dx = 1;
                    worm.Dy = 0;
                    break;
                case ConsoleKey.Spacebar:
                    timer.Enabled = !timer.Enabled;
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
                    wall.Draw();
                    food.Generate(wall.body, worm.body);
                    food.Draw();
                    level = 2;
                    break;
                case ConsoleKey.F3:
                    Console.Clear();
                    worm.body.Clear();
                    worm.body.Add(new Point { X = 20, Y = 20 });
                    wall.LoadLevel(3);
                    wall.Draw();
                    food.Draw();
                    food.Generate(wall.body, worm.body);
                    level = 3;
                    break;
            }

            CheckColision();
           

        }

        string message = "";
        string message2 = "";
        void ShowStatusBar(string message)
        {
            this.message = message;
            //Console.SetCursorPosition(10, 37);
            //Console.Write(message);
        }

        void ShowStatusBar2(string message)
        {
            this.message2 = message;
            //Console.SetCursorPosition(10, 38);
            //Console.Write(message);
        }
        void CheckColision()
        {
            if (worm.CheckIntersection(food.body) == true)
            {
                worm.Eat(food.body);
                food.Generate(worm.body,wall.body);
                food.Draw();
                
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
