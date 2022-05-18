using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertDataTypesTutorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                Second Challenge
             */

            int value1 = 12;
            decimal value2 = 6.2m;
            float value3 = 4.3f;

            int result1 = Convert.ToInt32((decimal)value1 / value2); // 2
            Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

            decimal result2 = value2 / (decimal)value3; // 1.4418604651162790697674418605
            Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

            float result3 = value3 / value1; // 0.3583333
            Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");
        }

        //static void Main(string[] args)
        //{
        //    /*
        //        First Challenge
        //        Business rules:
        //            1. If the value is alphanumeric, concatenate it to form a message.
        //            2. If the value is numeric, add it to total.
        //            3. Make sure the result matches the following output:
        //                Message: ABCDEF
        //                Total: 68.3
        //     */

        //    string[] values = { "12.3", "45", "ABC", "11", "DEF" };

        //    string message = "";
        //    decimal total = 0m;
        //    foreach (string value in values)
        //    {
        //        decimal number;
        //        if (decimal.TryParse(value, out number))
        //        {
        //            total += number;
        //        }
        //        else
        //        {
        //            message += value;
        //        }
        //    }

        //    // Print out the result
        //    Console.WriteLine($"Message: {message}");
        //    Console.WriteLine($"Total: {total}");
        //}

        //static void Main(string[] args)
        //{
        //    // Use the Parse() method
        //    //string name = "Bob";
        //    //Console.WriteLine(int.Parse(name)); // System.FormatException: Input string was not in a correct format.


        //    /*
        //        The TryParse() Method
        //        To avoid a format exception, use the TryParse() method on
        //        the target data type.

        //        The TryParse() method does several things simulteneously:
        //            1. It attempts to parse a string into the given numeric data type.
        //            2. If successful, it will store the converted value in an out parameter.
        //            3. It returns a bool to indicate whether the action succeeded or failed.
        //     */

        //    //string value = "102";
        //    string value = "bad";
        //    int result = 0;
        //    if (int.TryParse(value, out result))
        //    {
        //        Console.WriteLine($"Measurement: {result}");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Unable to report the measurement.");
        //    }

        //    if (result > 0)
        //    {
        //        Console.WriteLine($"Measurement (w / offset): {50 + result}");
        //    }

        //}

        //static void Main(string[] args)
        //{
        //    /*
        //        Performing Data Conversions
        //        There are three techniques you can use:
        //            1. Use a helper method on a variable.
        //            2. Use a helper method in the data type.
        //            3. Use the Convert class' methods.
        //     */

        //    /*
        //        Use ToString() to convert a number to a string
        //     */
        //    //int first = 5;
        //    //int second = 7;
        //    //string messsage = first.ToString() + second.ToString();
        //    //Console.WriteLine(messsage); // 57

        //    /*
        //        Explcitly converting a string to a number
        //        Most of the numeric data types have a Parse() method,
        //        which will convert a string into a given data type.

        //        In this case, we'll use the Parse() method to convert
        //        two strings into int values, then add them together.
        //     */
        //    //string first = "5";
        //    //string second = "7";
        //    //int sum = int.Parse(first) + int.Parse(second);
        //    //Console.WriteLine(sum); // 12

        //    //int i = int.Parse("hello"); // error at runtime

        //    /*
        //        Data Conversion using the Convert class
        //        The Convert class has many helper methods to convert
        //        a value from one type into another.
        //     */
        //    //string value1 = "5";
        //    //string value2 = "7";
        //    //int result = Convert.ToInt32(value1) * Convert.ToInt32(value2);
        //    //Console.WriteLine(result); // 35

        //    /*
        //        Casting versus Conversion
        //        The following example demonstrates what happens when you attempt to cast
        //        a decimal into an int.
        //     */
        //    int value = (int)1.5m; // casting truncates
        //    Console.WriteLine(value); // 1

        //    int value2 = Convert.ToInt32(1.5m); // converting rounds up
        //    Console.WriteLine(value2); // 2
        //}

        //static void Main(string[] args)
        //{

        //    /*
        //        Question 1: Is it possible, depending on the value,
        //        that attempting to change the value's data type would
        //        throw an exception at run time?
        //     */
        //    //int first = 2;
        //    //string second = "4";
        //    //int result = first + second; // Cannot implicitly convert type 'string' to 'int'
        //    //Console.WriteLine(result);

        //    /*
        //        Question 2: Is it possible, depeding on the value,
        //        that attempting to change the value's data type would
        //        result in a loss of information?
        //     */

        //    //int i = 10;
        //    //decimal d = i;
        //    //Console.WriteLine(d);

        //    //decimal d = 10.5m;
        //    //int i = (int) d;
        //    //Console.WriteLine(i);

        //    //decimal d = 1.23456789m;
        //    //float f = (float) d;
        //    //Console.WriteLine($"Decimal: {d}");
        //    //Console.WriteLine($"Float: {f}");
        //}
    }
}
