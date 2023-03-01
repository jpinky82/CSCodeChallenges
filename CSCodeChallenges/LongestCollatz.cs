using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace CSCodeChallenges
{
    internal class LongestCollatz
    {
        static void Main(string[] args)
        {

            //The following iterative sequence is defined for the set of positive integers:
            // n -> n/2 (n is even)
            // n -> 3n + 1 (n is odd)

            //Using the rule above and starting with 13, we generate the following sequence:
            // 13 -> 40 -> 20 -> 10 -> 5 -> 16 -> 8 -> 4 -> 2 -> 1

            //It can be seen that this sequence (starting at 13 and finishing at 1) contains 10 terms. 
            //Although it has not been proven yet (Collatz Problem), it is thought that all starting numbers finish at 1.

            //Which starting number, under one thousand, produces the longest chain?

            int currentValue = 0;
            List<int> values = new List<int>();
            int longestCollatzNum = 0;
            int longestCollatzLength = 0;
            bool exit = false;

            for (int n = 0; n < 1000; n++)
            {
                currentValue = n;
                do
                {
                    values.Add(currentValue);

                    if (currentValue == 1 || currentValue == 0)
                    {
                        exit = true;
                    }
                

                    if (currentValue % 2 == 0)
                    {
                        currentValue /= 2;

                    }
                    else if (currentValue != 1 && currentValue != 0)
                    {
                        currentValue = (currentValue * 3) + 1;
                    }

                } while (!exit);

                if (values.Count > longestCollatzLength)
                {
                    longestCollatzLength = values.Count;
                    longestCollatzNum = n;
                }

                //for (int i = 0; i < values.Count; i++)
                //{
                //    Console.Write((i == values.Count -1) ? values[i] : $"{values[i]} -> ");
                //}

                Console.WriteLine();
                exit = false;
                values.Clear();
                //Console.WriteLine("\n\n\n");
            }
            Console.WriteLine($"The starting number (under one-thousand) with the longest Collatz chain is {longestCollatzNum} with a length of {longestCollatzLength}" +
                $".....THAT'S BIG!");
        }
    }
}
