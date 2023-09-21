using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace singleDelegates
{
    public delegate void Cal(int a, int b);
     class Program
    {
       public static void ADD(int a,int b)
        {
            int result = a + b;
            Console.WriteLine(result+"Rrsult of Add:");
       
        }
        static void Main(string[] args)
        {
            Cal obj = new Cal(ADD);
            obj(67,67);
            Console.ReadLine
                ();
        }
    }
}
