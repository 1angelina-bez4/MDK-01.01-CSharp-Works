using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace var4
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Console.WriteLine("Задание 1");
                Console.WriteLine("Проверить истинность высказывания: \"Сумма двух первых цифр данного четырехзначного целого положительного числа" +
                    " равна сумме двух его последних цифр\"");
                Console.WriteLine("Введите целое четырехзначное число: ");
                int num = Convert.ToInt32(Console.ReadLine());

                if (num > 999 && num < 10000)
                {
                    Task1 cl1 = new Task1();
                    bool result = cl1.Methon(num);
                    if (result == true)
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
                    Console.WriteLine("Ошибка! Число должно быть целым и четырехзначным.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


            try
            {
                Console.WriteLine("Задание 2");
                Console.WriteLine("Даны пять целых ненулевых положительных чисел. Найти сумму двух наименьших чисел.");
                Console.WriteLine("Введите пять целых, ненулевых положительных чисел: ");

                int[] array = new int[5];

                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine($"Введите число {i + 1}:");
                    array[i] = Convert.ToInt32(Console.ReadLine());
                }
                Task2 cl2 = new Task2();
                int result1 = cl2.Method1(array);
                Console.WriteLine($"Сумма двух наименьших чисел равна: {result1}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


            try
            {
                Console.WriteLine("Задание 3");
                Console.WriteLine("Дан целочисленный массив, состоящий из N элементов(N > 0).Найти максимальный и минимальный элемент в массиве и вычислить их сумму.");
                Console.WriteLine("Введите Количество Элементов массива:");
                int N = Convert.ToInt32(Console.ReadLine());
                if (N > 30)
                {
                    int[] array2 = new int[N];
                    Random random = new Random();
                    for (int i = 0; i < N; i++)
                    {
                        array2[i] = random.Next(-100, 100);
                    }

                    foreach (int outputmas in array2)
                    {
                        Console.WriteLine(outputmas + " ");
                    }
                    Task3 cl3 = new Task3();
                    int result3 = cl3.Summa(array2);
                    Console.WriteLine($"Сумма равна {result3}");
                }
                else
                {
                    Console.WriteLine("Ошибка!Количество Элементов массива должно быть больше 30.");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                Console.WriteLine("Задание 4");
                Console.WriteLine("Введите Количество Элементов массива:");
                int N1 = Convert.ToInt32(Console.ReadLine());
                if (N1 > 30)
                {
                    int[] array3 = new int[N1];
                    Random random = new Random();
                    for (int i = 0; i < N1; i++)
                    {
                        array3[i] = random.Next(-100, 100);
                    }

                    foreach (int outputmas in array3)
                    {
                        Console.WriteLine(outputmas + " ");
                    }

                    Task4 cl4 = new Task4();
                    int Count = cl4.ElementCount(array3);
                    Console.WriteLine($"Количество не одинаковых элементов равно: {Count}");
                }
                else
                {
                    Console.WriteLine("Ошибка!Количество Элементов массива должно быть больше 30.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }    
    }
}
