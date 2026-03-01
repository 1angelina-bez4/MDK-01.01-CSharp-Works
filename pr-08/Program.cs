using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr08
{
    internal class Program
    {
        //Метод забирает числа и считает дискриминант и находит корни
        static double Method(double A, double B, double C)
        {
            //находим дискриминант
            double diskr = B * B - 4 * A * C; 
            
            if(diskr < 0)
            {
                Console.WriteLine("NO"); //Корней нет
            }
            else if (diskr ==0)
            {
                //Находим единственный корень 
                double root = -B / 2 * A;
                Console.WriteLine($"Корень равен {root}");
            }
            else
            {
                // если больше 0 то Находим два корня
                double root1 = (-B - Math.Sqrt(diskr)) / (2 * A);
                double root2 = (-B + Math.Sqrt(diskr)) / (2 * A);
                Console.WriteLine($"Корни: {Math.Min(root1, root2)} и {Math.Max(root1, root2)}"); 
            }
            return diskr;
        }
        //метод выводящий правду  и ложь 
        static bool Positive(int[] array)
        {
            foreach (var item in array)
            {
                if (item <= 0 || item % 2 != 0)
                {
                    return false; // Если хотя бы одно число не положительное или не четное
                }
            }
            return true; // Все числа положительные и четные
        }

        //метод счетчика букв 'w'
        static int Count(string word)
        {
            int count = 0; //счетчик приравен к 0
            foreach (char c in word)
            {
                if (c == 'w' || c == 'W') // Считаем  'w'
                {
                    count++; //счетчик +1
                }
            }
            return count;
        }

        //метод сравнения
        static int SumOfSquares(int A1, int B1)
        {
            if (A1 > B1)
            {
                return 0; // Если A больше B, возвращаем 0
            }

            int sum = 0;
            for (int i = A1; i <= B1; i++)
            {
                sum += i * i; // Суммируем 
            }
            return sum; // Возвращаем результат
        }

        //
        static double RingS(double R1, double R2)
        {
            const double pi = 3.14; // Значение π
            double areaOuterCircle = pi * R1 * R1; // Площадь внешней окружности
            double areaInnerCircle = pi * R2 * R2; // Площадь внутренней окружности
            double ringArea = areaOuterCircle - areaInnerCircle; // Площадь кольца

            return ringArea; // Возвращаем результат
        }

        static void Main(string[] args)
        {
            M1:
            //Выбираем задание
            int Task = 0;
            Console.WriteLine("Выберите задание с 1 по 5");
            Task = Convert.ToInt32(Console.ReadLine());
             
            
            switch (Task)
            {
                case 1:

                    //Задание 1
                    //Даны три целых числа - это коэффициенты A, B, C
                    //квадратного уравнения A·x2 + B·x + C = 0 (A не равно 0).
                    //Найти корни данного уравнения.
                    //Корни вычисляются как вещественные числа.
                    //Если имеются два различных корня, то вначале выводить меньший,
                    //а затем больший (каждый на новой строке).
                    //Если корней нет, то вывести «NO».
                    Console.WriteLine("Задание1");
                    M2:
                    try
                    {
                        //Вводим коэффициенты с клавиатуры
                        double A = 0;
                        Console.WriteLine("Введите коэффициента А (A должно быть не равно 0!):");
                        A = Convert.ToInt32(Console.ReadLine());
                        double B = 0;
                        Console.WriteLine("Введите коэффициента B:");
                        B = Convert.ToInt32(Console.ReadLine());
                        double C = 0;
                        Console.WriteLine("Введите коэффициента C:");
                        C = Convert.ToInt32(Console.ReadLine());

                        //Проверяем что A!=0
                        if (A == 0)
                        {
                            Console.WriteLine("Ошибка! Коэффициент А  не должен быть равен 0!");
                            goto M2;
                        }

                        //Выводим результат 
                        double result = Method( A,B,C);
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
                    break;
                case 2:
                    //Задание 2
                    //Дан целочисленный массив, состоящий из N элементов (N > 0).
                    //Если в наборе имеются только положительные четные числа,
                    //то вывести True; в противном случае вывести False.
                    Console.WriteLine("Задание 2:");
                    int N = 0;
                    Console.WriteLine("Введите число элементов массива:");
                    N = Convert.ToInt32(Console.ReadLine());

                    M3:
                    try
                    {
                        if ( N > 0 && N <= 25)
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
                                goto M3;

                        }
                        //вывод результата
                        bool result1 = Positive(array);
                        Console.WriteLine(result1 ? "True" : "False");
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
                    break;
                case 3:
                    //Задание 3
                    //Вводится строка-предложение на английском языке.
                    //Длина строки может быть разной. Определить и вывести слово,
                    //содержащего наибольшеечисло символов 'w'.
                    Console.WriteLine("Задание 3");
                    M4:
                    try
                    {
                        //вводим строку
                        Console.WriteLine("Введите строку - предложение на английском языке:");
                        string input = Console.ReadLine();
                        string[] words = input.Split(new char[] { ' ', ',', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
                        //переменая слов с 'w'
                        string wordW = "";
                        //счетчик максимального количества 'w'
                        int maxWCount = 0;
                        //Находим слово с наибольшим количеством 'w'
                        foreach (string word in words)
                        { 
                            //берем значения из нашего метода счетчика 'w'
                            int wCount = Count(word);
                            //находим слово
                            if (wCount > maxWCount)
                            {
                                maxWCount = wCount;
                                wordW = word;
                            }
                        }
                        Console.WriteLine(wordW); 
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
                    break;
                case 4:
                    //Задание 4
                    //Написать функцию int SumOfSquares(A, B) целого типа,
                    //находящую сумму квадратов всех целых чисел в диапазоне от A до B.
                    //Если A > B, то функция должна возвращать число 0.
                    Console.WriteLine("Задание 4");
                    M5:
                    try
                    {
                        int A1 = 0;
                        Console.WriteLine("Введите число А");
                        A1 = Convert.ToInt32(Console.ReadLine());
                        int B1 = 0;
                        Console.WriteLine("Введите число B");
                        B1 = Convert.ToInt32(Console.ReadLine());

                        int result2 = SumOfSquares(A1, B1);
                        Console.WriteLine($"Сумма квадратов чисел от {A1} до {B1} равна: {result2}");
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
                    break;
                case 5:
                    //Задание 5
                    //Написать функцию double RingS(R1, R2) вещественного типа,
                    //находящую площадь кольца, заключенного между двумя окружностями
                    //с общим центром и радиусами R1 и R2 (R1 и R2 — вещественные, R1 > R2).
                    //Воспользоваться формулой площади круга радиуса R: S = π·R2.
                    //В качестве значения π использовать 3.14.
                    Console.WriteLine("Задание 5");

                     M6:
                    try
                    {
                        double R1 = 0;
                        Console.WriteLine("Введите первый радиус R1:");
                        R1 = Convert.ToDouble(Console.ReadLine());
                        double R2 = 0;
                        Console.WriteLine("Введите первый радиус R2:");
                        R2 = Convert.ToDouble(Console.ReadLine());

                        if (R1 <= R2)
                        {
                            Console.WriteLine("Ошибка: R1 должно быть больше R2.");
                        }
                        else
                        {
                            double area = RingS(R1, R2);
                            Console.WriteLine($"Площадь кольца: {area}");
                        }
                    }
                    catch (System.FormatException ex)
                    {
                        Console.WriteLine("Сообщение об ошибке: " + ex.Message);
                        goto M6;
                    }
                    catch (System.OverflowException ex1)
                    {
                        Console.WriteLine("Сообщение об ошибке: " + ex1.Message);
                        goto M6;
                    }
                    break;
                default:
                    Console.WriteLine("Вы не выбрали задание! ");
                    goto M1;
            }
        }
    }
}
