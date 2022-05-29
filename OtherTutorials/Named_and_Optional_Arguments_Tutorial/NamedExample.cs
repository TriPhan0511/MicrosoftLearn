using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Named_and_Optional_Arguments_Tutorial
{
    internal class NamedExample
    {
        /*
            This sample demonstrates Named arguments.

            Named arguments enable you to specify an argument for a parameter
            by matching the argument with its name rather than with its positions
            in the parameter list.
         */
        //public static void Main(string[] strings)
        //{
        //    // The method can be called in the normal way, by using positional arguments.
        //    PrintOrderDetails("Gift Shop", 31, "Red Mug");

        //    // Named arguments can be supplied for the parameters in any order.
        //    PrintOrderDetails(orderNum: 31, productName: "Red Mug", sellerName: "Gift Shop");
        //    PrintOrderDetails(productName: "Red Mug", sellerName: "Gift Shop", orderNum: 31);

        //    // Named arguments mixed with positional arguments are valid
        //    // as long as they are used in their correct position.
        //    PrintOrderDetails("Gift Shop", 31, productName: "Red Mug");
        //    PrintOrderDetails(sellerName: "Gift Shop", 31, productName: "Red Mug"); // C# 7.2 onwards
        //    PrintOrderDetails("Gift Shop", orderNum: 31, "Red Mug"); // C# 7.2 onwards

        //    // Howeve, mixed arguments are invalid if used out-of-order
        //    // The following statements will cause a compile error.
        //    //PrintOrderDetails(productName: "Red Mug", 31, "Gift Shop");
        //    //PrintOrderDetails(31, sellerName: "Gift Shop", productName: "Red Mug");
        //    //PrintOrderDetails(31, "Red Mug", sellerName: "Gift Shop");
        //}

        //static void PrintOrderDetails(string sellerName, int orderNum, string productName)
        //{
        //    if (string.IsNullOrWhiteSpace(sellerName))
        //    {
        //        throw new ArgumentException(message: "Seller name can not be null or empty.",
        //            paramName: nameof(sellerName));
        //    }

        //    Console.WriteLine($"Seller: {sellerName}, Order #:{orderNum}, Product: {productName}");
        //}
    }
}
