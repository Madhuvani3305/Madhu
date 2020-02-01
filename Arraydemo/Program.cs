using System;

namespace Arraydemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter no s");
            int n= int.Parse(Console.ReadLine());
            int[] num = new int[n];
            int i, max, min, n;
            max = num[0];
            min = num[0];
           
            for(i=0;i<n;i++)
            {

                num[i] = int.Parse(Console.ReadLine());
                
            }
            for (i = 1; i < n; i++)
            {
                if (num[i] > max)
                {
                    max = num[i];
                }
                if (num[i] < min)
                {
                    min = num[i];
                }
            }
            // Console.ReadLine();
            Console.Write("max no", max);
            Console.Write("min no", min);
        }
    }
}
