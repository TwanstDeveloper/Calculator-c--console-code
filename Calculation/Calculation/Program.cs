using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Number ");
            
            double x=Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Operation ");
            string result=Console.ReadLine();
            Console.Write("Enter Number ");

            double y =Convert.ToDouble(Console.ReadLine());

            if (result=="+")
            {
                x += y;
            }
            else if (result=="-")
            {
                x -= y;
            }else if (result == "*")
            {
                x*=y;
            }
            else if (result=="/")
            {
                x /= y;
            }
            Console.WriteLine("Result= "+x);
            Console.ReadKey();
        }

    }
}
