using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public class Euler2 : Problem
    {
        public Euler2()
        {
            ProblemName = "Even Fibonacci Numbers";
            ProblemNumber = 2;
        }

        protected override void CalculateAnswer()
        {
            int x = 1;
            int y = 1;
            int result = 0;
            int sum = 0;

            while (result < 4000000)
            {
                if (result % 2 == 0)
                {
                    sum += result;
                }

                result = x + y;
                y = x;
                x = result;
            }

            Answer = String.Format("Answer is {0}", sum);
        }
    }
}