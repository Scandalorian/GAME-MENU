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
            const int maxMenuItems = 5;
            int selector = 0;
            bool good = false;
            while (selector != maxMenuItems)
            {
                Console.Clear();
                DrawTitle();
                DrawMenu(maxMenuItems);
                good = int.TryParse(Console.ReadLine(), out selector);
                if (good)
                {
                    switch (selector)
                    {
                        case 1:
                            Console.WriteLine("// code for case 1 here");
                            break;
                        case 2:
                            Console.WriteLine("// code for case 2 here");
                            break;
                        case 3:
                            Console.WriteLine("// code for case 3 here");
                            break;
                        case 4:
                            Console.WriteLine("// code for case 4 here");
                            break;
                        case 5:
                            Console.WriteLine("PRESS ANY KEY TO CONTINUE QUITTING");
                            break;
                        //  If more cases, add here. If so, go to the top and change maxMenuItems amount the total cases 
                        default:
                            if (selector != maxMenuItems)
                            {
                                ErrorMessage();
                            }
                            break;
                    }
                }
                else
                {
                    ErrorMessage();
                }
                Console.ReadKey();
            }
        }
        private static void ErrorMessage()
        {
            Console.WriteLine("INCORRECT ENTRY. TYPE ANY KEY TO CONTINUE.");
        }
        private static void DrawStarLine()
        {
            Console.WriteLine("****************************");
        }
        private static void DrawTitle()
        {
            Console.WriteLine(" ");
            DrawStarLine();
        }
        private static void DrawMenu(int maxitems)
        {
            Console.WriteLine(" SELECT YOUR MODE BY NUMBER");
            DrawStarLine();
            Console.WriteLine(" 1. EASY MODE");
            Console.WriteLine(" 2. REGULAR MODE");
            Console.WriteLine(" 3. DIFFICULT MODE");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" 4. INSANE MODE");
            Console.ResetColor();
            // more menu items here
            Console.WriteLine(" 5. QUIT");
            DrawStarLine();
            Console.WriteLine(" PRESS {0} TO QUIT", maxitems);
            DrawStarLine();
        }
    }
}