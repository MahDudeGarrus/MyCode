using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            bool continuerunning = true;

            do
            {



                Console.WriteLine("Make a choice between 1 and 3");

                int choice = int.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    UserLoop();
                }

                if (choice == 2)
                {
                    RandomLoop();

                }

                if (choice == 3)
                {
                    Console.WriteLine("Under Maintanence");

                }

                Console.WriteLine("Press y to continue");

                string userinput = Console.ReadKey().KeyChar.ToString();
                continuerunning = userinput.ToLower() == "y";
            

            } while (continuerunning==true);




            Console.ReadKey();


        }

        static void RandomLoop()
        {
            int k = 0;

            Random random = new Random(DateTime.Now.Millisecond);
            k = random.Next(1, 20);

            int i = 0;
            while (i < k)
            {
                Console.WriteLine("what's up");
                i = i + 1;
            }
                

        }
    
    
    
        
        static void UserLoop()
        {
            Console.WriteLine("How many times would you like to see 'hello world!'?");
            int ntimes = int.Parse(Console.ReadLine());
            while (ntimes > 0)
            {
                Console.WriteLine("hello world!");
                ntimes = ntimes - 1;
            }
            

        }

    }

}
