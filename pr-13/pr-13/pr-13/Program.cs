using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace var4
{
    class Program
    {
        static void Main(string[] args)
        {
            M1:
            try
            {
                Console.WriteLine("Задание 1");
                // Даны пять целых ненулевых положительных чисел. Найти сумму двух наименьших чисел.
                int[] array = new int[5];
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine($"Число {i + 1}:");
                    array[i] = Convert.ToInt32(Console.ReadLine());
                }
                task1 p = new task1();
                Console.WriteLine($"Сумма двух наименьших чисел: {p.Proverka(array)}");
            }
            catch (System.FormatException ex)
            {
                Console.WriteLine("Сообщение об ошибке: " + ex.Message);
                goto M1;
            }
            catch (System.OverflowException ex1)
            {
                Console.WriteLine("Сообщение об ошибке: " + ex1.Message);
                goto M1;
            }
            Console.WriteLine("Задание 2");

            //В вещественном массиве хранится информация о количестве осадков,
            //выпавших за каждый день месяца N(N - любой месяц в году).Определить,
            //в какие числа месяца осадков не было.Предоставить возможность пользователю реализовать
            //заполнение элементов массива случайными(рандомными) числами.
            M3:
            int N = 0;
            Console.WriteLine("Введите количествло дней:");
            N = Convert.ToInt32(Console.ReadLine());
            try
            {
                if (N > 0 && N <= 31)
                {
                    Console.WriteLine("Выбрано верное количество элементов");
                }
                else
                {
                    Console.WriteLine("Ошибка: количество дней не соответствует никакому месяцу.");
                    goto M3;
                }
                //Создаем массив и выводим количество элементов
                double[] array1 = new double[N];
                //Выбор ввода массива
                int Vvod = 0;
                Console.WriteLine("Выберете ввод чисел ( 1- через консоль, 2 - через рандом):");
                Vvod = Convert.ToInt32(Console.ReadLine());
                switch (Vvod)
                {
                    case 1:
                        //Ввод с клавиатуры

                        for (int i = 0; i < N; i++)
                        {
                            Console.WriteLine($"Число {i + 1}:");
                            array1[i] = Convert.ToInt32(Console.ReadLine());
                        }
                        break;
                    case 2:
                        //Ввод через рандом
                        Random random = new Random();
                        for (int i = 0; i < N; i++)
                        {
                            //Ввод числа от 0 до 100 положительные
                            array1[i] = random.Next(0, 101);
                            Console.WriteLine($"Случайное число {i + 1}:{array1[i]}");

                        }
                        break;
                    default:
                        Console.WriteLine("Вы не выбрали как ввести массив! ");
                        goto M3;
                }
         
                Task2 Result  = new Task2();
                Console.WriteLine($"Дни без осадков {Result.osadki(array1)}");
            }
            catch (System.FormatException ex)
            {
                Console.WriteLine("Сообщение об ошибке: " + ex.Message);
                goto M3;
            }
            catch (System.OverflowException ex1)
            {
                Console.WriteLine("Сообщение об ошибке: " + ex1.Message);
                goto M3;
            }

            M4:
            try
            {
                Console.WriteLine("Задание 3");
                //Написать функцию int DigitN(K, N) целого типа,
                //возвращающую N-ю цифру целого положительного числа K
                //(цифры в числе нумеруются справа налево).
                //Если количество цифр в числе K меньше N,
                //то функция должна возвращать значение -1.
                int K = 0;
                Console.WriteLine("Введите число (цифры в числе нумеруются справа налево): ");
                K = Convert.ToInt32(Console.ReadLine());
                int N1 = 0;
                Console.WriteLine("Введите номер цифры (N): ");
                N1 = Convert.ToInt32(Console.ReadLine());
                Task3 task3 = new Task3();
                int result1 = task3.DigitN(K, N1);
                if (result1 == -1)
                {
                    Console.WriteLine("Количество цифр в числе меньше N.");
                }
                else
                {
                    Console.WriteLine($"N-я цифра числа {K} (справа налево) равна: {result1}");
                }
            }
            catch (System.FormatException ex)
            {
                Console.WriteLine("Сообщение об ошибке: " + ex.Message);
                goto M4;
            }
            catch (System.OverflowException ex1)
            {
                Console.WriteLine("Сообщение об ошибке: " + ex1.Message);
                goto M4;
            }

            M5:
            try
            {
                Console.WriteLine("Задание 4");
                //Написать функцию int Calc(A, B, Op)
                //целого типа, выполняющую над ненулевыми целыми числами A и B
                //одну из арифметических операций и возвращающую ее результат.
                //Вид операции определяется целым параметром Op:
                //1 — вычитание, 2 — умножение, 3 — деление, 4 — сложение.

                int A = 0;
                int B = 0;
                int Op = 0;
                Console.WriteLine("Введите ненудевое целое число A:");
                A = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите ненудевое целое число B: ");
                B = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите Оператор 1 — вычитание, 2 — умножение, 3 — деление, 4 — сложение: ");
                Op = Convert.ToInt32(Console.ReadLine());

                Task4 result2 = new Task4();
                Console.WriteLine($"Результат операции:{result2.Calc(A, B, Op) }");
            }
            catch (System.FormatException ex)
            {
                Console.WriteLine("Сообщение об ошибке: " + ex.Message);
                goto M5;
            }
            catch (System.OverflowException ex1)
            {
                Console.WriteLine("Сообщение об ошибке: " + ex1.Message);
                goto M5;
            }

            M6:
            try
            {
                Console.WriteLine("Задание 5");
                //Вводится строка, состоящая из слов разделенных точками.
                //Длина строки может быть разной.
                //Сформировать и вывести подстроку, расположенную между первой
                //и второй точками исходной строки.
                //Если в строке менее двух точек, то вывести всю исходную строку.
                Console.WriteLine("Введите строку состоящей из слов разделенных точками.");
                string V= Console.ReadLine();
                Task5 task5 = new Task5();
                Console.WriteLine("Подстрока между точками: " + task5.Methoot(V));
            }
            catch (System.FormatException ex)
            {
                Console.WriteLine("Сообщение об ошибке: " + ex.Message);
                goto M5;
            }
            catch (System.OverflowException ex1)
            {
                Console.WriteLine("Сообщение об ошибке: " + ex1.Message);
                goto M5;
            }
        }
    }
}
