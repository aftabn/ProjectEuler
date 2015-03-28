using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public class Euler9 : Problem
    {
        public Euler9()
        {
            ProblemName = "Special Pythagorean Triplet";
            ProblemNumber = 9;
        }

        public override string ReturnAnswer()
        {
            int a = 0, b = 0, c = 0;
            int s = 1000;
            for (a = 1; a < s / 3; a++)
            {
                for (b = a; b < s / 2; b++)
                {
                    c = s - a - b;

                    if (a * a + b * b == c * c)
                    {
                        return String.Format("Answer is {0}", a * b * c);
                    }
                }
            }
            return "No solution found";
        }
    }
}