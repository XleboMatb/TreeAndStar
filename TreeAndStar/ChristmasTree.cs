using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeAndStar
{
    internal class ChristmasTree
    {

       private static int tempColorNumber = 0;

        public static void DrawChristmasTree(int y)
        {
            string[,] itemsToDrawWith = new string[y*3,y];

            for (int j = 0; j < itemsToDrawWith.GetLength(0); j++)
            {
                for (int i = 0; i < itemsToDrawWith.GetLength(1); i++)
                {
                    itemsToDrawWith[j, i] = "*";
                }
            }

            char itemToDrawWith = '*';
            for (int i = 0; i <= y-1; i++)
            {
                int randomColor;
                Random rand = new Random();
                for (int j = y - i; j > 0; j--)
                {
                    Console.Write(" ");
                }
                for (int j = (y-i)*2; j <= (y*2);j++)
                {
                    while (true)
                    {
                        randomColor = rand.Next(0, 5);
                        if (randomColor == tempColorNumber)
                        {
                            continue;
                        }
                        else
                        {
                            break;
                        }
                    }
                    switch (randomColor)
                    {
                        case 0:
                            Console.ForegroundColor = ConsoleColor.Blue;
                            break;
                        case 1:
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            break;
                        case 2:
                            Console.ForegroundColor = ConsoleColor.Red;
                            break;
                        case 3:
                            Console.ForegroundColor = ConsoleColor.White;
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.Green;
                            break;
                        }
                        tempColorNumber = randomColor;
                        Console.Write(itemsToDrawWith[j, i]);
                }
                Console.WriteLine("\t");
            }
            Console.ForegroundColor = ConsoleColor.Green;
            for (int i = 0; i <= (y*2)/2; i++)
            {
                if (i == (y * 2) / 2)
                {
                    Console.Write(itemToDrawWith);
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine("");
            for (int i = 0; i <= (y * 2) / 2; i++)
            {
                if (i == (y * 2) / 2)
                {
                    Console.Write(itemToDrawWith);
                }
                else
                {
                    Console.Write(" ");
                }
            }

        }


    }
}
