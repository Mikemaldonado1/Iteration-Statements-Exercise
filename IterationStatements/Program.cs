using System;
using System.Collections.Generic;

namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000
        public static void PrintNums()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
        }



        //Write a method that will print to the console numbers 3 through 999 by 3 each time

        public static void NumByThree()
        {
            for (int i = 3; i <= 999; i += 3)
            {
                Console.WriteLine(i);
            }

        }


        //Write a method to accept two integers as parameterss and check whether they are equal or not

        public static void EqualOrNot(int num1, int num2)
        {
            if (num1 == num2)
            {
                Console.WriteLine();
                Console.WriteLine("The numbers are equal");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("The numbers are NOT equal");
            }
        }

        //Write a method to check whether a given number is even or odd

        public static void EvenOrOdd(int num)
        {
            if (num % 2 == 0)
            {
                Console.WriteLine();
                Console.WriteLine("The number is even");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("The number is odd");
            }

        }

        //Write a method to check whether a given number is positive or negative

        public static void PositiveOrNegative(int num)
        {
            if (num >= 0)
            {
                Console.WriteLine();
                Console.WriteLine("The number is positive");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("The number is negative");
            }
        }

        //Write a method to read the age of a candidate and determine whether they can vote.
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()

        public static void VoterAge(string Age)
        {
            if (int.TryParse(Age, out int num))
            {

                if (num >= 18)
                {
                    Console.WriteLine();
                    Console.WriteLine("You are old enough to vote!");
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("You are NOT old enough to vote, sorry");

                }
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("The data provided is NOT valid, sorry.");
            }

        }

        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10

        public static void RangeChecker(string num1)
        {
            Console.WriteLine("Please enter a number: ");
            string userInput = Console.ReadLine();

            if (int.TryParse(userInput, out int num3))
            {
                if (num3 >= -10 && num3 <= 10)
                {
                    Console.WriteLine("The number entered is in range");
                }
                else
                {
                    Console.WriteLine("The number entered is NOT in range");
                }

            }
            else
            {
                Console.WriteLine("The data entered is not valid");
            }

        }



        //Write a method to display the multiplication table(from 1 to 12) of a given integer

        public static void MultiplicationTable(int num1)
        {
            Console.WriteLine("Multiplication Table: ");
            for (int i = 1; i<13; i++)
            {
                Console.Write("{0} X {1} = {2} \n", num1, i, num1 * i);
                
            }

        }


        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {

            //Program.PrintNums();
            //Program.NumByThree();
            //Program.EqualOrNot(2,2);
            //Program.EvenOrOdd(3);
            //Program.PositiveOrNegative(-5);
            //Program.VoterAge("17");
            //Program.RangeChecker("");
            Program.MultiplicationTable(2);




        }
    }
}
