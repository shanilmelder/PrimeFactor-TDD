using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeFactor_TDD
{
    public static class PrimeFactor
    {
        public static List<int> Genarate(int number)
        {
            var numbers = new List<int>();
            var divider = 2;
            while (number > 1)
            {
                //start:
                //if (number % divider != 0)
                //{
                //    goto start;
                //}


                while (number % divider == 0)
                {
                    numbers.Add(divider);
                    number = number / divider;
                    //goto start;

                }
                divider++;

            }
            if (number > 1)
            {
                numbers.Add(number);
            }

            return numbers;
        }
    }
}
