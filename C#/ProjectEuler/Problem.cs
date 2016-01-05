using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public abstract class Problem
    {
        public string Answer { get; set; }

        public string ProblemName { get; set; }

        public int ProblemNumber { get; set; }

        public double RunTimeInSeconds { get; set; }

        public string GetAnswer()
        {
            var watch = Stopwatch.StartNew();

            CalculateAnswer();
            watch.Stop();
            RunTimeInSeconds = watch.ElapsedMilliseconds / 1000.0;

            return Answer;
        }

        protected abstract void CalculateAnswer();
    }
}