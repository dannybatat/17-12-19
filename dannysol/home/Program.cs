using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home
{
    class Program
    {
        static void Main(string[] args)
        {
            //start
            Console.WriteLine("eneter number");

            int a = Convert.ToInt32(Console.ReadLine());


            if (a <= 9) 
            {
                Console.WriteLine("mespar hadsifrati");
            }
            else
            {
                Console.WriteLine("ahadot="+a % 10);
                Console.WriteLine("asharot=" + a / 10);
            }
            if (a % 10 > a / 10) 
            {
                Console.WriteLine("ahdot gdol yoter");
            }
            else
            {
                Console.WriteLine("ashrot gadol yoter");
            }
               
      


            //end
        }
    }
}
