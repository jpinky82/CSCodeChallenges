using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCodeChallenges
{
    internal class TenDigitFibonacci
    {

        static void Main(string[] args)
        {
            //The Fibonacci sequence is defined by the recurrence relation:
            // Fn = Fn1 + Fn2, where F1 = 1, F2 = 1, F3 = 2, ......F12 = 144.  F12 is the first term to contain three digits.
            //What is the index of the first term in the Fibonnacci sequence to contain 10 digits?


            int iterator = 0;
            int num1 = 1;
            int num2 = 0;
            int nextNum = 0;
            string getNumLength = "";

            while (getNumLength.Length < 10)
            {

                nextNum = num1 + num2;
                num1 = num2;
                num2 = nextNum;
                getNumLength = Convert.ToString(nextNum);
                
                iterator++;
            }
            Console.WriteLine($"the index of the first term in the Fibonnacci Sequence to contain 10 digits is {iterator}");
        }
    }
}
