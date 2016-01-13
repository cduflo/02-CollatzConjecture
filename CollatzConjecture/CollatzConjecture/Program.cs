using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollatzConjecture
{
    class Program
    {
        //Define public variables
        public static int max = 0;
        public static int maxstep = 0;
        public static int count = 0;

        //Create Input Capture and Validation Method
        // must be number > 1
        // "Error: Please enter a valid number"
        static int GetInteger(string prompt)
        {
            Console.WriteLine(prompt);
            while (true)
            {
                try
                {
                    string input = Console.ReadLine();
                    int x = int.Parse(input);
                    if (x > 1)
                    {
                        return x;
                    }
                    else
                    {
                         Console.WriteLine("Error: Please enter a valid number.");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error: Please enter a valid number.");
                }
            }
        }


        //Define Recursive Method
        static int Recursive(int value)
        {
            int n = value;

            //Update max and maxstep # if n > max
            if (value > max)
            {
               max = n;
                maxstep = count;
                    //Console.WriteLine("max= " + max);
                    //Console.WriteLine("maxstep= " + maxstep);
            }

            //Transformation and recapture of new n
            if (n == 1)
            {
                return n;
            }

            if (n % 2 == 0)
            {
                n = n / 2;
            }
            else
            {
                n = (n * 3) + 1;
            }

            //Counter increment up
            count++;
            //Debugging notes
                //Console.WriteLine("n= " + n);
                //Console.WriteLine("count= " + count);

            return Recursive(n);
    }


        static void Main(string[] args)
        {
            //Set Variables, fetch user input
            int input = GetInteger("Please enter an integer, greater than 1.");
            int n = input;

            //Call recursive method
            int alg = Recursive(n);

            //Print output to Console
            Console.WriteLine("======");
            Console.WriteLine("It took " + count + " steps to reach "+ alg + " from " + input + ".");
            Console.WriteLine("The value reaches it's peak of " + max + " at step " + maxstep + ".");
            Console.WriteLine("======");

            Console.ReadLine(); 
        }
    }
}
