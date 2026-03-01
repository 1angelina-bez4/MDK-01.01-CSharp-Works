using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr01
{
    internal class Program
    {
        static void Main(string[] args)
        {    //Задание 4
            //Вводим длину ребра-стороны.
            double A = 0;
            Console.WriteLine("Введите длину ребра (см) :");
            A = Convert.ToDouble(Console.ReadLine());
            //Считаем объем куба в куб. см и Выводим значение.
            double V1 = Math.Pow(A, 3);
            Console.WriteLine("Объем куба в куб.см:");
            Console.WriteLine(V1);

            //Считаем объем куба в куб.м и Выводим значение.
            double V2 = (V1 / 1000000);
            Console.WriteLine("Объем куба в куб.м:");
            Console.WriteLine(V2);



            //Задание 15
            //вводим расстояние до дачи
            Console.WriteLine("Введите расстояние до дачи в км:");
            double S = 0;
            S = Convert.ToDouble(Console.ReadLine());

            //Выводим расход бензина
            Console.WriteLine("Введите расход бензина (литров на 100 км пробега");
            double B = 0;
            B = Convert.ToDouble(Console.ReadLine());

            //Вводим цену Бензина
            Console.WriteLine("Введите цену на бензин в рублях:");
            double C = 0;
            C = Convert.ToDouble(Console.ReadLine());

            //Считаем сколько обойдеться поездка
            double D = S * 2; //туда и обратно

            double E = (D / 100) * B; //сколько литров выйдет

            double F = E * C; //Итог стоимости 
            Console.WriteLine("Поездка на дачу и обратно выйдет в рублях:");
            Console.WriteLine(F);

            //Задание 23
            //Вводим временный интервал 
            Console.WriteLine("Введите временый интервал в минутах:");
            double G = 0;
            G = Convert.ToDouble(Console.ReadLine());

            //Вычисление часов и минут
            double H = G / 60; //часы
            double I = G % 60; // минуты

            Console.WriteLine("Вышло столько часов:");
            Console.WriteLine(H);
            Console.WriteLine("Вышло столько минут:");
            Console.WriteLine(I);
        }
    }
}