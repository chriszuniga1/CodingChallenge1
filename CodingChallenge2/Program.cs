using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 1;
            int c = 0;
            int sum = 0;

            while (c < 4000000)
            {
                c = a + b;

                if (c % 2 == 0)
                {
                    sum += c;
                }

                a = b;
                b = c;
            }

            Console.WriteLine("The sum of even numbers in the Fibonacci Sequence not exceeding 4 million is {0}", sum);
        }
    }
}
