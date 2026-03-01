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
                Console.WriteLine("Даны три целых числа: A, B, C.Проверить истинность высказывания: «Число B находится между числами A и C».");
                Console.WriteLine("Введите число А:");
                int A = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите число B:");
                int B = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите число C:");
                int C = Convert.ToInt32(Console.ReadLine());

                Task1 cl1 = new Task1();
                bool result1 = cl1.Methood1(A, B, C);
                Console.WriteLine($"Высказывание  является: {result1}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                Console.WriteLine("Задание 2");
                Console.WriteLine("Написать функцию double Calc(A, B, Op) вещественного типа, выполняющую над ненулевыми вещественными числами A и B одну из арифметических операций и возвращающую ее результат." +
                    " Вид операции определяется целым параметром Op: 1 — вычитание, 2 — умножение, 3 — деление, 4 — сложение.");

                Console.WriteLine("Введите ненулевое вещественное число А: ");
                double A1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите ненулевое вещественное число B: ");
                double B1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите Операцию которую вы хотите сделать (1 — вычитание, 2 — умножение, 3 — деление, 4 — сложение): ");
                int Op = Convert.ToInt32(Console.ReadLine());

                Task2 cl2 = new Task2();
                double result2=cl2.Calc(A1,B1,Op);
                Console.WriteLine($"Ответ: {result2}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                Console.WriteLine("Задание 3");
                Console.WriteLine("В вещественном массиве известны данные о количестве осадков, выпавших за каждый день месяца N (N - любой месяц в году). Найти общее число осадков," +
                    " выпавших по нечетным числам этого месяца. Предоставить возможность пользователю реализовать заполнение элементов массива случайными (рандомными) числами.");

                Console.WriteLine("Введите любой месяц в году:");
                int N = Convert.ToInt32(Console.ReadLine());
                if ( N == 1 || N==3 || N==5 || N==7 || N==8 || N==10 || N==12)
                {
                    double [] array = new double [31];
                    Random random = new Random();
                    for (int i = 0; i < array.Length;i++)
                    {
                        array[i] = random.Next(-100, 100);
                        
                    }
                    Console.WriteLine("Полученный массив:");
                    for (int i = 0; i < array.Length; i++)
                    {
                        Console.WriteLine(array[i]+" ");
                    }
                    Task3 cl3 = new Task3();
                    double result3 = cl3.Osadki(array);
                    Console.WriteLine($"Общее число осадков равно {result3}");

                }
                else if ( N==4 || N==6 || N ==9 || N==11)
                {
                    double[] array = new double[30];
                    Random random = new Random();
                    for (int i = 0; i < array.Length; i++)
                    {
                        array[i] = random.Next(-100, 100);
                    }
                    Console.WriteLine("Полученный массив:");
                    for (int i = 0; i < array.Length; i++)
                    {
                        Console.WriteLine(array[i] + " ");
                    }
                    Task3 cl3 = new Task3();
                    double result3 = cl3.Osadki(array);
                    Console.WriteLine($"Общее число осадков равно {result3}");
                }
                else if ( N==2)
                {
                    double[] array = new double[28];
                    Random random = new Random();
                    for (int i = 0; i < array.Length; i++)
                    {
                        array[i] = random.Next(-100, 100);
                    }
                    Console.WriteLine("Полученный массив:");
                    for (int i = 0; i < array.Length; i++)
                    {
                        Console.WriteLine(array[i] + " ");
                    }
                    Task3 cl3 = new Task3();
                    double result3 = cl3.Osadki(array);
                    Console.WriteLine($"Общее число осадков равно {result3}");
                }
                else
                {
                    Console.WriteLine("Ошибка!Месяцев всего 12.");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                Console.WriteLine("Задание 4");
                Console.WriteLine("Вводится строка, изображающая двоичную запись целого положительного числа. Вывести строку, изображающую десятичную запись этого же числа.");
                Console.WriteLine("Введите двоичное число:");
                string binarstr=Console.ReadLine();

                Task4 cl4 = new Task4();
                int resultat4=cl4.Binary(binarstr);
                Console.WriteLine($"Десятичная запись числа: {resultat4}");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
