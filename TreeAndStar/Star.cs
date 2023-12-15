using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeAndStar
{
    internal class Star
    {

        public static void DrawAStar(int size)
        {
            for (int i = 0; i < size; i++)
            {
                if (i == size / 3)
                {
                    for (int j = 0; j <= i; j++)
                    {
                        if (size % 2 == 0)
                        {
                            for (int space = (size + (size / 3 - i)); space >= size - j; space--)
                            {
                                Console.Write(" ");
                            }
                            for (int dot = size * 2 - j; dot >= j; dot--)
                            {
                                Console.Write("*");
                            }
                        }
                        else
                        {
                            for (int space = j; space >= 0; space--)
                            {
                                Console.Write(" ");
                            }
                            for (int dot = size * 2 + 1 - j; dot > j; dot--)
                            {
                                Console.Write("*");
                            }
                        }
                        if (j == i)
                        {
                            continue;
                        }
                        else
                        {
                            Console.WriteLine(" ");
                            continue;
                        }
                    }
                    i = i + size / 3;
                }
                else if (i != size / 3)
                {
                    for (int space = size; space >= 0 + i; space--)
                    {
                        Console.Write(" ");
                    }
                    for (int dot = size * 2; dot >= (size - i) * 2; dot--)
                    {
                        //убирается последняя точка в середине треугольника
                        if (i == size - 1)
                        {
                            if (dot == size + 1)
                            {
                                Console.Write(" ");
                            }
                            else
                            {
                                Console.Write("*");
                            }
                        }
                        else
                        {
                            Console.Write("*");
                        }
                    }
                }




                Console.WriteLine(" ");
            }
        }

    }
}
