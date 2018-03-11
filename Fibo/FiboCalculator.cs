using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibo
{
    public class FiboCalculator
    {

        public int Fibonaci(int number)
        {
            return Fn(number);
        }

        private int Fn(int number)
        {
            //fn = f(n-1) + f(n-2)
            // 1,1,2,3,5
            //f1 =1, f2 =2

            if (number <= 2)
            {
                return 1;
            }

            return Fn(number - 1) + Fn(number - 2);
        }
    }
    
}
