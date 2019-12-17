using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //start
            Console.WriteLine("enter 2 numbmbers pls");
            int a;
            int b;
            int c;
            Console.WriteLine("eneter the first number:");
            String asa = Console.ReadLine();
            a = Convert.ToInt32(asa);

            Console.WriteLine("enter the secend number");
            string basb = Console.ReadLine();
            b = Convert.ToInt32(basb);
            c = a + b;
            Console.Write("shoome=");
            Console.WriteLine(a + b);
            Console.Write("memotza=");
            Console.WriteLine(c / 2);


            
        

            //end
        }
    }
}
