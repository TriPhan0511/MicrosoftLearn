using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluateBooleanExpressions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string permission = "Admin|Manager";
            //int level = 55;
            int level = 56;

            string welcomeMessage = "You do not have sufficient privileges.";

            string permissionToLower = permission.ToLower();
            if (permissionToLower.Contains("admin") )
            {
                if (level > 55)
                {
                    welcomeMessage = "Welcome, Super Admin user.";
                }
                else
                {
                    welcomeMessage = "Welcome, Admin user.";
                }
            }
            else if (permission.Contains("manager"))
            {
                if (level >= 20)
                {
                    welcomeMessage = "Contact an Admin for access.";
                }
            }

            Console.WriteLine(welcomeMessage);
        }

        //static void Main(string[] args)
        //{
        //    //string permission = "Admin";
        //    //int level = 56;
        //    //int level = 55;
        //    //int level = 10;

        //    //string permission = "Manager";
        //    ////int level = 21;
        //    ////int level = 20;
        //    //int level = 19;

        //    string permission = "User";
        //    int level = 100;

        //    string welcomeMessage = "You do not have sufficient privileges.";

        //    if (permission.ToLower().Contains("admin"))
        //    {
        //        if (level > 55)
        //        {
        //            welcomeMessage = "Welcome, Super Admin user.";
        //        }
        //        else
        //        {
        //            welcomeMessage = "Welcome, Admin user.";
        //        }
        //    }

        //    if (permission.ToLower().Contains("manager") && level >= 20)
        //    {
        //        welcomeMessage = "Contact an Admin for access.";
        //    }

        //    Console.WriteLine(welcomeMessage);
        //}

        //static void Main(string[] args)
        //{
        //    // Heads or tails challenge
        //    Random coin = new Random();
        //    string result = coin.Next(0, 2) == 0 ? "Heads" : "Tails";
        //    Console.WriteLine(result);
        //}

        //static void Main(string[] args)
        //{
        //    //decimal saleAmount = 1001.0m;
        //    ////decimal sale = 1050.0m;
        //    //decimal discount = saleAmount > 1000.0m ? 100.0m : 50.0m;
        //    //Console.WriteLine($"Your sale: {saleAmount}, discount: {discount}, total: {saleAmount - discount}");

        //    int saleAmount = 1001;
        //    Console.WriteLine($"Discount: {(saleAmount > 1000 ? 100 : 50)}");
        //}

        //static void Main(string[] args)
        //{
        //    //Console.WriteLine("a" == "a");
        //    //Console.WriteLine("a" == "a ");
        //    //Console.WriteLine("a" == "A");
        //    //Console.WriteLine(1 == 2);

        //    //string myValue = "a";
        //    //Console.WriteLine(myValue == "a");

        //    //string value1 = " a";
        //    //string value2 = "A ";
        //    //Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());

        //    //Console.WriteLine("a" != "a");
        //    //Console.WriteLine("a" != "A");
        //    //Console.WriteLine(1 != 2);

        //    //string myValue = "a";
        //    //Console.WriteLine(myValue != "a");

        //    //Console.WriteLine(1 > 2); // false
        //    //Console.WriteLine(1 < 2); // true
        //    //Console.WriteLine(1 >= 1); // true
        //    //Console.WriteLine(1 <= 1); // true

        //    //string pangram = "The quick brown fox jumps over the lazy dog.";
        //    //Console.WriteLine(pangram.Contains("fox")); // true
        //    //Console.WriteLine(pangram.Contains("Fox")); // false
        //    //Console.WriteLine(pangram.Contains("cow")); // false

        //    //string pangram = "The quick brown fox jumps over the lazy dog.";
        //    //Console.WriteLine(pangram.Contains("fox") == false); // false
        //    //Console.WriteLine(!pangram.Contains("fox")); // false

        //    string pangram = "The quick brown fox jumps over the lazy dog.";
        //    Console.WriteLine(!pangram.Contains("fox")); // false
        //    Console.WriteLine(!pangram.Contains("cow")); // true
        //}
    }
}
