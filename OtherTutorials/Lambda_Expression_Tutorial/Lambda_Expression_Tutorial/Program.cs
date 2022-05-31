using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_Expression_Tutorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                Lambda expressions

                You use a lambda expression to create an anonymous function.
                Use the lambda declaration operator => to sepearate the
                lambda's parameter list from it's body.
                
                A lambda expression can be any of the following two forms:
                    
                    1. Expression lambda that has an expression as its body:
                        (input-parameters) => expression

                    2. Statement lambda that has a statement block as its body:
                        (input-parameters) => { <sequence-of-statements> }

                To create a lambda expression, you specify input parameters (if any)
                on the left side of the lambda operator and an expression or a 
                statement block on the other side.
                
             */

            //// A lambda expression that has one parameter and returns a value
            //// can be converted to a Func<T,TResult> delegate.
            //// In the following example, the lambda expression x => x * x, which specifies
            //// a parameter that's named x and returns the value of x squared, is assigned
            //// to a variable of a delegate type:
            //Func<int, int> square = x => x * x;
            //Console.WriteLine(square(5)); // output: 25

            // Another example:
            int[] numbers = { 2, 3, 4, 5 };
            var squaredNumbers = numbers.Select(x => x * x);
            Console.WriteLine(String.Join(" ", squaredNumbers)); // Output: 4 9 16 25

        }

        ////-----------------------------------------------------------------------------------
        //static void Main(string[] args)
        //{
        //    /*
        //        The => token is supported in two forms: as the lambda operator and
        //        as a separator of a member name and the member implementation in 
        //        an expression body definition.
        //     */

        //    /*
        //        1. Lambda operator

        //        In lambda expressions, the lambda operator => seperates the input parameters
        //        on the left side from the lambda body on the right side.
        //     */
        //    //string[] words = { "bot", "apple", "apricot" };
        //    //int minimalLength = words
        //    //    .Where(w => w.StartsWith("a"))
        //    //    .Min(w => w.Length);
        //    //Console.WriteLine(minimalLength); // output: 5

        //    //int[] numbers = { 4, 7, 10 };
        //    //int product = numbers.Aggregate(1, (iterim, next) => iterim * next);
        //    //Console.WriteLine(product); // output: 280

        //    //product = numbers.Aggregate(0, (iterim, next) => iterim + next);
        //    //Console.WriteLine(product); // output: 21

        //    //// The following example shows how to define a lambda expression
        //    //// without input parameters.
        //    //Func<string> greet = () => "Hello, world!";
        //    //Console.WriteLine(greet()); // output: Hello, world!

        //    /*
        //        2. Expression body definition

        //        An expression body definition has the following general syntax:
        //            member => expression;
        //        where expression is a valid expression. The return type of expression
        //        must be implicitly convertible to the member's return type
        //     */

        //    // The following example shows an expression body definition
        //    // for a Person.ToString() method:
        //    //public override string ToString() => $"{fname} {lname}".Trim();

        //    // It's a shorthand version of the following method definition:
        //    //public override string ToString()
        //    //{
        //    //    return $"{fname} {lname}".Trim();
        //    //}
        //}
    }
}
