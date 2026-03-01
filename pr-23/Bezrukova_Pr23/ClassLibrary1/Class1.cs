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
        /// Проверяем истинность высказывания на :"Сумма двух первых цифр данного
        ///четырехзначного целого положительного числа равна сумме двух его последних цифр"
        /// </summary>
        /// <param name="num">число которое мы забираем с консоли</param>
        /// <returns>Возращаем истинну высказывания в виде буллевого значения</returns>
        public bool Methon(int num)
        {
            //Проверить истинность высказывания: "Сумма двух первых цифр данного
            //четырехзначного целого положительного числа равна сумме двух его последних цифр".
            int A = (num / 1000);
            int B = (num / 100) % 10;
            int C = (num / 10) % 10;
            int D = (num % 10);

            if (A + B == C + D)
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
        //Даны пять целых ненулевых положительных чисел. Найти сумму двух наименьших чисел.

        /// <summary>
        /// Находим сумму двух наименьших чисел из 5
        /// </summary>
        /// <param name="array"> массив состоящий из 5 чисел</param>
        /// <returns>Возращаем значение суммы</returns>
        public int Method1(int[] array)
        {
            Array.Sort(array);
            int sum = array[0]+array[1];
            return sum;
        }

    }

    public class Task3
    {
        //Дан целочисленный массив, состоящий из N элементов(N > 0).
        //Найти максимальный и минимальный элемент в массиве и вычислить их сумму.


        /// <summary>
        /// Находим сумму максимального и мигимального элемента 
        /// </summary>
        /// <param name="array2">массив в котором хранятся значения </param>
        /// <returns>возращаем значение полученной суммы</returns>
        public int Summa(int[] array2)
        {
            int min = array2[0];
            int max = array2[0];

            foreach (int number in array2)
            {
                if (number > min)
                {
                    min = number;
                }
                if (number < max)
                {
                    max = number;
                }
            }

            int sum = max+min;
            return sum;
        }
    }

    public class Task4
    {

        /// <summary>
        /// Найходим в массиве количество не одинаковых элементов
        /// </summary>
        /// <param name="array3">массив в котором находятся рандомные элементы</param>
        /// <returns>Возращаем количество элементов</returns>
        public int ElementCount(int[] array3)
        {
             Array.Sort(array3);

            int Count = 1;

            for (int i = 1; i < array3.Length; i++)
            {
                if ( array3[i] != array3[i - 1])
                {
                    Count++;
                }
            }

            return Count;
        }
    }
    
}
