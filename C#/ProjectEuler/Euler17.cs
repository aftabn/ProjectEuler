using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public class Euler17 : Problem
    {
        private int[] ones = new int[] { 0, 3, 3, 5, 4, 4, 3, 5, 5, 4 };
        private int[] teens = new int[] { 3, 6, 6, 8, 8, 7, 7, 9, 8, 8 };
        private int[] tens = new int[] { 6, 6, 5, 5, 5, 7, 6, 6 };
        private static int INT_Hundred = 7;
        private static int INT_Thousand = 11;
        private static int INT_And = 3;

        public Euler17()
        {
            ProblemName = "Number Letter Counts";
            ProblemNumber = 17;
        }

        private int numberOfLetters = 0;

        private int ProcessNumber(int n)
        {
            if (n < 10)
            {
                return ones[n];
            }
            else if (n < 20)
            {
                return teens[n - 10];
            }
            else if (n < 100)
            {
                //Subtract by two since the array starts at 20
                return tens[n / 10 - 2] + ProcessNumber(n % 10);
            }
            else if (n < 1000)
            {
                var total = ProcessNumber(n / 100) + INT_Hundred + ProcessNumber(n % 100);
                return (n % 100 != 0) ? total + INT_And : total;
            }
            else
            {
                return INT_Thousand;
            }
        }

        public override string ReturnAnswer()
        {
            for (int i = 1; i <= 1000; i++)
            {
                numberOfLetters += ProcessNumber(i);
            }

            return String.Format("Total number of letters is: {0}", numberOfLetters);
        }
    }
}