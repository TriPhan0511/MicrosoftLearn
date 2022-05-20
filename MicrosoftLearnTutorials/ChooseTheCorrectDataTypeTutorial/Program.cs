using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChooseTheCorrectDataTypeTutorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                Exercise - Reference types

                Reference type include arrays, classes, and strings. Reference types are treated differently
                from value types with regards to the way values are stored when the application executing.
             */

            /*
                How reference types are different from value tpyes

                A value type variable will store its value directly in an area of storage call the stack.
                The stack is memory allocated to the code that is currently running on the CPU (also known
                as stack frame, or activation frame). When the stack frame has finished executing, the values
                in the stack are removed.

                A reference type variable will store its values in a seperate memory region called the heap.
                The heap is a memory area that is shared across many applications running on the operating
                system at the same time. The .NET Runtime communicates with the operating system to determine
                what memory addresses are available, and requests an address where it can store the value.
                The .NET Runtime stores the value, and the return the memory address to the variable.
                When the code uses the variable, the .NET Runtime seamlessly looks up the address stored
                in the variable, and retrieve the value that's stored there.
             */

            //int[] data;
            //data = new int[3];

            //int[] data = new int[3];

            Console.WriteLine(int.MaxValue);
        }

        ////------------------------------------------------------------------------------------------------------------------------
        //static void Main(string[] args)
        //{
        //    /*
        //        Exercise - Floating-point types

        //        A floating-point is a simple value type that represents fractional numbers
        //        Unlike integral numbers, there are other considerations beyond the maximum
        //        and minimum values you can store in a given floating-point type.
        //     */

        //    // Use the MinValue and MaxValue properties for each signed float type
        //    Console.WriteLine("Floating point types:");
        //    Console.WriteLine($"float   : {float.MinValue} to {float.MaxValue} (with ~6-9 digits of precision)");
        //    Console.WriteLine($"double  : {double.MinValue} to {double.MaxValue} (with ~15-17 digits of precision)");
        //    Console.WriteLine($"decimal : {decimal.MinValue} to {decimal.MaxValue} (with ~28-29 digits of precision)");

        //    // Output:
        //    //Floating point types:
        //    //float   : -3.402823E+38 to 3.402823E+38
        //    //double  : -1.79769313486232E+308 to 1.79769313486232E+308
        //    //decimal : -79228162514264337593543950335 to 79228162514264337593543950335
        //}

        ////------------------------------------------------------------------------------------------------------------------------
        //static void Main(string[] args)
        //{
        //    /*
        //        Exercise - Integral Types

        //        An integral type is a simple value type that represents whole numbers (non-fractional).
        //        The most popular in this category is the int data type.

        //        There are two subcategories of integral type: signed nad unsigned integral types.
        //     */

        //    /*
        //        Signed integral types

        //        A signed type uses its bytes to represent an equal number of positive and negative numbers.
        //     */

        //    //// Use the MinValue and MaxValue properties for each signed inregral type.
        //    //Console.WriteLine("Signed integral types:");

        //    //Console.WriteLine($"sbyte   : {sbyte.MinValue} to {sbyte.MaxValue}"); 
        //    //Console.WriteLine($"short   : {short.MinValue} to {short.MaxValue}");
        //    //Console.WriteLine($"int     : {int.MinValue} to {int.MaxValue}");
        //    //Console.WriteLine($"long    : {long.MinValue} to {int.MaxValue}");

        //    //// Output:
        //    ////Signed integral types:
        //    ////sbyte   : -128 to 127
        //    ////short   : -32768 to 32767
        //    ////int     : -2147483648 to 2147483647
        //    ////long    : -9223372036854775808 to 2147483647
        //    ///

        //    /*
        //        Unsigned integral type

        //        An unsigned integral type uses its bytes to represent only positive numbers.
        //     */

        //    // Use the MinValue and MaxValue properties for each unsigned integral type.
        //    Console.WriteLine("Unsigned integral types:");

        //    Console.WriteLine($"byte    : {byte.MinValue} to {byte.MaxValue}");
        //    Console.WriteLine($"ushort  : {ushort.MinValue} to {ushort.MaxValue}");
        //    Console.WriteLine($"uint    : {uint.MinValue} to {uint.MaxValue}");
        //    Console.WriteLine($"ulong   : {ulong.MinValue} to {ulong.MaxValue}");

        //    // Output:
        //    //Unsigned integral types:
        //    //byte    : 0 to 255
        //    //ushort  : 0 to 65535
        //    //uint    : 0 to 4294967295
        //    //ulong   : 0 to 18446744073709551615
        //}
    }
}
