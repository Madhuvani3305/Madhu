using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    public delegate void deligatePointer();
    public delegate void calAreaPointer();
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello");
            Program p = new Program();
            //deligatePointer myde = new deligatePointer(print);
            deligatePointer myde = p.print;
            myde();
           // Calculate cr = new Calculate();
            calAreaPointer cptr =new calAreaPointer(Calculate.CalArea);
            double area = cptr(20);
                
                
            Console.WriteLine(area);
            Console.ReadLine();

        }
        public void print()
        {
            Console.WriteLine("welcome to delegate");
        }
    }
}
