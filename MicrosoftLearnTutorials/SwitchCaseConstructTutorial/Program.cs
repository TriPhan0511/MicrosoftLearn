using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCaseConstructTutorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // SKU: Stock Keeping Unit
            string sku = "01-MN-L";
            string skuLongForm = GenerateSkuLongForm(sku);
            Console.WriteLine($"Product: {skuLongForm}");
        }

        private static string GenerateSkuLongForm(string sku)
        {
            string[] product = sku.Split('-');

            string type = "";
            string color = "";
            string size = "";

            switch (product[0])
            {
                case "01":
                    type = "Sweat shirt";
                    break;
                case "02":
                    type = "T-Shirt";
                    break;
                case "03":
                    type = "Sweat pants";
                    break;
                default:
                    type = "Other";
                    break;
            }

            switch (product[1])
            {
                case "BL":
                    color = "Black";
                    break;
                case "MN":
                    color = "Maroon";
                    break;
                default:
                    color = "White";
                    break;
            }

            switch (product[2])
            {
                case "S":
                    size = "Small";
                    break;
                case "M":
                    size = "Medium";
                    break;
                case "L":
                    size = "Large";
                    break;
                default:
                    size = "One Size Fits All";
                    break;
            }

            return $"{size} {color} {type}";
        }

        static void Main_0(string[] args)
        {
            // SKU = Stock Keeping Unit
            string sku = "01-MN-L";
            string[] product = sku.Split('-');
            string type = "";
            string color = "";
            string size = "";

            if (product[0] == "01")
            {
                type = "Sweat shirt";
            }
            else if (product[0] == "02")
            {
                type = "T-Shirt";
            }
            else if (product[0] == "03")
            {
                type = "Sweat pans";
            }
            else
            {
                type = "Other";
            }

            if (product[1] == "BL")
            {
                color = "Black";
            }
            else if (product[1] == "MN")
            {
                color = "Maroon";
            }
            else
            {
                color = "White";
            }

            if (product[2] == "S")
            {
                size = "Small";
            }
            else if (product[2] == "M")
            {
                size = "Medium";
            }
            else if (product[2] == "L")
            {
                size = "Large";
            }
            else
            {
                size = "One Size Fits All";
            }

            string skuLongForm = $"{size} {color} {type}";
            Console.WriteLine($"Product: {skuLongForm}");
        }

        //static void Main(string[] args)
        //{
        //    //int employeeLevel = 200;
        //    //int employeeLevel = 201;
        //    //int employeeLevel = 100;
        //    //int employeeLevel = 200;
        //    int employeeLevel = 101;
        //    string employeeName = "John Smith";
        //    string title = "";

        //    switch (employeeLevel)
        //    {
        //        case 100:
        //            //title = "Junior Associate";
        //            //break;
        //        case 200:
        //            title = "Senior Associate";
        //            break;
        //        case 300:
        //            title = "Manager";
        //            break;
        //        case 400:
        //            title = "Senior Manager";
        //            break;
        //        default:
        //            title = "Associate";
        //            break;
        //    }

        //    Console.WriteLine($"{employeeName}, {title}");
        //}
    }
}
