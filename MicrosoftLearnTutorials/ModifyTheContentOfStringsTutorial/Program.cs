using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModifyTheContentOfStringsTutorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                Challenge
             
                In this challenge, you'll work with a string that contains fragment of HTML. You'll extract
                data from the HTML fragment, replace some of its content, and remove other parts of its
                content to achieve the desired output.

                const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";
                // Output:
                // Quantity: 5000
                // Output: <h2>Widgets &reg;</h2><span>5000</span>
                
             */

            const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

            string quantity = "";
            string output = "";

            // Your work here
            int openingPosition = 0;
            int closingPosition = 0;

            // Extract the quantity
            const string spanOpeningTag = "<span>";
            const string spanClosingTag = "</span>";
            openingPosition = input.IndexOf(spanOpeningTag);
            closingPosition = input.IndexOf(spanClosingTag);
            if ((openingPosition != -1) && (closingPosition != -1))
            {
                openingPosition += spanOpeningTag.Length;
                quantity = input.Substring(openingPosition, closingPosition - openingPosition);
            }

            // Remove the div tags
            const string divOpeningTag = "<div>";
            const string divClosingTag = "</div>";
            openingPosition = input.IndexOf(divOpeningTag);
            closingPosition = input.IndexOf(divClosingTag);
            if ((openingPosition != -1) && (closingPosition != -1))
            {
                openingPosition += divOpeningTag.Length;
                output = input.Substring(openingPosition, closingPosition - openingPosition);
            }

            // Replace the trademark symbol with the registered trademark symbol
            output = output.Replace("&trade;", "&reg;");

            // Print out
            Console.WriteLine(quantity);
            Console.WriteLine(output);

            // Output:
            // Quantity: 5000
            // Output: <h2>Widgets &reg;</h2><span>5000</span>
        }

        // -----------------------------------------------------------------------------------------------------------
        //static void Main(string[] args)
        //{
        //    /*
        //        Exercise - Use the Remove() and Replace() methods.

        //        In this exercise, we'll remove characters from a string using the Remove() method and
        //        replace characters using the Replace() method.
        //     */

        //    /*
        //        Step 1 - Write code to remove characters in specific location from a string

        //        You would typically use Remove() when there's a standard and consistent position of the
        //        characters you want to remove from the string.

        //        Sometimes, data stored in older files is fixed length, where character positions are allocated
        //        for certain fields of information. In this first step of our exercise, we have such fictitious
        //        record of information. The first 5 digits represent a customer identification number. The
        //        next 20 digits contain customer's name. The next 6 positions represent the customer latest
        //        invoice amount, and the last three positions represent the number of items ordered on that invoice.

        //        Perhaps we need to remove the customer's name to format the data so that it can be sent to
        //        a seperate process. Since we know the exact position and legth of the user's name, we can 
        //        easily remove it using the Remove() method.
        //     */

        //    //string data = "12345John Smith          5000  3  ";
        //    //string updatedData = data.Remove(5, 20);
        //    //Console.WriteLine(updatedData);
        //    //// Output: 123455000  3
        //    ///

        //    /*
        //        Step 2 - Write code to remove characters no matter where they appear in a string

        //        You would use the Replace() method when you must replace one or more characters with a
        //        different character (or no character). The Replace() method is different from the other
        //        methods we've used so far inasmuch as it will replace every instance of the given characters,
        //        not just the first or last instance.
        //     */

        //    string message = "This--is--ex-amp-le--da-ta";
        //    message = message.Replace("--", " ");
        //    message = message.Replace("-", "");
        //    Console.WriteLine(message);
        //    // Output: This is example data
        //}

        // -----------------------------------------------------------------------------------------------------------
        //static void Main(string[] args)
        //{
        //    //string message = "(What if) I have [different symbols] but every {open symbol} needs a [matching closing symbol]?";
        //    string message = "(What if) I have [different symbols] but every {open symbol} needs a [matching closing symbol?";

        //    char[] openingSymbols = { '(', '[', '{' };
        //    int closingPosition = 0;
        //    while (true)
        //    {

        //        int openingPosition = message.IndexOfAny(openingSymbols, closingPosition);
        //        if (openingPosition == -1)
        //        {
        //            break;
        //        }
        //        string foundOpeningSymbol = message.Substring(openingPosition, 1);
        //        char closingSymbol = ' ';
        //        switch (foundOpeningSymbol)
        //        {
        //            case "(":
        //                closingSymbol = ')';
        //                break;
        //            case "[":
        //                closingSymbol = ']';
        //                break;
        //            case "{":
        //                closingSymbol = '}';
        //                break;
        //        }
        //        openingPosition++;
        //        closingPosition = message.IndexOf(closingSymbol, openingPosition);
        //        if ((openingPosition != -1) && (closingPosition != -1))
        //        {
        //            int length = closingPosition - openingPosition;
        //            Console.WriteLine(message.Substring(openingPosition, length));
        //        }
        //        else
        //        {
        //            break;
        //        }
        //    }
        //}


        // -----------------------------------------------------------------------------------------------------------
        //static void Main(string[] args)
        //{
        //    /*
        //        Update the code example to work with different types of symbol sets

        //        This time, we'll update the message string adding different types of symbols 
        //        like square brackets and curly braces. We'll rely on IndexOfAny() to provide
        //        an array of characters representing the opening symbols. IndexOfAny() will 
        //        return us the first match it finds in the string.

        //        Once we find a symbol, we'll need to find its matching closing symbol. Once
        //        we do that, the rest should look similar. We'll use a different tatic instead
        //        of modifying the original value of message. This time, we'll use the closing
        //        position of the previous iteration as the opening position of the current iteration.
        //     */

        //    string message = "(What if) I have [different symbols] but every {open symbol} needs a [matching closing symbol]?";

        //    // The IndexOfAny() helper method requires a char array of characters.
        //    // We want to look for:
        //    char[] openSymbols = { '(', '[', '{' };

        //    // We'll use a slightly different techniquefor iterating through the characters in the string.
        //    // This time, we'll use the closing position of the previous iteration as the starting index
        //    // for the next open symbol. So, we need to initialize the closingPosition variable to zero:
        //    int closingPosition = 0;

        //    while (true)
        //    {
        //        int openingPosition = message.IndexOfAny(openSymbols, closingPosition);
        //        if (openingPosition == -1)
        //        {
        //            break;
        //        }
        //        string currentSymbol = message.Substring(openingPosition, 1);

        //        // Now we must find the matching closing symbol
        //        char matchingSymbol = ' ';
        //        switch (currentSymbol)
        //        {
        //            case "(":
        //                matchingSymbol = ')';
        //                break;
        //            case "[":
        //                matchingSymbol = ']';
        //                break;
        //            case "{":
        //                matchingSymbol = '}';
        //                break;
        //        }

        //        // To find the closingPosition, we use an overload of the IndexOf method to specify
        //        // that our search for the matchingSymbol should start at the openingPosition in the string.
        //        openingPosition++;
        //        closingPosition = message.IndexOf(matchingSymbol, openingPosition);

        //        int length = closingPosition - openingPosition;
        //        Console.WriteLine(message.Substring(openingPosition, length));

        //    }
        //}

        // -----------------------------------------------------------------------------------------------------------
        //static void Main(string[] args)
        //{
        //    /*
        //        Exercise - Use the string's IndexOf() and Substring() helper methods

        //        In this exercise, you'll use the IndexOf() method and its variants including IndexOfAny() and
        //        LastIndexOf() to locate the position of one character or string inside a larger string.

        //        Once we've located the position, we can use the Substring() method to return the rest of the 
        //        string after the position.

        //        Or we can use an overloaded version of the Substring() method to set the number of characters (length)
        //        to return after the position.
        //     */

        //    //// Step 1 - Write code to find an opening and closing parenthesis embedded in a string
        //    //string message = "Find what is (inside the parentheses)";

        //    //int openingPosition = message.IndexOf('('); // 13
        //    //int closingPosition = message.IndexOf(')'); // 36

        //    //Console.WriteLine(openingPosition);
        //    //Console.WriteLine(closingPosition);

        //    //// Step 2 - Add code to retrieve the value between two parenthesis characters
        //    //openingPosition += 1;
        //    //int length = closingPosition - openingPosition;
        //    //Console.WriteLine(message.Substring(openingPosition, length)); // inside the parentheses


        //    /*
        //        The following snippet of code shows how to find the value inside an opening and closing <span> tag.
        //     */

        //    //string message = "What is the value <span>between the tags</span>?";

        //    //const string openingSpan = "<span>";
        //    //const string closingSpan = "</span>";

        //    //int openingPosition = message.IndexOf(openingSpan); // 18
        //    //int closingPostion = message.IndexOf(closingSpan); // 40

        //    //openingPosition += openingSpan.Length;
        //    //int length = closingPostion - openingPosition;
        //    //Console.WriteLine(message.Substring(openingPosition, length)); // between the tags


        //    /*
        //        Write code to retrieve the last occurence of a sub string.
        //     */

        //    //string message = "(What if) I am (only interested) in the last (set of parentheses)?";

        //    //int openingPosition = message.LastIndexOf('(');
        //    //openingPosition += 1;
        //    //int closingPosition = message.LastIndexOf(')');
        //    //int length = closingPosition - openingPosition;
        //    //Console.WriteLine(message.Substring(openingPosition, length)); // set of parentheses


        //    /*
        //        Retrieve any value between one or more sets of parentheses in a string.
        //        Way 1:
        //     */

        //    //string message = "(What if) I am (only interested) in the last (set of parentheses)?";

        //    //int beginningPosition = 0;
        //    //while (beginningPosition != message.Length - 1)
        //    //{

        //    //    int openingPosition = message.IndexOf('(', beginningPosition);
        //    //    int closingPosition = message.IndexOf(")", beginningPosition);
        //    //    int length = closingPosition - openingPosition;
        //    //    Console.WriteLine($"openingPosition = {openingPosition} - closingPosition = {closingPosition} - length = {length} - beginningPostion = {beginningPosition}");
        //    //    Console.WriteLine(message.Substring(openingPosition + 1, length - 1));

        //    //    beginningPosition = closingPosition + 1;
        //    //}


        //    /*
        //        Retrieve any value between one or more sets of parentheses in a string.
        //        Way 2:
        //     */

        //    string message = "(What if) I am (only interested) in the last (set of parentheses)?";

        //    while (true)
        //    {
        //        int openingPosition = message.IndexOf('(');
        //        if (openingPosition == -1)
        //        {
        //            break;
        //        }
        //        openingPosition += 1;
        //        int closingPosition = message.IndexOf(')');
        //        int length = closingPosition - openingPosition;
        //        Console.WriteLine(message.Substring(openingPosition, length));

        //        // Note how we use the overload of the Substring() method to
        //        // return only the remaining unprocessed message:
        //        message = message.Substring(closingPosition + 1);
        //    }
        //}
    }
}
