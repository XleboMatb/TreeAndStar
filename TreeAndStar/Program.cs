using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TreeAndStar
{
    internal class Program
    {
        private static bool isHeight = false;
        private static bool isStar = false;
        static void Main(string[] args)
        {
            int choice = InputCheck();
            isHeight = false;
            switch (choice)
            {
                case 1:
                    isHeight = true;
                    isStar = false;
                    int heightOfTree = InputCheck();
                    while (true)
                    {
                        ChristmasTree.DrawChristmasTree(heightOfTree);
                        Thread.Sleep(1000);
                        Console.Clear();
                        continue;
                    }
                case 2:
                    isStar = true;
                    isHeight = true;
                    int heightOfStar = InputCheck();
                    Star.DrawAStar(heightOfStar);
                    break;
                default:
                    Console.WriteLine("it's NOT the choice number");
                    Main(null);
                    break;
            }
            Console.ReadLine();

        }
        private static int InputCheck()
        {
            if (isHeight)
            {
                if (isStar)
                {
                    Console.Write("enter the height: ");
                    if (int.TryParse(Console.ReadLine(), out int choice) & (choice <= 50 & choice >= 5))
                    {
                        return choice;
                    }
                    else
                    {
                        Console.WriteLine("nope");
                        return InputCheck();
                    }
                }
                else
                {
                    Console.Write("enter the height: ");
                    if (int.TryParse(Console.ReadLine(), out int choice) & (choice <= 50 & choice >= 2))
                    {
                        return choice;
                    }
                    else
                    {
                        Console.WriteLine("nope");
                        return InputCheck();
                    }
                }
            }
            else
            {
                Console.WriteLine("what do u wanna look at?");
                Console.WriteLine("1 - Christmas Tree, 2 - a star (yeas, just a star...)");
                if (int.TryParse(Console.ReadLine(), out int choice))
                {
                    return choice;
                }
                else
                {
                    Console.WriteLine("nope");
                    return InputCheck();
                }
            }
            
        }
    }
}
