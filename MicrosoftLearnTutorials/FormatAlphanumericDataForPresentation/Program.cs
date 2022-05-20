using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormatAlphanumericDataForPresentation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                Challenge

                // Output:
                Dear Mr. Jones,
                As a customer of our Magic Yield offering we are excited to tell you about a new financial product that would dramatically increase your return.

                Currently, you own 2,975,000.00 shares at a return of 12.75 %.

                Our new product, Glorious Future offers a return of 13.13 %. Given your current volume, your potential profit would be ¤63,000,000.00.

                Here's a quick comparison:

                Magic Yield         12.75 %   ¤55,000,000.00      
                Glorious Future     13.13 %   ¤63,000,000.00


             */

            string customerName = "Mr. Jones";

            string currentProduct = "Magic Yield";
            int currentShares = 2975000;
            decimal currentReturn = 0.1275m;
            decimal currentProfit = 55000000.0m;

            string newProduct = "Glorious Future";
            decimal newReturn = 0.13125m;
            decimal newProfit = 63000000.0m;

            // Your logic here
            string message =
                $"Dear {customerName}\n" +
                $"As a customer of our {currentProduct} offering we are excited to tell you about " +
                $"a new financial product that would dramatically increase your return.\n\n" +
                $"Currently, you own {currentShares:N2} shares at a return of {currentReturn:P2}.\n\n" +
                $"Our new product, {newProduct} offers a return of {newReturn:P2}. Given your current volume, your potential profit would be {newProfit:C2}.\n";
            Console.WriteLine(message);

            Console.WriteLine("Here's a quick comparison:\n");
            // Your logic here
            string comparisonMesssage = "";
            comparisonMesssage += currentProduct.PadRight(20);
            comparisonMesssage += $"{currentReturn:P2}".PadRight(10);
            comparisonMesssage += $"{currentProfit:C2}".PadLeft(10);
            comparisonMesssage += "\n";
            comparisonMesssage += newProduct.PadRight(20);
            comparisonMesssage += $"{newReturn:P2}".PadRight(10);
            comparisonMesssage += $"{newProfit:C2}".PadLeft(10);
            Console.WriteLine(comparisonMesssage);
        }

        ////-----------------------------------------------------------------------------------------------
        //static void Main(string[] args)
        //{
        //    /*
        //        Exercise - Working with padded strings
        //     */

        //    string paymentID = "769";
        //    string payeeName = "Mr. Stephen Ortega";
        //    //string paymentAmount = "$5,000.00";
        //    decimal amount = 5000m;
        //    string paymentAmount = $"{amount:C}";


        //    var formattedLine = paymentID.PadRight(6);
        //    formattedLine += payeeName.PadRight(24);
        //    formattedLine += paymentAmount.PadLeft(10);

        //    Console.WriteLine("1234567890123456789012345678901234567890");
        //    Console.WriteLine(formattedLine);
        //}

        ////-----------------------------------------------------------------------------------------------
        //static void Main(string[] args)
        //{
        //    /*
        //        Exercise - padding and alignment

        //        Formatting strings by adding whitespace before and after
        //        The PadLeft() method will add blank spaces to the left-hand side of the string
        //        so that the total number of characters equals the argument you send it.

        //        In this case, we want to total length of the string to be 12 characters.
        //     */

        //    string input = "Pad this";
        //    Console.WriteLine(input.PadLeft(12));
        //    //    Pad this

        //    Console.Write(input.PadRight(12));
        //    Console.WriteLine("hello");
        //    //Pad this    hello

        //    Console.WriteLine(input.PadLeft(12, '-'));
        //    //----Pad this
        //}

        //static void Main(string[] args)
        //{
        //    /*
        //        Exercise - string interpolation
        //     */

        //    int invoiceNumber = 1201;
        //    decimal productMeasurement = 25.4568m;
        //    decimal subtotal = 2750.00m;
        //    decimal taxPercentage = .15825m;
        //    decimal total = 3185.19m;

        //    Console.WriteLine($"Invoice Number: {invoiceNumber}"); // 1201
        //    Console.WriteLine($"    Measurement: {productMeasurement:N3}"); //  25.457
        //    Console.WriteLine($"    Sub Total: {subtotal:C}"); //  $2,750.00
        //    Console.WriteLine($"    Tax: {taxPercentage:P}"); //  15.83%
        //    Console.WriteLine($"    Total Due: {total:C}");

        //    // Output:
        //    /*
        //        Invoice Number: 1201
        //            Measurement: 25.457
        //            Sub Total: $2,750.00
        //            Tax: 15.83%
        //            Total Due: $3,185.19
        //     */
        //}

        //static void Main(string[] args)
        //{
        //    /*
        //        Composite Formating
        //     */

        //    //string first = "Hello";
        //    //string second = "World";
        //    ////string result = string.Format("{0} {1}!", first, second); // Hello World!
        //    ////Console.WriteLine(result);
        //    //Console.WriteLine(string.Format("{1} {0}", first, second)); // World Hello
        //    //Console.WriteLine(string.Format("{0} {0} {0}", first, second)); // Hello Hello Hello

        //    /*
        //        String Interpolation
        //     */

        //    //string first = "Hello";
        //    //string second = "World";
        //    //Console.WriteLine($"{first} {second}!"); // Hello World!
        //    //Console.WriteLine($"{second} {first}"); // World Hello
        //    //Console.WriteLine($"{first} {first} {first}"); // Hello Hello Hello

        //    /*
        //        Formatting Currency
        //        Composite formatting and string interpolation can be used to format values for
        //        display given a specific languae and culture.

        //        In the following example, the :C currency format specifier is used to present
        //        the price and discount variables as currency.
        //     */

        //    //decimal price = 123.45m;
        //    //int discount = 50;
        //    //Console.WriteLine($"Price: {price:C}, (Save {discount:C})"); // Price: $123.45, (Save $50.00)

        //    /*
        //        Formatting Numbers
        //        When working with numeric data, you may want to format the number for readability by
        //        including commas to dilineate thousands, millions, billions, and so on.
        //        The N numeric format specifier will do this.
        //     */

        //    //decimal measurement = 123456.78912m;
        //    //Console.WriteLine($"Measurement: {measurement:N} units"); // Measurement: 123,456.79 units

        //    /*
        //        Note: By default, the N numeric format specifier displays only two digits after the decimal point.
        //        If you want to display more precision, you can do that by adding a number after the specifier.

        //        The following example will display four digits after the decimal point using the N4 specifier.
        //     */

        //    //decimal measurement = 123456.78912m;
        //    //Console.WriteLine($"Measument: {measurement:N4} units"); // Measument: 123,456.7891 units

        //    /*
        //        Formatting Percentages
        //        Use P format specifier to format percentages. Add a number afterwards to control the
        //        number of values displayed after the decimal point.
        //     */

        //    decimal tax = .36785m;
        //    Console.WriteLine($"Tax rate: {tax:P2}"); // Tax rate: 36.79%
        //    tax += 0.1m;
        //    Console.WriteLine($"Tax rate: {tax:P2}"); // Tax rate: 36.79%
        //}
    }
}
