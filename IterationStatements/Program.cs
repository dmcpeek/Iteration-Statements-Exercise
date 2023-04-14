using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000
        public static void NumRange()
        {
            for (int i = 1000; i >= 0; i--)
            {
                Console.WriteLine(i);
            }

            for (int i = 1; i > -1001; i--) //i = 1 so 0 will only print once
            {
                Console.WriteLine(i);
            }
        }

        //Write a method that will print to the console numbers 3 through 999 by 3 each time
        public static void ByThrees()
        {
            for (int i = 3; i <= 999; i += 3)
            {
                Console.WriteLine(i);
            }
        }

        //Write a method to accept two integers as parameterss and check whether they are equal or not
        public static void TrueOrFalse(int a, int b)
        {
            int remainder;
            if ((a == 0 && b == 0))
            {
                Console.WriteLine($"The result of {a} % {b} is undefined.");
            }
            else if ((b == 0))
            {
                Console.WriteLine($"{a} cannot be divided by {b}.");
            }
            else if ((b == 1))
            {
                Console.WriteLine($"{a} and {b} are not equal.");
            }
            else
            { 
                remainder = a % b;
                if (remainder == 0)
                {
                    Console.WriteLine($"{a} and {b} are equal.");
                }
                else
                {
                    Console.WriteLine($"{a} and {b} are not equal.");
                }
            }
            
        }

        //Write a method to check whether a given number is even or odd
        public static void EvenOrOdd(int a)
        {
            if (a == 0)
            {
                Console.WriteLine($"{a} is mathematically even. See https://tinyurl.com/5ybxsw6f");
            }
            else
            {
                int remainder = a % 2;
                if (remainder == 0)
                {
                    Console.WriteLine($"{a} is an even number.");
                }
                else
                {
                    Console.WriteLine($"{a} is not an even number.");
                }
            }

        }

        //Write a method to check whether a given number is positive or negative
        public static void NegativeOrPositive(int a)
        {
            if (a == 0)
            {
                Console.WriteLine($"{a} is neither positive nor negative");
            }
            else
            {
                if (a < 0)
                {
                    Console.WriteLine($"{a} is a negative number.");
                }
                else
                {
                    Console.WriteLine($"{a} is a positive number.");
                }
            }

        }

        //Write a method to read the age of a candidate and determine whether they can vote.
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()
        public static void VotingAge(string age)
        {
            int ageInt;
            int.TryParse(age, out ageInt);
            if (ageInt >= 18)
            {
                Console.WriteLine($"You are {ageInt} and eligible to vote. Please make sure you are registered.");
            }
            else
            {
                Console.WriteLine($"You are {ageInt}. You must be at least 18 to vote.");
            }
        }

        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10
        public static void Range(int a)
        {
            if (a < -10 || a > 10)
            {
                Console.WriteLine($"{a} is not between -10 and 10.");
            }
            else
            {
                Console.WriteLine($"{a} is between -10 and 10.");
            }
        }

        //Write a method to display the multiplication table(from 1 to 12) of a given integer
        public static void MultiplicationTable(int a)
        {
            if (a > 12 || a < 1)
            {
                Console.WriteLine($"{a} is out of range. Enter a number that is between 1 and 12.");
            }
            else
            {
                for (int outer = 1; outer <=a; outer++)
                {
                    for (int inner = 1; inner <= 12; inner++)
                    {
                        Console.Write(outer * inner + " ");
                    }
                    Console.WriteLine("");
                }
            }
        }

        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {
            NumRange();
            Console.WriteLine("");

            ByThrees();

            TrueOrFalse(1, 2); //Try (0,0), (any number > 0,0), and (any number > 0,1).
            Console.WriteLine("");

            EvenOrOdd(3); //Try 0. It is a special case.
            Console.WriteLine("");

            NegativeOrPositive(2); //Try 0. It is a special case.
            Console.WriteLine("");

            VotingAge("19");
            Console.WriteLine("");

            Range(11);
            Console.WriteLine("");

            MultiplicationTable(3); //Try 0 and 13 since both are out of range.
        }
    }
}
