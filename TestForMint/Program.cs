using System;

namespace TestForMint                                                                                           // set up repository
{
    class Program                                                                                               // setup class  
    {
        static void Main(string[] args)                                                                         // start of void
        {
            static double recur(int n, int UserInput)                                                           // recursion function 
            {                                                                                                   // start of recursion function 
                if (n == UserInput+1)                                                                           // if condition
                {                                                                                               // start if
                    return 2 * n - 1;                                                                           // loop cause
                }                                                                                               // end if
                else
                {                                                                                               // start else
                    return (2 * n) - 1 + (Math.Pow(n, 2) / recur(n + 1, UserInput));                            // continue fraction function (do some math test)
                }                                                                                               // end else
            }                                                                                                   // end of recursion function 

            Console.Write("Input Limit n : ");                                                                  // ask for user input
            int UserInput = int.Parse(Console.ReadLine());                                                      // waiting for the command

            if (UserInput > 0)                                                                                  // if condition (start if user input is more than zero)
            {                                                                                                   // start if
                Console.WriteLine("Estimate value of PI is {0}", 4 / recur(1, UserInput));                      // print the PI value
            }                                                                                                   // end if

            else
            {                                                                                                   // start else
                Console.WriteLine("Can not estimate value of PI.");                                             // print error (print to not print)
            }                                                                                                   // end else

            Console.ReadLine();                                                                                 // this line code is for safety in the visual studio program
        }                                                                                                       // end of void
    }                                                                                                           // end of class  
}                                                                                                               // end of repository
//////////////////////////////////////////////////////////////////////////////end of code//////////////////////////////////////////////////////////////////////////////