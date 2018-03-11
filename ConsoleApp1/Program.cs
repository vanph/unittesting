using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fibo;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var fc = new FiboCalculator();

            for (int i = 3; i < 10; i++)
            {
                 Console.WriteLine(fc.Fibonaci(i) );

            }

            Console.ReadLine();
        }
    }
}
