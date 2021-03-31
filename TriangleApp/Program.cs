using System;

namespace TriangleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\tTrianle Application\n\n\n");

            //variable declaration
            int sideA, sideB, sideC;

            //user inputs
            Console.Write("\tEnter the length of Side A: ");
            sideA = int.Parse(Console.ReadLine()); //using int.Parse to convert string to int
            
            Console.Write("\tEnter the length of Side B: ");
            sideB = Convert.ToInt32(Console.ReadLine()); //using Convert.ToInt32 to convert the string to int
            
            Console.Write("\tEnter the length of Side C: ");
            sideC = Convert.ToInt32(Console.ReadLine());

            //checking for invalid values entered for any side
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
            {
                Console.Write("\n\tOne or all of the lengths you have entered may be invalid. \n\tPlease check and try again...");
            }

            //checking the Pythagoras Theorem C^2 = B^2 + A^2 but considering all and any side to be A, B or C. 
            else if (sideA * sideA == sideB * sideB + sideC * sideC || sideB * sideB == Math.Pow(sideA, 2) + Math.Pow(sideC, 2) || Math.Pow(sideC, 2) == Math.Pow(sideA, 2) + Math.Pow(sideB, 2))
            {
                Console.Write("\n\tThis is a Right Angled Triangle");
            }
            
            //checking if all the sides are equal
            else if (sideA == sideB && sideB == sideC)
            {
                Console.Write("\n\tThis is an Equilateral Triangle... ");
            }

            //checking if none of the sides are equal
            else if (sideA != sideB && sideB != sideC)
            {
                Console.Write("\n\tThis is a Scalene Triangle... ");
            }           

            //You can swap any of the preceding conditions and place it here in the else block but you need to understand the order
            else
            {
                Console.Write("\n\tThis is an Isoceles Triangle...");
            }

            Console.Write("\n\tPrese any key to exit");
            Console.ReadLine();
        }
    }
}
