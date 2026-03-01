using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            M1:
            try
            { //Задание 1
                  //Проверить истинность высказывания:
                  //"Квадратное уравнение A·x2 + B·x + C = 0
                  //с данными коэффициентами A (A не равно 0), B, C имеет ровно один вещественный корень".
                Console.WriteLine("Задание1:");
                string[] Read = File.ReadAllLines("input1.txt");

                double A = Convert.ToDouble(Read[0]);
                double B = Convert.ToDouble(Read[1]);
                double C = Convert.ToDouble(Read[2]);

                using (StreamWriter writer = new StreamWriter("output1.txt"))
                {
                    string result;
                    if (A != 0)
                    {
                        //Считаем дискриминант
                        double Diskr = B * B - 4 * A * C;
                        //Смотрим имеет ли дискриминант один вещественный корень
                        if (Diskr == 0)
                        {
                            writer.WriteLine ("Высказывание истинно, дискриминант имеет один вещественный корень.");
                        }
                        else if (Diskr == 1)
                        {
                            writer.WriteLine( "Высказывание ложно, дискриминант имеет два вещественных корня.");
                            goto M1;
                        }
                        else
                        {
                            writer.WriteLine("Ошибка!Квадратное уравнение не имеет вещественных корней.");
                            goto M1;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Ошибка! А не должно быть равно 0!");
                        goto M1;
                    }
                }
                Console.WriteLine("Результат записан в файл: output1.txt");
            }
            catch (System.UnauthorizedAccessException ex1)
            {
                Console.WriteLine(ex1.Message);
                goto M1;
            }
            catch (System.ArgumentException ex2)
            {
                Console.WriteLine(ex2.Message);
                goto M1;
            }
            catch (DirectoryNotFoundException ex3)
            {
                Console.WriteLine(ex3.Message);
                goto M1;
            }
            catch (PathTooLongException ex4)
            {
                Console.WriteLine(ex4.Message);
                goto M1;
            }
            catch (System.IO.IOException ex5)
            {
                Console.WriteLine(ex5.Message);
                goto M1;
            }

            //задание 2
            //Даны пять целых ненулевых положительных чисел. Найти сумму двух наименьших чисел
            Console.WriteLine("Задание 2");
            M2:
            try
            {
                string[] input_2 = File.ReadAllLines("input2.txt");
                int[] numbers = new int[input_2.Length];

                for (int i = 0; i < input_2.Length; i++)
                {
                    numbers[i] = Convert.ToInt32(input_2[i]);
                }
                // Проверка на количество чисел
                if (numbers.Length != 5)
                {
                    Console.WriteLine("Ошибка! В файле должно быть ровно 5 целых ненулевых положительных чисел.");
                    goto M2;
                }

                
                // Сортировка массива для нахождения двух наименьших чисел
                Array.Sort(numbers);
                int sum = numbers[0] + numbers[1];

                using (StreamWriter writer = new StreamWriter("output2.txt"))
                {
                    writer.WriteLine("Cумма двух наименьших чисел: {0}", sum);
                }
                Console.WriteLine("Результат записан в файл: output2.txt");
            }
            catch (System.UnauthorizedAccessException ex1)
            {
                Console.WriteLine(ex1.Message);
                goto M2;
            }
            catch (System.ArgumentException ex2)
            {
                Console.WriteLine(ex2.Message);
                goto M2;
            }
            catch (DirectoryNotFoundException ex3)
            {
                Console.WriteLine(ex3.Message);
                goto M2;
            }
            catch (PathTooLongException ex4)
            {
                Console.WriteLine(ex4.Message);
                goto M2;
            }
            catch (System.IO.IOException ex5)
            {
                Console.WriteLine(ex5.Message);
                goto M2;
            }

            //задание 3
            //Дан целочисленный массив, состоящий из N элементов (N > 0).
            //Если в наборе имеются только положительные четные числа,
            //то вывести True; в противном случае вывести False.
            Console.WriteLine("Задание 3");
            M3:
            try 
            {
                string[] input_3 = File.ReadAllLines("input3.txt");
                int N = Convert.ToInt32(input_3[0]);

                int[] number_2 = new int[input_3.Length];
                // Проверка на положительные четные числа
                bool positiv = number_2.All(n => n > 0 && n % 2 == 0);

                using (StreamWriter writer = new StreamWriter("output3.txt"))
                {
                    writer.WriteLine( positiv);
                }
                Console.WriteLine("Результат записан в файл: output3.txt");
            }
            catch (System.UnauthorizedAccessException ex1)
            {
                Console.WriteLine(ex1.Message);
                goto M3;
            }
            catch (System.ArgumentException ex2)
            {
                Console.WriteLine(ex2.Message);
                goto M3;
            }
            catch (DirectoryNotFoundException ex3)
            {
                Console.WriteLine(ex3.Message);
                goto M3;
            }
            catch (PathTooLongException ex4)
            {
                Console.WriteLine(ex4.Message);
                goto M3;
            }
            catch (System.IO.IOException ex5)
            {
                Console.WriteLine(ex5.Message);
                goto M3;
            }

            //Задание 4 
            //Вводится строка, состоящая из слов разделенных точками.
            //Длина строки может быть разной. Сформировать и вывести подстроку,
            //расположенную между первой и второй точками исходной строки.
            //Если в строке менее двух точек, то вывести всю исходную строку.
            Console.WriteLine("Задание 4");
            string input_4 = "input4.txt";
            string output_4 = "output4.txt";
            M4:
            try
            {
                // Чтение входных данных из файла
                string inputString = File.ReadAllText(input_4).Trim();

                // Поиск индексов первой и второй точки
                int index_1 = inputString.IndexOf('.');
                int index_n = inputString.IndexOf('.', index_1 + 1);

                string result;

                if (index_1 != -1 && index_n != -1)
                {
                    // Извлечение подстроки между первой и второй точками
                    result = inputString.Substring(index_1 + 1, index_n - index_1 - 1);
                }
                else
                {
                    // Если точек меньше двух, выводим всю строку
                    result = inputString;
                }

                // Запись результата в выходной файл
                File.WriteAllText(output_4, result);
                Console.WriteLine($"Результат: {result}. Записано в файл {output_4}.");
            }
            catch (System.UnauthorizedAccessException ex1)
            {
                Console.WriteLine(ex1.Message);
                goto M4;
            }
            catch (System.ArgumentException ex2)
            {
                Console.WriteLine(ex2.Message);
                goto M4;
            }
            catch (DirectoryNotFoundException ex3)
            {
                Console.WriteLine(ex3.Message);
                goto M4;
            }
            catch (PathTooLongException ex4)
            {
                Console.WriteLine(ex4.Message);
                goto M4;
            }
            catch (System.IO.IOException ex5)
            {
                Console.WriteLine(ex5.Message);
                goto M4;
            }

            //задание 5 
            //Вводится строка,
            //изображающая целое число.
            //Длина строки может быть разной.
            //Вывести на экран произведение всех четных цифр этого числа.
            Console.WriteLine("Задание 5");
            string input_5 = "input5.txt";
            string output_5 = "output5.txt";
        M5:
            try
            {
                // Чтение входных данных из файла
                string inputNumber = File.ReadAllText(input_5).Trim();

                // Переменная для хранения произведения четных цифр
                long proiz = 1;
                bool chetn = false;

                // Обработка каждой цифры в строке
                foreach (char number in inputNumber)
                {
                    if (char.IsDigit(number))
                    {
                        int num = (int)char.GetNumericValue(number);
                        if (num % 2 == 0 && num != 0)
                        {
                            proiz *= num;
                            chetn = true;
                        }
                    }
                }

                // Если четные цифры не найдены, установить произведение в 0
                if (!chetn)
                {
                    proiz = 0;
                }

                // Запись результата в выходной файл
                File.WriteAllText(output_5, proiz.ToString());
                Console.WriteLine($"Произведение четных цифр: {proiz}. Записано в файл {output_5}.");
            }
            catch (System.UnauthorizedAccessException ex1)
            {
                Console.WriteLine(ex1.Message);
                goto M5;
            }
            catch (System.ArgumentException ex2)
            {
                Console.WriteLine(ex2.Message);
                goto M5;
            }
            catch (DirectoryNotFoundException ex3)
            {
                Console.WriteLine(ex3.Message);
                goto M5;
            }
            catch (PathTooLongException ex4)
            {
                Console.WriteLine(ex4.Message);
                goto M5;
            }
            catch (System.IO.IOException ex5)
            {
                Console.WriteLine(ex5.Message);
                goto M5;
            }
        }
    }
}
