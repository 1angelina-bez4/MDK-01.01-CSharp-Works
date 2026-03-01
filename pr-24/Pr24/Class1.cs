using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace var4
{

    public class Task1
    {
        /// <summary>
        /// Проверяем высказывание на истинность 
        /// </summary>
        /// <param name="A">переменная А которую мы забираем с консоли </param>
        /// <param name="B">переменная В которую мы забираем с консоли</param>
        /// <param name="C">переменная С которую мы забираем с консоли</param>
        /// <returns>Возращаем истиину высказывания</returns>
        public bool Methood1(int A, int B, int C)
        {
            if ( A<B && B<C)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    public class Task2
    {
        /// <summary>
        /// Функция выполняющая арифметических операций и возвращающую ее результат над числами  А И В
        /// </summary>
        /// <param name="A1">переменная А которую мы забираем с консоли</param>
        /// <param name="B1">переменная B которую мы забираем с консоли</param>
        /// <param name="Op">переменная которая отвечает за опирацию над числами</param>
        /// <returns>Возращаем  полученный ответ</returns>
        public double Calc(double A1, double B1, int Op)
        {
            double otvet = 0;
            if( Op==1)
            {
                 otvet = A1 - B1;
            }
            else if (Op==2)
            {
                otvet = A1 * B1;
            }
            else if (Op == 3)
            {
                otvet = A1 / B1;
            }
            else if (Op == 4)
            {
                otvet = A1 + B1;
            }
            return otvet;
        }
    }

    public class Task3
    {
        /// <summary>
        /// Найти общее число осадков,выпавших по нечетным числам этого месяца
        /// </summary>
        /// <param name="array">массив в котором находятся осадки</param>
        /// <returns></returns>
        public double Osadki(double [] array)
        {
            double countosad =0;
            for ( int i = 1;i<array.Length;i++)
            {
                if (array[i]%2==1)
                {
                    countosad += array[i];
                }
            }
            return countosad;
        }
    }

    public class Task4
    {
        /// <summary>
        /// Преобразование двоичной строки в десятичное число
        /// </summary>
        /// <param name="binarstr">Строка которая вводится с клавиатуры</param>
        /// <returns>возращаем значение десятичного числа</returns>
        public int Binary(string binarstr)
        {
            int numb= Convert.ToInt32(binarstr, 2);

            return numb;
        }
    }
}
