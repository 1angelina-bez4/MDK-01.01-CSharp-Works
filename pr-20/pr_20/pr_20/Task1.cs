using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr_20
{
    public class Task1
    {
        //Проверить истинность высказывания: "Цифры данного целого положительного четырехзначного числа образуют возрастающую последовательность"
        public static bool Meth(int N)
        {
            int a = N / 1000;
            int b = (N / 100) % 10;
            int c = (N / 10) % 10;
            int d = N % 10;
            if (a < b && a < c && a < d && b < c && b < d && c < d)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
