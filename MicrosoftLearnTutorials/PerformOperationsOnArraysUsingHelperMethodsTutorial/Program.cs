using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerformOperationsOnArraysUsingHelperMethodsTutorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                Second Challenge
                string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
                Output:
                    B123
                    B177
                    B179
             */

            string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";

            // Get an array of ids
            string[] orderIDs = orderStream.Split(',');
            
            // Find the size for new array
            int size = 0;
            foreach (var item in orderIDs)
            {
                if (item.ToLower().StartsWith("b"))
                {
                    size++;
                }
            }
            string[] ordersStartWithB = new string[size];

            int index = 0;
            for (int i = 0; i < orderIDs.Length; i++)
            {
                if (orderIDs[i].ToLower().StartsWith("b"))
                {
                    ordersStartWithB[index] = orderIDs[i];
                    index++;
                }
            }

            foreach (var item in ordersStartWithB)
            {
                Console.WriteLine(item);
            }
        }

        ////---------------------------------------------------------------------------------------------
        //static void Main(string[] args)
        //{
        //    string pangram = "The quick brown fox jumps over the lazy dog";
        //    string result = ReverseASentence(pangram);
        //    Console.WriteLine(result);
        //}

        //private static string ReverseASentence(string sentence)
        //{
        //    string[] words = sentence.Split(' ');
        //    string[] reversedWords = new string[words.Length];
        //    for (int i = 0; i < words.Length; i++)
        //    {
        //        char[] letters = words[i].ToCharArray();
        //        Array.Reverse(letters);
        //        reversedWords[i] = new string(letters);
        //    }
        //    return String.Join(" ", reversedWords);
        //}

        //static void Main(string[] args)
        //{
        //    /*
        //        First challenge: Word reversal challenge
        //        string pangram = "The quick brown fox jumps over the lazy dog";
        //        Output: ehT kciuq nworb xof spmuj revo eht yzal god
        //     */

        //    string pangram = "The quick brown fox jumps over the lazy dog";

        //    string[] words = pangram.Split(' ');
        //    string[] reversedWords = new string[words.Length];

        //    for (int i = 0; i < words.Length; i++)
        //    {
        //        char[] letters = words[i].ToCharArray();
        //        Array.Reverse(letters);
        //        reversedWords[i] = new string(letters);
        //    }

        //    string result = string.Join(" ", reversedWords);
        //    Console.WriteLine(result);

        //}

        //static void Main(string[] args)
        //{
        //    /*
        //        First challenge: Word reversal challenge
        //        string pangram = "The quick brown fox jumps over the lazy dog";
        //        Output: ehT kciuq nworb xof spmuj revo eht yzal god
        //     */

        //    string pangram = "The quick brown fox jumps over the lazy dog";

        //    StringBuilder stringBuilder = new StringBuilder();

        //    string[] words = pangram.Split(' ');

        //    for (int i = 0; i < words.Length; i++)
        //    {
        //        char[] letters = words[i].ToCharArray();
        //        Array.Reverse(letters);
        //        string reversedWord = new string(letters);
        //        if (i == words.Length - 1)
        //        {
        //            stringBuilder.Append(reversedWord);
        //        }
        //        else
        //        {
        //            stringBuilder.Append($"{reversedWord} ");
        //        }
        //    }

        //    // Print out the result
        //    Console.WriteLine(stringBuilder.ToString());    

        //}

        ////---------------------------------------------------------------------------------------------
        //static void Main(string[] args)
        //{
        //    // Create a string
        //    string value = "abc123";

        //    // Convert that string into a char array
        //    char[] chars = value.ToCharArray();

        //    // Reverse the char array
        //    Array.Reverse(chars);

        //    //// Create a new string from the char array
        //    //string newValue = new string(chars); // -> 321cba

        //    // Create a new string using string.Join() method
        //    string newValue = string.Join(",", chars); // -> 3,2,1,c,b,a

        //    // Create a string array from the existing string
        //    string[] strings = newValue.Split(',');
        //    foreach (var item in strings)
        //    {
        //        Console.WriteLine(item);
        //    }
        //    // Output:
        //    /*
        //        3
        //        2
        //        1
        //        c
        //        b
        //        a
        //     */
        //}

        ////---------------------------------------------------------------------------------------------
        //static void Main(string[] args)
        //{
        //    /*
        //        Split() and Join()
        //     */

        //    /*
        //        string data type's Array methods
        //        The variables of type string have many built-in methods that
        //        convert a single string into either an array of snaller strings,
        //        or an array of individual characters.
        //     */

        //    // Step 1 - Use the ToCharArray() to create an array of characters
        //    string value = "abc123";
        //    char[] valueArray = value.ToCharArray();

        //    //// Step 2 - Reverse, then combine the char array into a new string
        //    //Array.Reverse(valueArray);
        //    //string result = new string(valueArray); // 321cba
        //    //Console.WriteLine(result);

        //    // Step 3 - Combine all of the chars into a new comma-seperated-value string
        //    //          using Join
        //    Array.Reverse(valueArray);
        //    string result = String.Join(",", valueArray); // 3,2,1,c,b,a
        //    //Console.WriteLine(result);

        //    // Step 4 - Split the new comma-seperated-value string into an array of strings
        //    string[] items = result.Split(',');
        //    foreach (var item in items)
        //    {
        //        Console.WriteLine(item);
        //    }
        //    // Output:
        //    /*
        //        3
        //        2
        //        1
        //        c
        //        b
        //        a
        //     */
        //}

        ////---------------------------------------------------------------------------------------------
        //static void Main(string[] args)
        //{
        //    // Create an array of strings
        //    string[] pallets = { "B14", "A11", "B12", "A13", "C01", "C02" };
        //    // Clear two elements
        //    Array.Clear(pallets, 1, 3);

        //    // Get size for new array
        //    int size = 0;
        //    foreach (var item in pallets)
        //    {
        //        if (item != null)
        //        {
        //            size++;
        //        }
        //    }
        //    // Create a new array containing not null elements
        //    string[] pallets2 = new string[size];
        //    int index = 0;
        //    foreach (var item in pallets)
        //    {
        //        if (item != null)
        //        {
        //            pallets2[index] = item;
        //            index++;
        //        }
        //    }

        //    // Print out two arrays
        //    Console.WriteLine("Paletes");
        //    foreach (var item in pallets)
        //    {
        //        Console.WriteLine($"-- {item}");
        //    }
        //    Console.WriteLine();

        //    Console.WriteLine("Paletes2");
        //    foreach (var item in pallets2)
        //    {
        //        Console.WriteLine($"-- {item}");
        //    }
        //}
        ////---------------------------------------------------------------------------------------------

        //static void Main(string[] args)
        //{
        //    /*
        //        Clear() and Resize()
        //        1. The Array.Clear() method allow us to remove the content 
        //            of specific elements in our array.
        //        2. The Array.Resize() method adds or removes elements from our array.
        //     */

        //    //// 1. Create an array of strings
        //    //string[] pallets = { "B14", "A11", "B12", "A13" };

        //    //Console.WriteLine($"Before: {pallets[0].ToLower()}");

        //    //// Clear items from the array
        //    //Array.Clear(pallets, 0, 2);

        //    //if (pallets[0] != null)
        //    //{
        //    //    Console.WriteLine($"After: {pallets[0].ToLower()}");
        //    //}

        //    //Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
        //    //foreach (var item in pallets)
        //    //{
        //    //    Console.WriteLine($"-- {item}");
        //    //}

        //    //// Output:
        //    ///*
        //    //    Clearing 2 ... count: 4
        //    //    --
        //    //    --
        //    //    -- B12
        //    //    -- A13
        //    // */

        //    //// 2. Resize the array to add more elements
        //    //string[] pallets = { "B14", "A11", "B12", "A13" };

        //    //Array.Clear(pallets, 0, 2);
        //    //Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
        //    //foreach (var item in pallets)
        //    //{
        //    //    Console.WriteLine($"-- {item}");
        //    //}
        //    //Console.WriteLine();

        //    //Array.Resize(ref pallets, 6);
        //    //Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

        //    //pallets[4] = "C01";
        //    //pallets[5] = "C02";

        //    //foreach (var item in pallets)
        //    //{
        //    //    Console.WriteLine($"-- {item}");
        //    //}

        //    //// Ouput:
        //    ///*
        //    //    Clearing 2 ... count: 4
        //    //    --
        //    //    --
        //    //    -- B12
        //    //    -- A13

        //    //    Resizing 6 ... count: 6
        //    //    --
        //    //    --
        //    //    -- B12
        //    //    -- A13
        //    //    -- C01
        //    //    -- C02 
        //    // */

        //    // 3. Resize the array to remove elements
        //    string[] pallets = { "B14", "A11", "B12", "A13" };

        //    Array.Clear(pallets, 0, 2);
        //    Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
        //    foreach (var item in pallets)
        //    {
        //        Console.WriteLine($"-- {item}");
        //    }
        //    Console.WriteLine();

        //    Array.Resize(ref pallets, 6);
        //    Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");
        //    pallets[4] = "C01";
        //    pallets[5] = "C02";
        //    foreach (var item in pallets)
        //    {
        //        Console.WriteLine($"-- {item}");
        //    }
        //    Console.WriteLine();

        //    Array.Resize(ref pallets, 3);
        //    Console.WriteLine($"Resizing 3 ... count: {pallets.Length}");
        //    foreach (var item in pallets)
        //    {
        //        Console.WriteLine($"-- {item}");
        //    }

        //    // Output:
        //    /*
        //        Clearing 2 ... count: 4
        //        --
        //        --
        //        -- B12
        //        -- A13

        //        Resizing 6 ... count: 6
        //        --
        //        --
        //        -- B12
        //        -- A13
        //        -- C01
        //        -- C02

        //        Resizing 3 ... count: 3
        //        --
        //        --
        //        -- B12
        //     */
        //}
        ////---------------------------------------------------------------------------------------------


        //static void Main(string[] args)
        //{
        //    /*
        //        Use array methods to sort elements in an array.
        //     */

        //    // Create an array of pallets, then sort them
        //    string[] pallets = { "B14", "A11", "B12", "A13" };

        //    Console.WriteLine("Sorted...");
        //    Array.Sort(pallets);
        //    foreach (var item in pallets)
        //    {
        //        Console.WriteLine($"-- {item} ");
        //    }
        //    Console.WriteLine();

        //    // Reverse the order of the pallets
        //    Array.Reverse(pallets);
        //    Console.WriteLine("Reversed...");
        //    foreach (var item in pallets)
        //    {
        //        Console.WriteLine($"-- {item} ");
        //    }

        //    // Output:
        //    /*
        //        Sorted...
        //        -- A11
        //        -- A13
        //        -- B12
        //        -- B14

        //        Reversed...
        //        -- B14
        //        -- B12
        //        -- A13
        //        -- A11
        //     */
        //}
    }
}
