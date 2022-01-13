using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib_2
{
    public static class Numbers
    {
        static Random rnd = new Random();
        /// <summary>
        ///  Находит разность сгенерированных чисел до тех пор, пока разность < числа К.
        /// </summary>
        /// <param name="k">Число К</param>
        /// <returns>Сгенерированные числа, значение разности, и количество сгенерированных чисел.</returns>
        public static (string, string, int) Difference(int k)
        {
            string numbers = "";
            int difference = 0;
            int count =0 ;
            while (k < difference)
            {
                int currentvalue = rnd.Next(2, 10);
                difference -= currentvalue;
                numbers += currentvalue.ToString() + " ";
                count++;
            }
            return (numbers, difference.ToString(), count);
        }
    }
}
