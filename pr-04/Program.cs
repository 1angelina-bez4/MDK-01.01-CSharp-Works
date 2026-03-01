using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace pr04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            M1:
            //Задание 1
            //Даны ненулевые числа x, y.
            //Проверить истинность высказывания:
            //«Точка с координатами (x, y) лежит в первой или четвертой координатной четверти».
            int x = 0;
            Console.WriteLine("Введите ненулевое число x:");
            x = Convert.ToInt32(Console.ReadLine());
            int y = 0;
            Console.WriteLine("Введите ненулевое число y:");
            y = Convert.ToInt32(Console.ReadLine());

            try
            {
                if (x != 0 && y != 0)
                {
                    if ((x > 0 && y > 0)||(x > 0 && y < 0))
                    {
                        Console.WriteLine(" Высказывание Истинно!\n" +
                        "Точка с координатами (x, y) лежит в первой или четвертой координатной четверти.");
                    }
                    else
                    {
                        Console.WriteLine(" Высказывание Ложное!\n" +
                        "Точка с координатами (x, y) не лежит в первой или четвертой координатной четверти.");
                        goto M1;
                    }  
                }
                else
                {
                    Console.WriteLine("Ошибка! Введены ненулевые числа! ");
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

            M2:
            //Задание 2
            //Дан целочисленный массив, состоящий из N элементов (N > 0).
            //Переставить в обратном порядке элементы массива,
            //расположенные между его минимальным и максимальным элементами,
            //не включая минимальный и максимальный элементы.
            Console.WriteLine("Задание 2:");
            int N = 0;
            Console.WriteLine("Введите число элементов массива:");
            N = Convert.ToInt32(Console.ReadLine());

            try
            {
                if( N > 0 && N <=25)
                {
                    Console.WriteLine("Выбрано верное количество элементов");
                }
                else
                {
                    Console.WriteLine("Ошибка: количество элементов должно быть больше 0  и не более 25");
                    goto M2;
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
                        goto M2;

                }
                //Выводим полученный массив
                Console.WriteLine($"Вывод полученого массива:");
                foreach (var item in array) //foreach Выполняет итерацию или перебор элементов. 
                                            // var помогает нам преобразовать в 32-разряд число
                                            // чтобы мы могли вывести массив без ошибик ToInt32
                {
                    Console.Write(item + " ");
                }
                //Находим индексы минимального и максимального элемента
                var min = array.Min();
                var max = array.Max();
                // Перестановка элементов между минимальным и максимальным
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] == min)
                        array[i] = max;
                    else if (array[i] == max)
                        array[i] = min;
                }
                //Выводим полученный массив
                Console.WriteLine($"Вывод полученого массива:");
                foreach (var item in array)
                {
                    Console.Write(item + " ");
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
        //Вводится строка, изображающая целочисленное арифметическое выражение вида
        //«число_число_число_число», где на месте знака операции «_»
        //находится символ «*» - умножение или «/» - деление, а на месте "число"
        //находится целочисленное значение (от 1 до 99). Например, «41*7/29*5».
        //Вывести значение данного выражения (как целое или вещественное значение).
        M3:
            Console.WriteLine("\nЗадание 3:");
            double result = 1;
            try
            {
                Console.WriteLine("Введите арифметическое выражение (например, 41*7/29*5):");
                string input = Console.ReadLine();
                // Разделяем строку на числа и операторы

                char[] operators = { '*', '/' };
                string[] tokens = input.Split(operators);

                // Начинаем с умножения для первого числа
                result = Convert.ToDouble(tokens[0]);
                char currentOperator = '*'; 
                // Проходим по всем токенам и вычисляем результат
                for (int i = 1; i < tokens.Length; i++)
                {
                    // 
                    char current = input[input.IndexOf(tokens[i]) - 1];
                    // Преобразуем текущее число в число с плавующей запятой
                    double currentNumber = Convert.ToDouble(tokens[i]);
                    if (current == '*')
                    {
                        result *= currentNumber;
                    }
                    else if (currentOperator == '/')
                    {
                        if (currentNumber == 0)
                        {
                            throw new DivideByZeroException("Деление на ноль недопустимо.");
                        }
                        result /= currentNumber;
                    }

                }
                // Выводим результат
                Console.WriteLine($"Результат: {result}");Я
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
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
                goto M3;
            }

            //Задание 4
            //Вводится строка, состоящая из слов,
            //разделенных подчеркиваниями (одним или несколькими).
            //Длина строки может быть разной.
            //Определить и вывести количество слов, начинающихся и заканчивающихся на одну и ту же букву.
            M4:
            Console.WriteLine("Задание 4");
            try
            {
                int count = 0;
                Console.WriteLine("Введите строку, состоящую из слов, разделенных подчеркиваниями:");
                string A = Console.ReadLine();

                // Разделяем строку по подчеркиваниям
                string[] words = A.Split(new char[] { '_' });
                
                foreach (string word in words) //foreach Выполняет итерацию или перебор элементов. 
                {
                    // Проверяем, что слово не пустое
                    if (word.Length > 0)
                    {
                        // Сравниваем первую и последнюю буквы
                        if (char.ToLower(word[0]) == char.ToLower(word[word.Length - 1]))
                        {
                            count++;
                        }
                    }
                }
                Console.WriteLine($"Количество слов, начинающихся и заканчивающихся на одну и ту же букву: {count}");
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
            //Вводится строка. В строке могут быть любые символы.
            //Длина строки может быть разной. Подсчитать и вывести количество
            //содержащихся в этой строке цифр, а так же сумму всех этих цифр.
            M5:
            Console.WriteLine("Задание 4");
            try
            {
                int Count = 0;
                int Sum = 0;
                Console.WriteLine("Введите строку:");
                string B = Console.ReadLine();

                foreach (char c in B)
                {
                    if (char.IsDigit(c)) // Проверяем, является ли символ цифрой
                    {
                        Count++;
                        Sum += c - '0'; // Преобразуем символ цифры в целое число
                    }
                }

                Console.WriteLine($"Количество цифр: {Count}");
                Console.WriteLine($"Сумма цифр: {Sum}");
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
