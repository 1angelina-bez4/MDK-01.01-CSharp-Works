using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class1
    {
        //Проверить истинность высказывания: "Данные целые числа X и Y являются координатами точки, лежащей во второй координатной четверти".
        public bool Meth(int x, int y)
        {
            if (x < 0 && y > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //Ввести пять различных ненулевых целых чисел. Найти произведение двух наименьших чисел.
        public int Proiz(string[] massiv)
        {
            //проверяем массив на количество элементов 
            int[] numbers = new int[5];

            for (int i = 0; i < massiv.Length; i++)
            {
                numbers[i] = Convert.ToInt32(massiv[i]);
            }
            Array.Sort(numbers);

            //находим произведение двух минимальных чисел
            int result1 = numbers[0] * numbers[1];
            return result1;
        }

        //Дан целочисленный массив, состоящий из N элементов (N > 0). Найти сумму и произведение всех чисел из данного массива.
        public (int sum, int proiz, string arrayString) SumProi(int N) //Метод для вычисления суммы и произведения элементов массива
        {

            int [] array = new int [N];
            int sum = 0;
            int proiz = 1;

            //генерируем массив
            Random random = new Random();
            for (int i = 0; i < N; i++)
            {
                array[i] = random.Next(-100, 100);

                sum += array[i]; 
                proiz *= array[i];
            }

            // Преобразуем массив в строку для вывода
            string arrayString = string.Join(", ", array);

            return (sum, proiz, arrayString); //Возвращаем кортеж с суммой и произведением
        }

        //Написать функцию int Min5(A, B, C, D, E) целого типа, возвращающую одно минимальное значение из 5-и своих аргументов (параметры A, B, C, D и E - целые числа).

        public int Min (int A, int B, int C, int D, int E)
        {
            // Используем метод Math.Min для нахождения минимального значения среди пяти чисел.
            // Сначала находим минимальное значение среди первых четырех чисел, 
            // затем сравниваем его с пятым числом.
            return Math.Min(Math.Min(A, B), Math.Min(Math.Min(C, D), E));
        }
    }
}
