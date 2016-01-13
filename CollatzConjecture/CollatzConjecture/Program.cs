using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollatzConjecture
{
    class Program
    {
        //Create Input Capture and Validation Method
            // must be number > 1
            // "Error: Please enter a valid number"
        static int GetInteger(string prompt)
        {
            while(true)
            {
                try
                {
                    Console.WriteLine(prompt);
                    string input = Console.ReadLine();
                    int x = int.Parse(input);
                    if (x > 1)
                    {
                        return x;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error: Please enter a valid number.");
                }
            }
        }     

        static void Main(string[] args)
        {
            //Set Variables, fetch user input
            int tries = 0;
            int max = 0;
            int maxstep = 0;
            int input = GetInteger("Please enter an integer, greater than 1");
            int n = input;

            while (n != 1)
            {
                //Transformation of n
                if (n%2 == 0)
                {
                    n = n / 2;
                }
                else
                {
                    n = (n * 3) + 1;
                }
       
                //Increment Tries
                tries++;
                
                //Update max and maxstep # if n > max
                if (n > max)
                {
                    max = n;
                    maxstep = tries;
                }
                 /*Logging the Steps:
                Console.Write(n + "..."); */
            }

            //After loop exits, write results to console
            Console.WriteLine("It took " + tries + " steps to reach "+ n +" from " + input + ".");
            Console.WriteLine("The value reaches it's peak of " + max + " at step " + maxstep+".");
            Console.ReadLine();
        }
    }
}
