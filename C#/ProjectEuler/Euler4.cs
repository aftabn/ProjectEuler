using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public class Euler4 : Problem
    {
        public Euler4()
        {
            ProblemName = "Largest Palindrome Product";
            ProblemNumber = 4;
        }

        protected override void CalculateAnswer()
        {
            int product;
            bool found = false;
            string palindrome = String.Empty;
            string piece1, piece2;

            for (int i = 999; i > 800 && !found; i--)
            {
                for (int j = 999; j > i - 100 && j > 800 && !found; j--)
                {
                    product = i * j;
                    palindrome = product.ToString();

                    piece1 = palindrome.Substring(0, palindrome.Length / 2);
                    piece2 = palindrome.Substring(palindrome.Length / 2, palindrome.Length).Reverse().ToString();

                    if (piece1.Equals(piece2))
                    {
                        found = true;
                    }
                }
            }

            Answer = String.Format("Answer is {0}", palindrome);
        }
    }
}