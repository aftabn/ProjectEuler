using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public abstract class Problem
    {
        public string ProblemName { get; set; }

        public int ProblemNumber { get; set; }

        public abstract string ReturnAnswer();
    }
}