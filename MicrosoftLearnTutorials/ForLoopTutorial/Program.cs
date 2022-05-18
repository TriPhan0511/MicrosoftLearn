using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoopTutorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 
            /*
                FizzBuzz challenge
                Rules:
                1. Ouput values from 1 to 100, one number per line.
                2. When the current value is divisible by 3, print the term Fizz next to the number.
                3. When the current value is divisible by 5, print the term Buzz next to the number.
                4. When the current value is divisible by both 3 and 5, print the term FizzBuzz next to the number.
             */

            for (int i = 1; i <= 100; i++)
            {
                if ((i % 3 == 0) && (i % 5 == 0))
                {
                    Console.WriteLine($"{i} - FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine($"{i} - Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine($"{i} - Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }

        //static void Main(string[] args)
        //{

        //    //for (int i = 0; i < 10; i++)
        //    //{
        //    //    Console.WriteLine(i);
        //    //}

        //    //for (int i = 10; i >= 0; i--)
        //    //{
        //    //    Console.WriteLine(i);
        //    //}

        //    //for (int i = 0; i < 10; i++)
        //    //{
        //    //    Console.WriteLine(i);
        //    //    if (i == 7)
        //    //    {
        //    //        break;
        //    //    }
        //    //}

        //    string[] names = { "Alex", "Eddie", "David", "Michael" };

        //    //for (int i = names.Length - 1; i >= 0; i--)
        //    //{
        //    //    if (names[i].ToLower() == "eddie")
        //    //    {
        //    //        break;
        //    //    }
        //    //    Console.WriteLine(names[i]);

        //    //}

        //    for (int i = 0; i < names.Length; i++)
        //    {
        //        if (names[i].ToLower() == "david")
        //        {
        //            names[i] = "Beckham";
        //        }
        //    }

        //    for (int i = 0; i < names.Length; i++)
        //    {
        //        Console.WriteLine(names[i]);
        //    }
        //}
    }
}
