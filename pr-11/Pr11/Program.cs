using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace var4
{
    internal class Program
    {
        static void Main(string[] args)
        {   //Задание1
            //Даны три целых числа: A, B, C.
            //Проверить истинность высказывания: «Каждое из чисел A, B, C положительное».
            M1:
            try
            {


                Console.WriteLine("Задание1");
                Task1 peremennay = new Task1();
                Console.WriteLine("Введите Число А:");
                int A = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите Число B:");
                int B = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите Число C:");
                int C = Convert.ToInt32(Console.ReadLine());
                peremennay.Task(A, B, C);
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

             //Задание 2
             //Дано количество часов,
            //минут и секунд (1 час = 60 минут, 1 минута = 60 секунд).
            //Вычислить и вывести общее количество секунд.
            M2:
            try
            {
                Console.WriteLine("Задание2");
                Task2 peremennay2 = new Task2();
                Console.WriteLine("Введите Часы :");
                int hours = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите минуты:");
                int minuts = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите секунды");
                int second = Convert.ToInt32(Console.ReadLine());
                peremennay2.Methood(hours, minuts, second);
            }
            catch (System.FormatException ex)
            {
                Console.WriteLine("Сообщение об ошибке: " + ex.Message);
                goto M2;
            }
            catch (System.OverflowException ex1)
            {
                Console.WriteLine("Сообщение об ошибке: " + ex1.Message);
                goto M3;
            }
            //Задание 3
            //Дан целочисленный массив,
            //состоящий из N элементов (N > 0).
            //Проверить, образует ли данный набор возрастающую последовательность.
            //Если образует, то вывести True, если нет - вывести False.
            Console.WriteLine("Задание 3");
            M3:
            int N = 0;
            Console.WriteLine("Введите число элементов массива:");
            N = Convert.ToInt32(Console.ReadLine());

            try
            {
                if (N > 0 && N >= 30)
                {
                    Console.WriteLine("Выбрано верное количество элементов");
                }
                else
                {
                    Console.WriteLine("Ошибка: количество элементов должно быть больше 0  и не более 25");
                    goto M3;
                }
                //Создаем массив и выводим количество элементов
                int[] array = new int[N];
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
                            array[i] = Convert.ToInt32(Console.ReadLine());
                        }
                        break;
                    case 2:
                        //Ввод через рандом
                        Random random = new Random();
                        for (int i = 0; i < N; i++)
                        {
                            //Ввод числа от 1 до 100 положительные
                            array[i] = random.Next(1, 101);
                            Console.WriteLine($"Случайное число {i + 1}:{array[i]}");

                        }
                        break;
                    default:
                        Console.WriteLine("Вы не выбрали как ввести массив! ");
                        goto M3;
                }
                Task3 peremennay3 = new Task3();
                bool result = peremennay3.Positive(array);
                Console.WriteLine(result ? "True" : "False");
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

            //Задание 4
            //Написать функцию int SumRangeOdd(A, B) целого типа,
            //находящую сумму всех нечетных целых чисел в диапазоне от A до B
            //включительно (A и B — целые положительные).
            //Если A > B, то функция должна возвращать число 0.
            Console.WriteLine("Задание 4");
            M4:
            try
            {
                int A1 = 0;
                Console.WriteLine("Введите число А");
                A1 = Convert.ToInt32(Console.ReadLine());
                int B1 = 0;
                Console.WriteLine("Введите число B");
                B1 = Convert.ToInt32(Console.ReadLine());

                Task4 peremennay4 = new Task4();
                int result2 = peremennay4.SumRangeOdd(A1, B1);
                Console.WriteLine($"Сумма квадратов чисел от {A1} до {B1} равна: {result2}");
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
        }
    }
}
