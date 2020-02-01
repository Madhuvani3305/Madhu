using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Trainee
    {
        public int tid, pid;
        protected string name;
        public Trainee(int tid, string name, int pid)
        {
            this.tid = tid;
            this.pid = pid;
            this.name = name;
        }
        public override string ToString()
        {
            return this.name;
        }

    }
}
