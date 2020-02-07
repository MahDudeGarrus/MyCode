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



            //This is an example of preformatted text.

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




         //This is a Chapter 4 overview

            //This will be an example of Storing Text.

            string message;

            message = "All we are";

            string anothermessage = "is dust in the wind";

            Console.WriteLine(message);
            Console.ReadKey();

            Console.WriteLine(anothermessage);
            Console.ReadKey();


            // This is an example of Storing Numbers.

            int number = 9000;

            Console.WriteLine("It is over " + number  + "!!");

            Console.ReadKey();


            //This is an example of storing a sum.

            int sum = 1 + 1;

            Console.WriteLine(@"
Answer to Senior Math Test
==========================

One and one is: " + sum);

            Console.ReadKey();


            //This is an example of Calculating with Variables.

            int firstNumber = 500;
            int secondNumber = 500;

            int sum1 = firstNumber + secondNumber;

            Console.WriteLine("I would walk " + firstNumber + " miles");
            Console.ReadKey();

            Console.WriteLine("And I would walk " + secondNumber + " more");
            Console.ReadKey();

            Console.WriteLine("Just to be that man who walks a " + sum1 + " miles \r\nTo fall down at your door");
            Console.ReadKey();


            //This is an example of Grand Combination.

            string superhero1 = "WonderWoman";
            string superhero2 = "Hawkgirl";
            int battleswon1 = 8;
            int battleswon2 = 12;

            Console.WriteLine("DC War results " + "\r\n" + superhero1 + " - " + superhero2);
            Console.WriteLine("Number of battles won:" + "\r\n" + battleswon1 + " - " + battleswon2) ;

            Console.ReadKey();


            //This is an example of Decimal numbers

            double piApproximately = 3.14;
            double piMorePrecisely = Math.PI;
            double notCompletelyOne = 0.9999999999;

            Console.WriteLine("This is approximately Pi set by our code: " + piApproximately);
            Console.WriteLine("This is the value of Pi set by C#: " + piMorePrecisely);
            Console.WriteLine("This should not be a whole number:" + notCompletelyOne);

            Console.ReadKey();


            //This is an example of Logical values

            bool worksucks = true;
            bool idontknow = false;
            bool iknow = !idontknow;

            Console.WriteLine("Work sucks: " + worksucks);
            Console.ReadKey();

            Console.WriteLine("I don't know: " + idontknow);
            Console.ReadKey();

            Console.WriteLine("I know : " + iknow);
            Console.ReadKey();




         // This is a Chapter 5 overview.


            //This will be an example of What Time is it?

            DateTime now;

            now = DateTime.Now;

            Console.WriteLine("I think it is " + now);

            Console.ReadKey();



            // This will be an example of What Date is Today?
            // Is there a way to remove the time after the date is stated?
            // Nevermind the next lesson explains it all.
            // Double negate that. It still shows the time at 12:00:00 AM in next lesson too.

            DateTime today;

            today = DateTime.Today;

            Console.WriteLine("Today is " + today);

            Console.ReadKey();



            // This will be an example of Date Components.

            DateTime now1 = DateTime.Now;

            int day = now1.Day;
            int month = now1.Month;
            int year = now1.Year;
            int hours = now1.Hour;
            int minutes = now1.Minute;
            int seconds = now1.Second;
            DateTime justDateWithoutTime = now1.Date;

            Console.WriteLine("Day: " + day);
            Console.WriteLine("Month: " + month);
            Console.WriteLine("Year: " + year);
            Console.WriteLine("Hours: " + hours);
            Console.WriteLine("Minutes: " + minutes);
            Console.WriteLine("Seconds: " + seconds);
            Console.WriteLine("Date component: " + justDateWithoutTime);

            Console.ReadKey();

            Console.WriteLine("Our output: " + year + ", " + month + "/" + day + " " + hours + " hours " + minutes + " minutes");

            Console.ReadKey();



            // This is an example of Environment Object.

            Console.WriteLine("Device Name: " + Environment.MachineName);
            Console.WriteLine("64-bit system: " + Environment.Is64BitOperatingSystem);
            Console.WriteLine("Username: " + Environment.UserName);

            Console.ReadKey();



        }
    }
}

