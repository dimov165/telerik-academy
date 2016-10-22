﻿using System;
using System.Text;
using System.Threading;
using System.Diagnostics;

namespace FallingRocks
{
    class FallingRocks
    {
        static void DrawPlayer(int locationX, int locationY, char player)
        {
            Console.Clear();
            Console.SetCursorPosition(locationX, locationY);
            Console.Write(player);
        }

        static void Main()
        {
            // define the variables
            bool gameRunning = true;
            int windowHeight = 25;
            int windowWidth = 55;
            int locationX = 27;
            int locationY = 24;
            char player = (char)'ʘ';
            Stopwatch stopWatch = new Stopwatch();

            // console settings
            Console.Title = "Falling Rocks by D Dimov";
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.OutputEncoding = Encoding.Unicode;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.CursorVisible = false;
            Console.BufferHeight = Console.WindowHeight = windowHeight;
            Console.BufferWidth = Console.WindowWidth = windowWidth;
            
            DrawPlayer(27, 24, (char)'ʘ');

            ConsoleKeyInfo keyInfo;
            while ((keyInfo = Console.ReadKey(true)).Key != ConsoleKey.Escape && gameRunning == true)
            {
                Console.Write(player);
                stopWatch.Start();
                switch (keyInfo.Key)
                {
                    case ConsoleKey.RightArrow:
                        if (locationX < 54)
                        {
                            locationX++;
                        }
                        break;

                    case ConsoleKey.LeftArrow:
                        if (locationX > 0)
                        {
                            locationX--;
                        }
                        break;

                    case ConsoleKey.UpArrow:
                        if (locationY > 0)
                        {
                            locationY--;
                        }
                        break;

                    case ConsoleKey.DownArrow:
                        if (locationY < 24)
                        {
                            locationY++;
                        }
                        break;
                }
                DrawPlayer(locationX, locationY, player);
            }

            // final screen after game ends
            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("Time survived: " + ts);
            Console.WriteLine("");
        }
    }
}