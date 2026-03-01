namespace Pr_33
{
    internal class Program
    {
        static void Main()
        {
            Task1();
            Task2();
            Task3();
            Task4();
            Task5();

        }

        static void Task1()
        {
            Console.WriteLine("1. Проверка: все цифры трёхзначного числа различны.");
            int num;
            while (true)
            {
                Console.Write("Введите трёхзначное положительное число: ");
                if (int.TryParse(Console.ReadLine(), out num) && num >= 100 && num <= 999)
                    break;
                Console.WriteLine("Ошибка: введите целое число от 100 до 999.");
            }

            int d1 = num / 100;      // сотни
            int d2 = (num / 10) % 10; // десятки
            int d3 = num % 10;       // единицы

            bool allDifferent = (d1 != d2) && (d1 != d3) && (d2 != d3);
            Console.WriteLine($"Результат: {allDifferent}\n");
        }

        static void Task2()
        {
            Console.WriteLine("2. Чётные числа между A и B (убывание), их количество и сумма.");
            int A, B;
            while (true)
            {
                Console.Write("Введите A (положительное): ");
                if (int.TryParse(Console.ReadLine(), out A) && A > 0)
                    break;
                Console.WriteLine("Ошибка: A должно быть положительным целым числом.");
            }
            while (true)
            {
                Console.Write("Введите B (больше A): ");
                if (int.TryParse(Console.ReadLine(), out B) && B > A)
                    break;
                Console.WriteLine("Ошибка: B должно быть целым числом и больше A.");
            }

            var evens = Enumerable.Range(A + 1, B - A - 1)
                         .Where(x => x % 2 == 0)
                         .OrderByDescending(x => x)
                         .ToList();

            Console.WriteLine("Чётные числа (убывание): " + string.Join(" ", evens));
            Console.WriteLine($"Количество: {evens.Count}");
            Console.WriteLine($"Сумма: {evens.Sum()}\n");
        }

        static void Task3()
        {
            Console.WriteLine("3. Сумма осадков по нечётным дням месяца.");
            int n;
            while (true)
            {
                Console.Write("Сколько дней в месяце (N)? ");
                if (int.TryParse(Console.ReadLine(), out n) && n >= 1)
                    break;
                Console.WriteLine("Ошибка: N должно быть положительным целым числом.");
            }

            double[] rainfall = new double[n];
            Console.Write("Заполнять случайно? (y/n): ");
            bool randomFill = Console.ReadLine()?.ToLower() == "y";

            if (randomFill)
            {
                var rand = new Random();
                for (int i = 0; i < n; i++)
                    rainfall[i] = rand.Next(0, 101) + rand.NextDouble(); // 0..100.999
                Console.WriteLine("Массив заполнен случайно.");
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    while (true)
                    {
                        Console.Write($"Осадки за день {i + 1}: ");
                        if (double.TryParse(Console.ReadLine(), out rainfall[i]) && rainfall[i] >= 0)
                            break;
                        Console.WriteLine("Ошибка: введите неотрицательное вещественное число.");
                    }
                }
            }

            double sumOddDays = 0;
            for (int day = 1; day <= n; day++)
            {
                if (day % 2 == 1) // нечётный день
                    sumOddDays += rainfall[day - 1];
            }

            Console.WriteLine($"Сумма осадков по нечётным дням: {sumOddDays:F2}\n");
        }

        static double TriangleP(double a, double h)
        {
            if (a <= 0 || h <= 0)
                throw new ArgumentException("Основание и высота должны быть положительными.");

            double b = Math.Sqrt(Math.Pow(a / 2, 2) + Math.Pow(h, 2));
            return a + 2 * b;
        }

        static void Task4()
        {
            Console.WriteLine("4. Периметр равнобедренного треугольника (a, h).");
            double a, h;
            while (true)
            {
                Console.Write("Основание a: ");
                if (double.TryParse(Console.ReadLine(), out a) && a > 0)
                    break;
                Console.WriteLine("Ошибка: a должно быть положительным вещественным числом.");
            }
            while (true)
            {
                Console.Write("Высота h: ");
                if (double.TryParse(Console.ReadLine(), out h) && h > 0)
                    break;
                Console.WriteLine("Ошибка: h должно быть положительным вещественным числом.");
            }

            try
            {
                double perimeter = TriangleP(a, h);
                Console.WriteLine($"Периметр: {perimeter:F2}\n");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}\n");
            }
        }

        static void Task5()
        {
            Console.WriteLine("5. Произведение нечётных цифр в строке.");
            Console.Write("Введите строку: ");
            string input = Console.ReadLine() ?? "";

            long product = 1;
            bool hasOddDigit = false;

            foreach (char c in input)
            {
                if (char.IsDigit(c))
                {
                    int digit = c - '0';
                    if (digit % 2 == 1) // нечётная цифра
                    {
                        product *= digit;
                        hasOddDigit = true;
                    }
                }
            }

            if (hasOddDigit)
                Console.WriteLine($"Произведение нечётных цифр: {product}\n");
            else
                Console.WriteLine("В строке нет нечётных цифр.\n");
        }
    }
}
