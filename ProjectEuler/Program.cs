using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Euler19 problem = new Euler19();

            Console.Out.WriteLine(String.Format("Problem {0}: {1}", problem.ProblemNumber, problem.ProblemName));
            Console.Out.WriteLine(problem.ReturnAnswer());
            Console.ReadLine();
        }
    }
}