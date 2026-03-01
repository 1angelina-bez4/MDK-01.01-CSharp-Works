using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace pr03
{
    internal class Program
    {
        static void Main(string[] args)
        {
           M1:
           try
           { 
                //Создаем переменные,числа A,B,C
                Console.WriteLine("Задание 1:");
                int A = 0;
                int B = 0;
                int C = 0;
                Console.WriteLine("Введите число A:");
                A = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите число B:");
                B = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите число C:");
                C = Convert.ToInt32(Console.ReadLine());

                //Проверяем на положительность чисел

                if (A > 0 && B > 0 && C > 0 && A!=0 && B!=0 && C!=0)
                {
                    Console.WriteLine("Высказование является истинным: Каждое из чисел A, B, C положительное");
                }
                else
                {
                    Console.WriteLine("Высказование является ложным! Одно из чисел или все числа отрицательные!");
                    goto M1;
                }
           }

            //Выводим ошибки,которые могут возникнуть
           catch (System.FormatException ex)
           {
                Console.WriteLine("Сообщение об ошибке:" + ex.Message.ToString());
                goto M1;
            }
           catch (System.OverflowException ex1)
           {
                Console.WriteLine("Сообщение об ошибке:" + ex1.Message.ToString());
                goto M1;
            }


            //Задание 2
            M2:
            try
            {
                //задаем шесть чисел ввода с консоли через массив 
                Console.WriteLine("Задание 2:");
                int[] numb = new int[6];
                int D = 0;
                //Определяем ввод  массива
                Console.WriteLine("Выберете ввод чисел ( 1- через консоль, 2 - через рандом):");
                D = Convert.ToInt32(Console.ReadLine());

                switch (D)
                {
                    case 1:
                        //Ввод с клавиатуры
                        Console.WriteLine("Введите 6 целых чисел:");

                        for (int i = 0; i < 6; i++)
                        {
                            Console.WriteLine($"Число {i + 1}:");
                            numb[i] = Convert.ToInt32(Console.ReadLine());

                        }
                        break;
                    case 2:
                        //Ввод через рандом
                        Random random = new Random();
                        for (int i = 0; i < 6; i++)
                        {
                            //Ввод числа от 1 до 100
                            numb[i] = random.Next(1, 101);
                            Console.WriteLine($"Случайное число {i + 1}:{numb[i]}");
                        }
                        break;
                    default:
                        Console.WriteLine("Вы не выбрали как ввести массив! ");
                        goto M2;
                }

                Array.Sort(numb);
                int sum = numb[0] + numb[1];
                double average = sum / (double)numb.Length;
                Console.WriteLine($"среднее арифметическое этих введенных чисел: {average}");
            }
            //Выводим ошибки,которые могут возникнуть
            catch (System.FormatException ex)
            {
                Console.WriteLine("Сообщение об ошибке:" + ex.Message.ToString());
            }
            catch (System.OverflowException ex1)
            {
                Console.WriteLine("Сообщение об ошибке:" + ex1.Message.ToString());
            }

            //Задание 3
             M3:
            try
            {
                Console.WriteLine("Задание 3:");
                //Создаем массив 
                double[] numb1 = new double[25];
                //Выбор ввода массива
                int  Vvod = 0;
                Console.WriteLine("Выберете ввод чисел ( 1- через консоль, 2 - через рандом):");
                Vvod = Convert.ToInt32(Console.ReadLine());
                int pol = 0; //Положительные числа
                int otr = 0; //Отрицательные числа

                switch (Vvod)
                {
                    case 1:
                        
                        //Ввод с клавиатуры
                        for (int i = 0; i < numb1.Length; i++)
                        {
                            Console.WriteLine($"Число {i + 1}:");
                            numb1[i] = Convert.ToInt32(Console.ReadLine());

                            if (numb1[i] > 0 && numb1[i] % 2 == 0 && numb1[i]<0 && numb1[i]!=0)
                            {
                                Console.WriteLine("Введен целочисленный массив.");

                            }
                            else
                            {
                                Console.WriteLine("Ошибка введен не целочисленный массив!");
                                goto M3;
                            }
                        }
                        break;
                    case 2:
                        //Ввод через рандом
                        Random random = new Random();
                        for (int i = 0; i < numb1.Length; i++)
                        {
                            //Ввод числа от 1 до 100 положительные
                            numb1[i] = random.Next(-101, 101);
                            Console.WriteLine($"Случайное число {i + 1}:{numb1[i]}");
                        }
                        break;
                    default:
                        Console.WriteLine("Вы не выбрали способ ввода массива! ");
                        goto M3;
                }
                // Выводим полученный массив
                Console.WriteLine($"Полученный массив: {string.Join(", ", numb1)}");
                Array.Sort(numb1);
                Console.WriteLine($"Отсортированный массив: {string.Join(", ", numb1)}");

                while (pol < numb1.Length && otr < numb1.Length)
                {
                    //находим первые элемент , положительный и отрицательный
                    while (pol < numb1.Length && numb1[pol] <= 0) pol++;
                    // Найти первый отрицательный элемент
                    while (otr < numb1.Length && numb1[otr] >= 0) otr++;

                    if (pol < numb1.Length && otr < numb1.Length)
                    {
                        // Меняем местами
                        double temp = numb1[pol];
                        numb1[pol] = numb1[otr];
                        numb1[otr] = temp;

                        pol++; // Переходим к следующему положительному элементу
                        otr++; // Переходим к следующему отрицательному элементу
                    }
                }

                // Выводим измененный массив
                Console.WriteLine($"Измененный массив:{string.Join(", ", numb1)}");
            }

            //Выводим ошибки,которые могут возникнуть
            catch (System.FormatException ex)
            {
                Console.WriteLine("Сообщение об ошибке:" + ex.Message.ToString());
            }
            catch (System.OverflowException ex1)
            {
                Console.WriteLine("Сообщение об ошибке:" + ex1.Message.ToString()); 
            }

            //Задание 4
            M4:
            try
            {
                Console.WriteLine("Задание 4:");
                //Создаем массив 
                double [] numb2 = new double[30];
                //Выбор ввода массива
                int Vvod1 = 0;
                Console.WriteLine("Выберете ввод чисел ( 1- через консоль, 2 - через рандом):");
                Vvod1 = Convert.ToInt32(Console.ReadLine());

                switch (Vvod1)
                {
                    case 1:
                        //Ввод с клавиатуры

                        for (int i = 0; i < numb2.Length; i++)
                        {
                            Console.WriteLine($"Число {i + 1}:");
                            numb2[i] = Convert.ToInt32(Console.ReadLine());
                        }
                        break;
                    case 2:
                        //Ввод через рандом
                        Random random = new Random();
                        for (int i = 0; i < numb2.Length; i++)
                        {
                            //генерация осадков от 0 до 100
                            numb2[i] = Math.Round(random.NextDouble() * 100);
                            Console.WriteLine($"Случайное число {i + 1}:{numb2[i]}");

                        }
                        break;
                    default:
                        Console.WriteLine("Вы не выбрали как ввести массив! ");
                        goto M4;
                }
                for (int n = 0; n < 3; n++)
                {
                    double G = 0;

                    for (int day = n * 10; day < (n + 1) * 10; day++)
                    {
                        G += numb2[day];
                    }

                    Console.WriteLine($"Общее количество осадков за декаду {n + 1}: {G} мм");
                }
            }
                 //Выводим ошибки,которые могут возникнуть
            catch (System.FormatException ex)
            {
                Console.WriteLine("Сообщение об ошибке:" + ex.Message.ToString());
            }
            catch (System.OverflowException ex1)
            { Console.WriteLine("Сообщение об ошибке:" + ex1.Message.ToString()); }

            //Задание 5
            M5:
            try
            {
                Console.WriteLine("Задание 5:");
                //Создаем массив 
                double[] numb3 = new double[25];
                //Выбор ввода массива
                int Vvod2 = 0;
                Console.WriteLine("Выберете ввод чисел ( 1- через консоль, 2 - через рандом):");
                Vvod2 = Convert.ToInt32(Console.ReadLine());
                double Sum = 0;
                switch (Vvod2)
                {
                    case 1:
                        //Ввод с клавиатуры
                        Console.WriteLine("Вводите ненулевые числа для массива:");
                        for (int i = 0; i < numb3.Length; i++)
                        {
                            Console.WriteLine($"Число {i + 1}:");
                            numb3[i] = Convert.ToInt32(Console.ReadLine());

                            if (numb3[i] != 0 && numb3[i]>0 )
                            {
                                Console.WriteLine("Все введенные числа ненулевые");
                            }
                            else
                            {
                                Console.WriteLine("Ошибка! Нужно ввести ненулевые числа!" );
                                goto M5;
                            }
                        }
                        break;
                    case 2:
                        //Ввод через рандом
                        Random random = new Random();
                        for (int i = 0; i < numb3.Length; i++)
                        {
                            //Ввод числа от 1 до 100
                            numb3[i] = random.Next(1, 101);
                            Console.WriteLine($"Случайное число {i + 1}:{numb3[i]}");
                        }
                        break;
                    default:
                        Console.WriteLine("Вы не выбрали как ввести массив! ");
                        goto M5;
                }

                //Выводим положительные нечетные числа и находим их сумму
                Console.WriteLine($"Все положительные нечетные числа из данного набора:");

                for (int i = 0; i < numb3.Length; i++)
                {
                    if (numb3[i] > 0 && numb3[i] % 2 != 0)
                    {
                        Console.WriteLine(numb3[i]);
                        Sum = numb3.Sum();
                        Console.WriteLine($"Сумма= {Sum}");
                        break;
                    }
                    //Если нет таких чисел выводим 1
                    else
                    {
                        Console.WriteLine("1");
                    }
                }
            }
            //Выводим ошибки,которые могут возникнуть
            catch (System.FormatException ex)
            {
                Console.WriteLine("Сообщение об ошибке:" + ex.Message.ToString());
            }
            catch (System.OverflowException ex1)
            { Console.WriteLine("Сообщение об ошибке:" + ex1.Message.ToString()); }
        }    
    }
}
