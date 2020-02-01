using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demointerface
{
    interface Iloan
    {
       void getinterest() ;

    }
    interface IGloan:Iloan
    {
        void getGoldloan();
    }
   public   abstract class Bank
    {
        protected string bname;
        protected string location;
        public Bank(string bname, string location)
        {
            this.bname=bname;
            this.location = location;
        }
    }
    public class SBI:Bank,Iloan
    {
        string bmanager;
        public SBI(string name ,string location , string bmgr):base(bname,location)
        {
            this.bmanager = bmgr;
        }
        public  void getintrest()
        {
            Console.WriteLine("sbi interest rate is 12% ");
        }
        public void getgoldloan()
        {
            Console.WriteLine("sbi is giving gold loan with intrest of 14%");
        }
        public void displayDetails()
            {
            Console.WriteLine(this.bname + " " + this.location +" " + this.bmanager);

    }
        static void Main(string[] args)
        {
            SBI hyd = new SBI("SBI4569", "hyderabad", "jaya");
            hyd.displayDetails();
            hyd.getintrest();
            Console.ReadLine();
        }
    }
}
