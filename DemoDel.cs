using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deligates
{
    public delegate void deligatePointer();
    public delegate double calAreaPointer(double x);
    //public delegate double calAreaPointer(double x);
    class Program
    {
        static void Main(string[] args)
        {

            calAreaPointer cptr = new calAreaPointer(delegate (double r) { return 3.14 * r * r; });
            Program p = new Program();
            // Console.WriteLine("hello world!");
            deligatePointer mydeligate = new deligatePointer(p.print);
            //deligatePointer mydeligate = p.print;
            mydeligate += p.Display;//multi cast delegate
            mydeligate();
            mydeligate 
                = p.print;
            mydeligate();
            calAreaPointer cptr = Caluclator.calArea;

            cptr += Caluclator.calArea1;
            lamda expression
            calAreaPointer cptr1 = (r => 3.14 * r * r);
            double area = cptr(100.00);
            Console.WriteLine(area);


            public void print()
            {
                Console.WriteLine("welcome delegate");
            }
            public void Display()
            {
                Console.WriteLine("welcome to multi cASTING");
            }
            Func<double, double> f1 = (r => 3.14 * r * r);
            double area2 = f1(1);
            Console.WriteLine(area2);
        }
    }

}
