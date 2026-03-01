using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr_20
{
    class Program
    {
        static void Main(string[] args)
        {
            //Проверить истинность высказывания: "Цифры данного целого положительного четырехзначного числа образуют возрастающую последовательность"
            Console.WriteLine("Введите четырехзначное число");
            int N = Convert.ToInt32(Console.ReadLine());
            if (N > 999 && N < 10000)
            {
                bool a = Task1.Meth(N);
                if(a)
                {
                    Console.WriteLine("True");
                }
                else
                {
                    Console.WriteLine("False");
                }
            }
            else
            {
                Console.WriteLine("Вы ввели не то число");
            }
        }
    }
}
