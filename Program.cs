using System;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using static System.Net.Mime.MediaTypeNames;


class Patterns
{
    static void Main()
    {
        Console.WriteLine("Enter the number of rows to print ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();

        if (n < 3)
        {
            Console.WriteLine("Please enter a value greater than equal to 3");
            return;
        }
        else
        {
            SquareHollowPattern(n);
            Console.WriteLine();
            NumberTrianglePattern(n);
            Console.WriteLine();

            NumberIncreasingPyramidPattern(n);
            Console.WriteLine();

            NumberIncreasingReversePyramidPattern(n);
            Console.WriteLine();

            NumberChangingPyramidPattern(n);
            Console.WriteLine();

            ZeroOneTrianglePattern(n);
            Console.WriteLine();

            PalindromeTrianglePattern(n);
            Console.WriteLine();

            RhombusPattern(n);
            Console.WriteLine();

            DiamondStarPattern(n);
            Console.WriteLine();

            MirrorImageTrianglePattern(n);
            Console.WriteLine();

            HollowTrianglePattern(n);
            Console.WriteLine();

            ReverseHollowTrianglePattern(n);
            HollowDiamondPyramid(n);
            Console.WriteLine();

            HollowHourglassPattern(n);
            Console.WriteLine();

            PascalTriangle(n);
        }

        Console.ReadKey();

    }

    public static void SquareHollowPattern(int input)
    {
        for (int i = 1; i <= input; i++)
        {
            for (int j = 1; j <= input; j++)
            {
                if (i == 1 || i == input || j == 1 || j == input)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(" ");
                }
            }

            Console.WriteLine();

        }
    }

    public static void NumberTrianglePattern(int input)
    {
        int numberCount = 1;
        for (int i = 1; i <= input; i++) // for printing the rows
        {
            for (int j = input; j > i; j--)
            {
                Console.Write(" ");

            }
            for (int j = 1; j <= i; j++)
            {
                Console.Write(numberCount + " ");
            }

            numberCount++;
            Console.WriteLine();

        }
    }

    public static void NumberIncreasingPyramidPattern(int input)
    {
        for (int i = 1; i <= input; i++)
        {
            int numberCount = 1; // for reseting the count for the new line

            for (int j = 1; j <= i; j++)
            {
                Console.Write(numberCount + " ");
                numberCount++;
            }
            Console.WriteLine();
        }
    }

    public static void NumberIncreasingReversePyramidPattern(int input)
    {
        for (int i = 1; i <= input; i++)
        {
            int numberCount = 1;
            for (int j = input; j >= i; j--)
            {
                Console.Write(numberCount + " ");
                numberCount++;
            }
            Console.WriteLine();
        }
    }

