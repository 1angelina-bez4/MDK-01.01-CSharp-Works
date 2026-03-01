using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace var4
{
    internal class Task4
    {
        public int SumRangeOdd(int A1, int B1)
        {
            if (A1 > B1)
            {
                return 0; // Если A больше B, возвращаем 0
            }

            int sum = 0;
            for (int i = A1; i <= B1; i++)
            {
                sum += i * i; // Суммируем 
            }
            return sum; // Возвращаем результат
        }
    }
}
