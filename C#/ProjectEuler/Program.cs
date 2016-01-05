using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public class Program
    {
        private static void PrintSolution(Problem problem)
        {
            Console.Out.WriteLine(String.Format("Problem {0}: {1}", problem.ProblemNumber, problem.ProblemName));
            Console.Out.WriteLine(problem.GetAnswer());
            Console.Out.WriteLine(String.Format("Problem took {0:0.####}s to run", problem.RunTimeInSeconds));
            Console.ReadLine();
        }

        private static void Main(string[] args)
        {
            var problem = new Euler1();

            PrintSolution(problem);
        }
    }
}