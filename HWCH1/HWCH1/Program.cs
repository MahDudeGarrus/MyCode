using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWCH1to6
{
    class Program
    {

        int number = 530000000;
        int number2 = 530_000_000;


        static void Main(string[] args)
        {

         //This is a Chapter 2 overview. 

            //This will be an example for WriteLine.

            Console.WriteLine("This is my first string. I am starting to program is C#");

            Console.ReadKey();






         //This is a Chapter 3 overview.

            //This will be an example of Numeric Output

            Console.WriteLine(0123456789);

            Console.ReadKey();



            // This will be an example of Calculation.

            Console.WriteLine(90 + 110);

            Console.ReadKey();



            //This will be an example of more complex calculation.

            Console.WriteLine(199 + 7 * 3);

            Console.ReadKey();



            //This will be an example of text join.

            Console.WriteLine("I have started to program");

            Console.WriteLine("in C#.");

            Console.WriteLine("I have started to program" + " in C#");

            Console.ReadKey();



            //This will be an example of Special Characters

            Console.WriteLine("First Line \r\nSecond Line");

            Console.WriteLine("First Line" + Environment.NewLine + "Second Line");

            Console.WriteLine("The letter started so sweet: 'MyDarling'");

            Console.WriteLine("Here is Greek beta \u03b2");

            Console.WriteLine("A pathway to my desktop on my computer:" + " C:\\Users\\sasol\\Desktop");

            Console.ReadKey();



            //This an example of preformatted text.

            Console.WriteLine(@"

This is Stephanie's example of
preformatted text.
    I made an indentation here.
    I hope you can see it.
I messed this command up a few times.
It easy to screw this up.
");

            Console.ReadKey();



            //This will be making a string mixing text and numbers.

            Console.WriteLine("Senior Math Test \r\n================ \r\nOne and one is:");

            Console.WriteLine("a) " + 1 + 1);

            Console.WriteLine("b) " + (1 + 1));

            Console.WriteLine("c) " + "mostly fun");

            Console.ReadKey();
        }
    }
}

