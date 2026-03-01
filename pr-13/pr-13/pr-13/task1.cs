using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace var4
{
    public class task1
    {
        // Даны пять целых ненулевых положительных чисел. Найти сумму двух наименьших чисел.
         public int Proverka(int[] array)
         {
            int sum = 0;
            foreach (int i in array)
            {
                if (i != 0)
                {
                    Array.Sort(array);
                    sum = array[0] + array[1];
                }
            }
            return sum;
         }
    }
}
