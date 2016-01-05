using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public class Euler1 : Problem
    {
        public Euler1()
        {
            ProblemName = "Multiples of 3 and 5";
            ProblemNumber = 1;
        }

        protected override void CalculateAnswer()
        {
            int sum = 0;

            for (int i = 0; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum += i;
                }
            }

            Answer = String.Format("Answer is {0}", sum);
        }
    }
}