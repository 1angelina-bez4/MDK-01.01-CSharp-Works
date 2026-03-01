using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задание 1 
            Console.WriteLine("Задание 1");
            //Дано пятизначное целое положительное число N (N>0).
            //Проверить истинность высказывания: "Все цифры данного числа различны"
        M1:
            try

            {
                int N = 0;
                Console.WriteLine("Введите пятизначное положительное число:");
                N = Convert.ToInt32(Console.ReadLine());

                if (N < 100000 && N > 9999)
                {

                    int A = (N / 10000) % 10; //Находим первое число
                    int B = (N / 1000) % 10; //Находим второе число
                    int C = (N / 100) % 10; //Находим третье число
                    int D = (N / 10) % 10; //Находим четвертое число
                    int F = N % 10; //Находим пятое число 

                    if (A != B && A != C && A != D && A != F && B != C && B != D && B != F && C != F && C != D && D != F)
                    {
                        Console.WriteLine(" Высказывание являеться истенным -\"Все цифры данного числа различны\"");
                    }
                    else
                    {
                        Console.WriteLine("Высказывание являеться ложным -\"Все цифры данного числа различны\"");
                        goto M1;
                    }
                }
                else 
                {
                    Console.WriteLine("Ошибка!Число не  пятизначное!");
                    goto M1;
                }
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

        //Задание  2 
        Console.WriteLine("Задание 2");
        //Задано целое положительное четырехзначное число N (N > 0).
        //Найти разницу между суммой всех его цифр и произведением нечетных цифр.
        M2:
            try

            {
                int N1 = 0;
                Console.WriteLine("Введите четырёхзначное  положительное число:");
                N1 = Convert.ToInt32(Console.ReadLine());

                int B1 = (N1 / 1000) % 10; //Находим 1 число
                int C1 = (N1 / 100) % 10; //Находим 2 число
                int D1 = (N1 / 10) % 10; //Находим 3 число
                int F1 = N1 % 10; //Находим 4 число

                if (N1>0)
                {
                    double sum = B1 + C1 + D1 + F1;
                    Console.WriteLine($"Сумма равна:{sum} ");
                    double comp = B1 * D1;
                    Console.WriteLine($"Произведение нечетных чисел   равно:{comp} ");
                    double diff = sum - comp;
                    Console.WriteLine($"Разность между суммой и произведением   равна:{diff} ");
                }
                else
                {
                    Console.WriteLine("Ошибка! Число < 0");
                    goto M2;
                }
            }
            catch (System.FormatException ex)
            {
                Console.WriteLine("Сообщение об ошибке: " + ex.Message);
                goto M2;
            }
            catch (System.OverflowException ex1)
            {
                Console.WriteLine("Сообщение об ошибке: " + ex1.Message);
                goto M2;
            }

            //Задание 3
            Console.WriteLine("Задание 3");
            //В вещественном массиве известны данные о количестве осадков,
            //выпавших за каждый день месяца N (N - любой месяц в году).
            //Найти общее число осадков, выпавших по нечетным числам этого месяца.
            //Предоставить возможность пользователю реализовать заполнение массива случайными (рандомными) числами

        M3:
            try
            {
                int month = 0;
                Console.WriteLine("Введите месяц от 1 до 12");
                month =Convert.ToInt32(Console.ReadLine());

                if (month > 0 && month < 13 )
                {
                    // проверяем количество дней в веденном нами месяце 
                    int day = DateTime.DaysInMonth(DateTime.Now.Year, month);
                    //Создаем массив и выводим количество элементов
                    int[] array = new int[day];
                    //Выбор ввода массива
                    int Vvod = 0;
                    Console.WriteLine("Выберете ввод чисел ( 1- через консоль, 2 - через рандом):");
                    Vvod = Convert.ToInt32(Console.ReadLine());
                    switch (Vvod)
                    {
                        case 1:
                            //Ввод с клавиатуры

                            for (int i = 0; i < day; i++)
                            {
                                Console.WriteLine($"Число {i + 1}:");
                                array[i] = Convert.ToInt32(Console.ReadLine());
                            }
                            break;
                        case 2:
                            //Ввод через рандом
                            Random random = new Random();
                            for (int i = 0; i < day; i++)
                            {
                                //Ввод числа от 1 до 100 положительные
                                array[i] = random.Next(1, 101);
                                Console.WriteLine($"Случайное число {i + 1}:{array[i]}");

                            }
                            break;
                        default:
                            Console.WriteLine("Вы не выбрали как ввести массив! ");
                            goto M2;

                    }
                    //Выводим полученный массив
                    Console.WriteLine($"Вывод полученных осадков :");
                    foreach (var item in array) //foreach Выполняет итерацию или перебор элементов. 
                                                // var помогает нам преобразовать в 32-разряд число
                                                // чтобы мы могли вывести массив без ошибик ToInt32
                    {
                        Console.Write(item + " ");
                    }

                    // Выводим массив осадков
                    Console.WriteLine("Количество осадков за каждый день:");
                    for (int i = 0; i < day; i++)
                    {
                        Console.WriteLine($"День {i + 1}: {array[i]} мм");
                    }

                    // Вычисляем общее количество осадков по нечетным дням
                    double Days = 0;

                    for (int i = 0; i < day; i++)
                    {
                        if ((i + 1) % 2 != 0) // Проверяем, является ли день нечетным
                        {
                            Days += array[i];
                        }
                    }
                    Console.WriteLine($"Общее количество осадков по нечетным дням: {Days} мм");
                }
                else 
                {
                    Console.WriteLine("Ошибка введите месяц ОТ 1 ДО 12.");
                    goto M3;
                }

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
            Console.WriteLine("Задание 4");
            //Вводится строка-предложение.
            //Длина строки может быть разной.
            //Подсчитать количество содержащихся в строке знаков препинания
            //(точка, запятая, двоеточие, точка с запятой, восклицательный знак, вопросительный знак).

            M4:
            try
            {
                //Задаем ввод числа 
                int R = 0;
                Console.Write("Введите целое число: ");
                string  P = Console.ReadLine();

                // Проходим по каждому символу в строке
                foreach (char c in P)
                {
                    // Проверяем, является ли символ цифрой
                    if (char.IsDigit(c))
                    {
                        int number = c - '0'; // Преобразуем символ в целое число

                        // Проверяем, является ли цифра четной
                        if (number % 2 == 0 && number != 0)
                        {
                            R *= number; // Умножаем на четную цифру
                            Console.WriteLine($"Произведение всех четных цифр: {R}");
                        }
                        else
                        {
                            Console.WriteLine("Нет четных цифр в введенном числе.");
                            goto M4;
                        }
                    }
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

            //Задание 5
            Console.WriteLine("Задание 5");
            //Вводится строка, состоящая из слов,
            //разделенных подчеркиваниями (одним или несколькими).
            //Длина строки может быть разной. Определить и вывести количество слов в строке.

        M5:
            try
            {
                int count = 0; // Счетчик чисел
                int sum = 0;   // Сумма чисел

                //Вводим строку
                Console.Write("Введите строку: ");
                string  Q = Console.ReadLine();

                
                // Проходим по каждому символу в строке
                foreach (char l in Q)
                {
                    // Проверяем, является ли символ цифрой
                    if (char.IsDigit(l))
                    {
                        int number1 = l - '0'; // Преобразуем символ в целое число
                        sum += number1;         // Добавляет к сумме
                        count++;              // Увеличиваем счетчик
                    }
                }

                // Выводим результаты
                Console.WriteLine($"Количество чисел: {count}");
                Console.WriteLine($"Сумма чисел: {sum}");
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
