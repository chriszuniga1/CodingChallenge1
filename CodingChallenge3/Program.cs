using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Fn = Fn−1 + Fn−2, where F1 = 1, F2 = 1, F3 = 2, .... and F12 = 144. F12 is the first term to contain three digits. 
            //What is the index of the first term in the Fibonacci sequence to contain 10 digits ?

            


            int valA = 0, valB = 1, valC = 0;
            string lengthFib = " ";

            while (lengthFib.Length < 10)
            {
                valC = valA + valB;

                valA = valB;
                valB = valC;

                lengthFib = valC.ToString();
            }

            Console.WriteLine(valC);

            }
        }
    }

