using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace var4
{
    class Program
    {
        public static double CircleS(double R)
        {
            double S = Math.PI * R * R;
            return S;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(" Задание 1 -Проверить истинность высказывания: 'Данное целое положительное число является нечетным трехзначным числом' ");
            
            try
            {
                //открываем содержимое 
                RegistryKey myKey = Registry.CurrentUser;
                RegistryKey pract = myKey.OpenSubKey("Pr_17b");
                RegistryKey task1 = pract.OpenSubKey("task1");

                Console.WriteLine("Введите целое положительное нечетное трехзначное  число: ");
                int number = Convert.ToInt32(Console.ReadLine());

                bool result01;

                if (number > 99 && number < 1000 && number %2 !=0 )
                {
                    result01 = true;
                }
                else
                {
                    result01 = false;
                }
                // Запись в реестр
                Registry.SetValue(task1.Name, "inputNumber", number);
                Registry.SetValue(task1.Name, "result01", result01);
                Console.WriteLine("Число и результат записаны в реестр.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            
            }
            finally
            {
                // Удаление подкаталога PR_17 из реестра после завершения работы программы
                try
                {
                    Registry.CurrentUser.DeleteSubKeyTree(@"PR_17");
                    Console.WriteLine("Подкаталог PR_17 удален из реестра.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Не удалось удалить подкаталог PR_17: {ex.Message}");
                }
            }

            Console.WriteLine("Задание 2 - Задано целое положительное четырехзначное число N (N > 0). Найти разницу между суммой всех его цифр и произведением четных цифр");

            try
            {
                //открываем содержимое 
                RegistryKey myKey = Registry.CurrentUser;
                RegistryKey pract = myKey.OpenSubKey("Pr_17b");
                RegistryKey task2 = pract.OpenSubKey("task2");

                Console.WriteLine("Введите целое положительное четырёхзначное  число N: ");
                int N = Convert.ToInt32(Console.ReadLine());

                int a = (N % 1000) % 10;
                int b= (N % 100) % 10;
                int c= (N % 10) % 10;
                int d = N % 10;
                if (N > 0 && N > 999 && N < 10000)
                {
                    int sum = a+b+c+d;
                    int proizv = 1;

                    // Проверка на четные цифры и вычисление произведения
                    if (a % 2 == 0)
                    {
                        proizv *= a;
                    }
                    if (b % 2 == 0)
                    {
                        proizv *= b;
                    }
                    if (c % 2 == 0)
                    {
                        proizv *= c;
                    }
                    if (d % 2 == 0)
                    {
                        proizv *= d;
                    }
                    else if (a % 2 == 0 && b % 2 == 0 && c % 2 == 0 && d % 2 == 0)
                    {
                        proizv = 0;
                    }

                    int result02 = sum - proizv;
                    Registry.SetValue(task2.Name, "inputN", N);
                    Registry.SetValue(task2.Name, "result02", result02);
                    // Вывод результата
                    Console.WriteLine($"Разница между суммой цифр и произведением четных цифр для числа {N} равна: {result02}");
                }
                else
                {
                    Console.WriteLine("Ошибка! Условие что N целое положительное четырёхзначное  число не соблюдается.");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
            finally
            {
                // Удаление подкаталога PR_17 из реестра после завершения работы программы
                try
                {
                    Registry.CurrentUser.DeleteSubKeyTree(@"PR_17");
                    Console.WriteLine("Подкаталог PR_17 удален из реестра.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Не удалось удалить подкаталог PR_17: {ex.Message}");
                }
            }

            Console.WriteLine("Задание 3 - Дан целочисленный массив, состоящий из N элементов (N > 0). Перед каждым положительным элементом массива вставить элемент с нулевым значением.");

            try
            {
                //открываем содержимое 
                RegistryKey myKey = Registry.CurrentUser;
                RegistryKey pract = myKey.OpenSubKey("Pr_17b");
                RegistryKey task3 = pract.OpenSubKey("task3");

                Console.WriteLine("Введите число  элементов в массиве (N > 0): ");
                int N1 = Convert.ToInt32(Console.ReadLine());

                if (N1 > 0)
                {
                    Console.WriteLine("Количество элементов должно быть больше 0");
                }
                
               
                int[] array = new int[N1];
                for (int i = 0; i < N1; i++)
                {
                   Console.Write($"Введите элемент {i + 1}: ");
                   array[i] = Convert.ToInt32(Console.ReadLine());

                   if ( array[i] > 0 )
                   {
                       array[i] = 0;
                   }
                }
                string result03 = string.Join(", ", array);
                Console.WriteLine($"Результирующий массив: {result03}");
                
                Registry.SetValue(task3.Name, "inputN", N1);
                Registry.SetValue(task3.Name, "result03", result03);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                // Удаление подкаталога PR_17 из реестра после завершения работы программы
                try
                {
                    Registry.CurrentUser.DeleteSubKeyTree(@"PR_17");
                    Console.WriteLine("Подкаталог PR_17 удален из реестра.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Не удалось удалить подкаталог PR_17: {ex.Message}");
                }
            }

            Console.WriteLine(" Задание 4 - Написать функцию double CircleS(R) вещественного типа, находящую площадь круга радиуса R (R — вещественное). Площадь круга радиуса R вычисляется по формуле S = pi*R2. В качестве значения PI использовать предопределенную константу из библиотеки используемого языка программирования.");
            try
            {
                //открываем содержимое 
                RegistryKey myKey = Registry.CurrentUser;
                RegistryKey pract = myKey.OpenSubKey("Pr_17b");
                RegistryKey task4 = pract.OpenSubKey("task4");

                Console.WriteLine("Введите радиус окружности : ");
                double R = Convert.ToInt32(Console.ReadLine());
                if( R < 0 )
                {
                    Console.WriteLine("Ошибка! Радиус должен быть больше 0");
                }
                double result04 = CircleS(R);
                Registry.SetValue(task4.Name, "inputR", R);
                Registry.SetValue(task4.Name, "result04", result04);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                // Удаление подкаталога PR_17 из реестра после завершения работы программы
                try
                {
                    Registry.CurrentUser.DeleteSubKeyTree(@"PR_17");
                    Console.WriteLine("Подкаталог PR_17 удален из реестра.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Не удалось удалить подкаталог PR_17: {ex.Message}");
                }
            }

            Console.WriteLine("Задание 5 - Вводится строка-предложение. Длина строки может быть разной. Подсчитать и вывести на экран количество содержащихся в строке знаков препинания");
            try
            {
                //открываем содержимое 
                RegistryKey myKey = Registry.CurrentUser;
                RegistryKey pract = myKey.OpenSubKey("Pr_17b");
                RegistryKey task5 = pract.OpenSubKey("task5");
                Console.WriteLine("Введите предложение: ");
                string input = Console.ReadLine();

                // Определяем набор знаков препинания
                char[] punct = new char[] { '.', ',', '!', '?', ';', ':', '-', '(', ')', '[', ']', '{', '}' };
                int result05 = input.Count(c => punct.Contains(c)); // Подсчет знаков препинания

                Console.WriteLine($"Количество знаков препинания в предложении: {result05}");
                Registry.SetValue(task5.Name, "inputSTR", input);
                Registry.SetValue(task5.Name, "result04", result05);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                // Удаление подкаталога PR_17 из реестра после завершения работы программы
                try
                {
                    Registry.CurrentUser.DeleteSubKeyTree(@"PR_17");
                    Console.WriteLine("Подкаталог PR_17 удален из реестра.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Не удалось удалить подкаталог PR_17: {ex.Message}");
                }
            }
        }
    }
}