    public static void NumberChangingPyramidPattern(int input)
    {
        int numberCount = 1;

        for (int i = 1; i <= input; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(numberCount + " ");
                numberCount++;
            }

            Console.WriteLine();

        }
    }

    public static void ZeroOneTrianglePattern(int input)
    {
        for (int i = 1; i <= input; i++)
        {
            for (int j = 1; j <= i; j++)
            {

                if (i % 2 == 1)
                {
                    Console.Write((j % 2 == 1) ? "1 " : "0 ");
                }
                else
                {
                    Console.Write((j % 2 == 1) ? "0 " : "1 ");
                }
            }
            Console.WriteLine();
        }
    }

    public static void PalindromeTrianglePattern(int input)
    {
        for (int i = 1; i <= input; i++)
        {

            for (int j = 1; j <= input - i; j++)
            {
                Console.Write("  ");
            }

            for (int j = i; j >= 1; j--)
            {
                Console.Write(j + " ");
            }

            for (int j = 2; j <= i; j++)
            {
                Console.Write(j + " ");
            }

            Console.WriteLine();
        }
    }

    public static void RhombusPattern(int input)
    {
        for (int i = 1; i <= input; i++)
        {
            for (int j = input - 1; j >= i; j--)
            {
                Console.Write(" ");
            }

            for (int j = 1; j <= input; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }

    public static void DiamondStarPattern(int input)
    {
        int starCount = 1;

        for (int i = 1; i <= input; i++)
        {
            for (int j = input; j >= i; j--)
            {
                Console.Write(" ");
            }

            for (int j = 1; j <= starCount; j++)
            {
                Console.Write("*");

            }
            starCount += 2;

            Console.WriteLine();
        }

        for (int i = 1; i <= input + 1; i++)
        {
            for (int j = 1; j <= i - 1; j++)
            {
                Console.Write(" ");
            }

            for (int j = 1; j <= starCount; j++)
            {
                Console.Write("*");

            }

            starCount -= 2;
            Console.WriteLine();


        }
    }

    public static void MirrorImageTrianglePattern(int input)
    {

        for (int i = 1; i <= input; i++)
        {

            for (int j = 1; j < i; j++)
            {
                Console.Write(" ");
            }


            for (int j = i; j <= input; j++)
            {
                Console.Write(j + " ");
            }

            Console.WriteLine();
        }

        for (int i = input - 1; i >= 1; i--)
        {
            for (int j = 1; j < i; j++)
            {
                Console.Write(" ");
            }

            for (int j = i; j <= input; j++)
            {
                Console.Write(j + " ");
            }

            Console.WriteLine();
        }
    }

    public static void HollowTrianglePattern(int input)
    {
        for (int i = 1; i <= input; i++)
        {

            for (int j = i; j < input; j++)
            {
                Console.Write(" ");
            }


            for (int j = 1; j <= i * 2 - 1; j++)
            {
                if (j == 1 || j == i * 2 - 1)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(" ");
                }
            }



            Console.WriteLine();
        }
        for (int i = 1; i <= 2 * input - 1; i++)
        {
            Console.Write("*");
        }
    }

    public static void ReverseHollowTrianglePattern(int input)
    {

        for (int i = 1; i <= input; i++)
        {

            for (int j = 1; j <= i - 1; j++)
            {
                Console.Write(" ");
            }


            int lastCol = (input * 2 - (2 * i - 1));


            for (int j = 1; j <= lastCol; j++)
            {

                if (i == 1 || j == 1 || j == lastCol)
                    Console.Write("*");
                else
                    Console.Write(" ");
            }

            Console.WriteLine();
        }
    }

    public static void HollowDiamondPyramid(int input)
    {
        for (int i = 1; i <= input; i++)
        {
            for (int j = i; j < input; j++)
            {
                Console.Write(" ");
            }

            for (int j = 1; j <= i * 2 - 1; j++)
            {
                if (j == 1 || j == i * 2 - 1)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(" ");
                }
            }

            Console.WriteLine();
        }

        for (int i = 1; i <= input - 1; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(" ");
            }

            int lastCol = (input * 2 - (2 * i + 1));

            for (int j = 1; j <= lastCol; j++)
            {
                if (j == 1 || j == lastCol)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(" ");
                }
            }

            Console.WriteLine();
        }
    }

    public static void HollowHourglassPattern(int input)
    {
        for (int i = input; i >= 1; i--)
        {
            for (int j = i; j <= input; j++)
            {
                Console.Write(" ");
            }
            for (int k = 1; k < i * 2 - 1; k++)
            {
                if (k == 1 || i == input)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.Write("*");
            Console.WriteLine();
        }
        for (int i = 2; i <= input; i++)
        {
            for (int j = i; j <= input; j++)
            {
                Console.Write(" ");
            }
            for (int k = 1; k < i * 2 - 1; k++)
            {
                if (k == 1 || i == input)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.Write("*");
            Console.WriteLine();
        }

    }

    public static void PascalTriangle(int input)
    {

        for (int i = 0; i < input; i++)
        {
            int count = 1;
            for (int j = 0; j < input - i; j++)
            {
                Console.Write(" ");
            }
            for (int j = 0; j <= i; j++)
            {
                Console.Write(count + " ");
                count = count * (i - j) / (j + 1);


            }
            Console.WriteLine();
        }
    }
}




