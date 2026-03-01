using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr09
{
    internal class Program
    {

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
            try
            {
                //Задание 1 
                //Даны три целых числа: A, B, C.
                //Проверить истинность высказывания: «Ровно одно из чисел A, B, C положительное».
                Console.WriteLine("Задание 1");
                string[] Read = File.ReadAllLines("input1.txt");
                
                double A = Convert.ToDouble(Read[0]);
                double B = Convert.ToDouble(Read[0]);
                double C = Convert.ToDouble(Read[0]);

                int[] number1 = new int[Read.Length];
                using (StreamWriter writer = new StreamWriter("output1.txt"))
                {
                    string Result;
                    if (A > 0 || B > 0 || C > 0)
                    {
                        bool F = true;
                        writer.WriteLine(F);
                    }
                    else
                    {
                        bool F = false;
                        writer.WriteLine(F);
                    }
                }
                Console.WriteLine("Результат записан в файл: output1.txt");
            }
            catch (System.UnauthorizedAccessException ex1)
            {
                Console.WriteLine(ex1.Message);
            }
            catch (System.ArgumentException ex2)
            {
                Console.WriteLine(ex2.Message);
            }
            catch (DirectoryNotFoundException ex3)
            {
                Console.WriteLine(ex3.Message);
            }
            catch (PathTooLongException ex4)
            {
                Console.WriteLine(ex4.Message);
            }
            catch (System.IO.IOException ex5)
            {
                Console.WriteLine(ex5.Message);
            }
             //Задание 2 
             //Дан целочисленный массив, состоящий из N элементов (N > 0).
            //Поменять местами минимальный и максимальный элемент этого массива.
            //Вывести новый полученный массив.
            try
            {
                // Определяем пути к файлам
                string inputFilePath = "input2.txt";
                string outputFilePath = "output2.txt";
                Console.WriteLine("Задание 2");

               //Читаем с файла 
                string[] inputLines = File.ReadAllLines(inputFilePath);

                // Преобразуем первую строку в количество элементов
                int N = Convert.ToInt32(inputLines[0]);
                int[] array = new int[N];

                // Заполняем массив значениями из файла
                for (int i = 0; i < N; i++)
                {
                    array[i] = Convert.ToInt32(inputLines[i + 1]); // Считываем значения начиная со второй строки
                }
                int max = array[0];
                int indMax = 0;
                int min = array[0];
                int indMin = 0;
                // Поиск минимального и максимального элементов
                for (int i = 0; i < N; i++)
                {
                    if (array[i] > max)
                    {
                        max = array[i];
                        indMax = i;
                    }
                    if (array[i] < min)
                    {
                        min = array[i];
                        indMin = i;
                    }
                }

                // Меняем местами минимальный и максимальный элементы
                if (indMax != indMin) // Убедимся, что индексы разные
                {
                    int temp = array[indMax];
                    array[indMax] = array[indMin];
                    array[indMin] = temp;
                }

                // Записываем новый массив в файл
                using (StreamWriter writer = new StreamWriter(outputFilePath))
                {
                    for (int i = 0; i < N; i++)
                    {
                        writer.WriteLine(array[i]);
                    }
                }
                Console.WriteLine("Результат записан в файл: " + outputFilePath);
            }
            catch (System.UnauthorizedAccessException ex1)
            {
                Console.WriteLine(ex1.Message);
            }
            catch (System.ArgumentException ex2)
            {
                Console.WriteLine(ex2.Message);
            }
            catch (DirectoryNotFoundException ex3)
            {
                Console.WriteLine(ex3.Message);
            }
            catch (PathTooLongException ex4)
            {
                Console.WriteLine(ex4.Message);
            }
            catch (System.IO.IOException ex5)
            {
                Console.WriteLine(ex5.Message);
            }
            catch (System.IndexOutOfRangeException ex6)
            {
                Console.WriteLine(ex6.Message);
            }

            //Задание 3
            //Вводится строка, состоящая из слов разделенных точками.
            //Длина строки может быть разной.
            //Сформировать и вывести подстроку, расположенную между третьей
            //и четвертой точками исходной строки. Если в строке менее двух точек,
            //то вывести всю исходную строку.
            Console.WriteLine("Задание 3");
            // Определяем пути к файлам
            string input_3 = "input3.txt";
            string output_3 = "output3.txt";

            try
            {
                // Чтение входных данных из файла
                string inputString = File.ReadAllText(input_3).Trim();

                //находим 3 и 4 точку 
                int index_1 = inputString.IndexOf('.',0);
                int index_2 = inputString.IndexOf('.', index_1 + 1);
                int index_3 = inputString.IndexOf('.', index_2 + 1);
                int index_4 = inputString.IndexOf('.', index_3 + 1);

                string result;

                if (index_3 != -1 && index_4 != -1)
                {
                    // Извлечение подстроки между третьей  и четвертой точкой
                    result = inputString.Substring(index_3 + 1, index_4 - index_3 - 1);
                }
                else
                {
                    // Если точек меньше двух, выводим всю строку
                    result = inputString;
                }

                // Запись результата в выходной файл
                File.WriteAllText(output_3, result);
                Console.WriteLine($"Результат: {result}. Записано в файл {output_3}.");
            }
            catch (System.UnauthorizedAccessException ex1)
            {
                Console.WriteLine(ex1.Message);
            }
            catch (System.ArgumentException ex2)
            {
                Console.WriteLine(ex2.Message);
            }
            catch (DirectoryNotFoundException ex3)
            {
                Console.WriteLine(ex3.Message);
            }
            catch (PathTooLongException ex4)
            {
                Console.WriteLine(ex4.Message);
            }
            catch (System.IO.IOException ex5)
            {
                Console.WriteLine(ex5.Message);
            }
            catch (System.IndexOutOfRangeException ex6)
            {
                Console.WriteLine(ex6.Message);
            }

            //Задание 4
            //Написать функцию int SumOfSquares(A, B) целого типа,
            //находящую сумму квадратов всех целых чисел в диапазоне от A до B.
            //Если A > B, то функция должна возвращать число 0.
            Console.WriteLine("Задание 4");
            try
            {
                string[] Read_2 = File.ReadAllLines("input4.txt");

                int A1 = Convert.ToInt32(Read_2[0]);
                int B1 = Convert.ToInt32(Read_2[1]);

                int[] number2 = new int[Read_2.Length];
                using (StreamWriter writer = new StreamWriter("output4.txt"))
                {
                    int result2 = SumOfSquares(A1, B1);
                    Console.WriteLine($"Сумма квадратов чисел от {A1} до {B1} равна: {result2}");
                }
                Console.WriteLine("Результат записан в файл: output4.txt");
            }
            catch (System.FormatException ex)
            {
                Console.WriteLine("Сообщение об ошибке: " + ex.Message);
            }
            catch (System.OverflowException ex1)
            {
                Console.WriteLine("Сообщение об ошибке: " + ex1.Message);
            }

            //Написать функцию double RingS(R1, R2) вещественного типа,
            //находящую площадь кольца, заключенного между
            //двумя окружностями с общим центром и радиусами R1 и R2 (R1 и R2 — вещественные, R1 > R2).
            //Воспользоваться формулой площади круга радиуса R: S = π·R2. В качестве значения π использовать 3.14.
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
                string[] Read_3 = File.ReadAllLines("input5.txt");

                double R1 = Convert.ToDouble(Read_3[0]);
                double R2 = Convert.ToDouble(Read_3[1]);

                int[] number2 = new int[Read_3.Length];
                using (StreamWriter writer = new StreamWriter("output4.txt"))
                {
                    double result2 = RingS(R1, R2);
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
                Console.WriteLine("Результат записан в файл: output4.txt");      
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
        }

    }
}
