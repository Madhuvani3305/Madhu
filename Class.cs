using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Class
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("enter no. trainees: ");
            int n = int.Parse(Console.ReadLine());
            List<Trainee> t = new List<Trainee>();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("enter trainee id ,name,project id");
                int tid = int.Parse(Console.ReadLine());
                string name = Console.ReadLine();
                int pid = int.Parse(Console.ReadLine());
                t.Add(new Trainee(tid,name, pid));
            }
            List<Trainee> p = t.FindAll(e => e.pid != -1);
            foreach (Trainee t1 in p)
            {
                Console.WriteLine(t1.ToString());
            }
            Console.ReadLine();
        }
    }
    }

