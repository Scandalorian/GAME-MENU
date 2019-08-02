using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Change the number of menu items here
            const int quitVariable = 3;
            int selector = new int();
            bool userInput = false;
            int size = new int();
            
            while (selector != quitVariable)
            {
                Console.Clear();
                DrawMenu();
                userInput = int.TryParse(Console.ReadLine(), out selector);
                if (userInput)
                {
                    switch (selector)
                    {
                        case 1:
                            // EASY MODE
                            size = 8;
                            selector = 3;
                            break;
                        case 2:
                            //HARD MODE
                            size = 11;
                            selector = 3;
                            break;
                        case 3:
                            //QUIT GAME
                            userInput = false;
                            break;
                        //  If more cases, add here. If so, go to the top and change maxMenuItems amount the total cases 
                        default:
                            break;
                    }
                }
            }
            while (userInput == true)
            {
                // GAME HERE
                Console.WriteLine("Game plays");
                Console.ReadLine();
            }
        }
        private static void DrawMenu()
        {
            Console.WriteLine(" Welcome To STAR COLLECTOR ");
            Console.WriteLine("****************************");
            Console.WriteLine(" Select Your Difficulty ");
            Console.WriteLine("****************************");
            Console.WriteLine(" 1. REGULAR");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" 2. HARD");
            Console.ResetColor();
            Console.WriteLine(" 3. Quit Game");
            Console.WriteLine("****************************");
        }
    }
}
