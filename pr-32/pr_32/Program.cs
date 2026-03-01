using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace var4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {

                Console.WriteLine("Задание 1");
                Console.WriteLine("Проверить истинность высказывания: \"Данное целое число является четным двузначным числом\".");
            M1:
                Console.WriteLine("Введите целое положительное число: ");
                int number = Convert.ToInt32(Console.ReadLine());

                if (number > 0)
                {
                    EvenTwoDigitChecker task1 = new EvenTwoDigitChecker();
                    bool result1 = task1.IsEvenTwoDigit(number);
                    Console.WriteLine($"Истинность высказывания: {result1}");
                }
                else { Console.WriteLine("Ошибка!Число должно быть положительным"); goto M1; }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                Console.WriteLine("Задание 2");
                Console.WriteLine("Дан размер некоторого файла в байтах (целочисленное положительное ненулевое шестизначное число). Используя операцию деления нацело, найти количество полных килобайтов и мегабайтов, которые занимает данный файл (1 килобайт = 1024 байта, 1 мегабайт - 1024 килобайт).");
            M2:
                Console.WriteLine("Введите размер файла в байтах(целочисленное положительное ненулевое шестизначное число): ");
                int sizafile=Convert.ToInt32(Console.ReadLine());
                if (sizafile > 99999 & sizafile < 1000000)
                {
                    FileSizeConverter task2= new FileSizeConverter();
                    (int KB, int MB) result2 = task2.Convert(sizafile);
                    Console.WriteLine($"Файл в килобайтах и мегабайтах: {result2}");
                }
                else { Console.WriteLine("Ошибка!Число должно быть целочисленныс положительным ненулевым шестизначным числом."); goto M2; }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try 
            {
            M3:
                Console.WriteLine("Задание 3");
                Console.WriteLine("Дан целочисленный массив, состоящий из N элементов (N > 0). Проверить, образует ли данный набор возрастающую последовательность. Если образует, то вывести True, если нет - вывести False.");
                Console.WriteLine("Введите количество элементов массива (N > 25)");
                int N = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Выберите ввод массива 1 - вручную, 2 - рандомно");
                int vvod = Convert.ToInt32(Console.ReadLine());

                
                if (N > 25)
                {
                    int[] array = new int[N];

                    if (vvod == 1)
                    {
                        for (int i = 0; i < N; i++)
                        {
                            Console.Write($"Введите элемент {i + 1}: ");
                            array[i] = int.Parse(Console.ReadLine());
                            Console.Write(array[i]);
                        }

                        if (array == null || array.Length == 0)
                        {
                            Console.WriteLine("Массив не может быть пустым.");
                        }

                        AscendingSequenceChecker task3 = new AscendingSequenceChecker();
                        bool result3 = task3.IsAscending(array);
                        Console.WriteLine($"Проверка, образует ли данный набор возрастающую последовательность: {result3}");
                    }
                    else if (vvod == 2)
                    {
                        Random random = new Random();
                        for (int i = 0; i < N; i++)
                        {
                            array[i] = random.Next(-100, 100);
                            Console.Write(array[i]);
                        }

                        AscendingSequenceChecker task3 = new AscendingSequenceChecker();
                        bool result3 = task3.IsAscending(array);
                        Console.WriteLine($"Проверка, образует ли данный набор возрастающую последовательность: {result3}");
                    }
                    else { Console.WriteLine("Некорректный выбор ввода массива!"); goto M3; }
                }
                else { Console.WriteLine("Ошибка!Количество элементов массива должно быть больше 25."); goto M3; }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                Console.WriteLine("Задание 4");
                Console.WriteLine("Написать функцию double TriangleP(a) вещественного типа, вычисляющую по стороне a равностороннего треугольника его периметр P = 3·a (параметр a является вещественным). С помощью этой процедуры найти периметры трех равносторонних треугольников с данными сторонами.");
            M4:
                Console.WriteLine("Введите сторону треугольника: ");
                double a = Convert.ToDouble(Console.ReadLine());

                if (a > 0)
                {
                    TriangleCalculator task4= new TriangleCalculator();
                    double result4 = task4.TriangleP(a);
                    Console.WriteLine($"Периметр равностороннего треугольника равен: {result4}");
                }
                else { Console.WriteLine("Ошибка!Сторона треугольника должна быть больще 0."); goto M4; }
            
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                Console.WriteLine("Задание 5");
                Console.WriteLine("Вводится строка, состоящая из слов (разделенных знаком равенства - '='), содержащая, по крайней мере, один символ '='. Длина строки может быть разной. Вывести подстроку, расположенную между вторым и третьим знаком '=' исходной строки. Если строка содержит менее 3-х символов '=', то вывести всю строку.");
            M5:
                Console.WriteLine("Введите строку, состоящую из слов (разделенных знаком равенства - '='): ");
                string input = Console.ReadLine();

                if (string.IsNullOrEmpty(input)) { Console.WriteLine("Строка не может быть пустой."); goto M5; }

                SubstringExtractor task5 = new SubstringExtractor();
                string result5 = task5.ExtractBetweenSecondAndThirdEqual(input);
                Console.WriteLine($"Итоговая строка: {result5}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
