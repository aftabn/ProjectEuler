using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public class Euler3 : Problem
    {
        public Euler3()
        {
            ProblemName = "Largest Prime Factor";
            ProblemNumber = 3;
        }

        protected override void CalculateAnswer()
        {
            long div = 0;
            long highPrime = 0;
            long limit = 600851475143;
            bool prime = false;

            for (long i = limit / 2 + 1; i > 1 && prime == false; i--)
            {
                if (limit % i == 0)
                {
                    prime = true;
                    div = i;

                    for (long j = 2; j < div; j++)
                    {
                        if (div % j == 0)
                        {
                            prime = false;
                            break;
                        }
                    }

                    if (prime == true)
                    {
                        highPrime = div;
                    }
                }
            }

            Answer = String.Format("Answer is {0}", highPrime);
        }
    }
}