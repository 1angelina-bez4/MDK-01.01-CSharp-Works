using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace pr_19
{
    internal class Program
    {
        public static int Min3(int A, int B, int C)
        {
            return Math.Min(A, Math.Min(B, C));
        }
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Задание 1 - Проверить истинность высказывания: \"Данное целое положительное число является четным трехзначным числом\".");

                //читаем с файла
                string inputFile = "input1.xml";
                XElement input1 = XElement.Load(inputFile);
                int number = int.Parse(input1.Element("Number").Element("Value").Value);
                bool result;
                if (number > 0 && number > 99 && number < 1000 && number % 2 == 0)
                {
                    result = true;
                }
                else
                {
                    result = false;
                }
                Console.WriteLine(result);

                using (var xmlWriter = new XmlTextWriter("output1.xml", null))
                {
                    xmlWriter.WriteStartDocument();                  // <?xml version="1.0"?>
                    xmlWriter.WriteStartElement("ListOfNum");      // <ListOfNum>
                    xmlWriter.WriteStartElement("num");             //      <num>
                    xmlWriter.WriteElementString("result", result.ToString()); // <result>true/false</result>
                    xmlWriter.WriteEndElement();                     // </num>
                    xmlWriter.WriteEndElement();                     // </ListOfNum>
                    xmlWriter.WriteEndDocument();                    // Завершение документа
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Сообщение:" + ex);
            }


            Console.WriteLine("Задание 2 - Даны целые положительные числа A и B (A < B). Вывести все целые числа от A до B включительно; при этом каждое число должно выводиться столько раз, каково его значение (например, число 3 выводится 3 раза).");
            try
            {


                string inputFilePath = "input2.xml";
                XElement input2 = XElement.Load(inputFilePath);

                int A = int.Parse(input2.Element("Range").Element("A").Value);
                int B = int.Parse(input2.Element("Range").Element("B").Value);

                // Создание списка для хранения результатов
                var numbersList = new XElement("NumbersList");

                // Генерация чисел от A до B
                for (int i = A; i <= B; i++)
                {
                    for (int j = 0; j < i; j++)
                    {
                        numbersList.Add(new XElement("Number", i));
                    }
                }

                // Создание корневого элемента для выходного файла
                var results = new XElement("Results", numbersList);

                // Запись результата в выходной XML файл
                string outputFilePath = "output2.xml";
                using (var xmlWriter = new XmlTextWriter(outputFilePath, null))
                {
                    xmlWriter.Formatting = Formatting.Indented; // Форматирование для удобства чтения
                    xmlWriter.WriteStartDocument();             // <?xml version="1.0"?>
                    results.WriteTo(xmlWriter);                 // Запись элементов в файл
                    xmlWriter.WriteEndDocument();                // Завершение документа
                }

                Console.WriteLine("Результат записан в output2.xml");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Сообщение:" + ex);
            }

            Console.WriteLine("Задание 3 - Написать функцию int Min3(A, B, C) целого типа, возвращающую одно минимальное значение из 3-х своих аргументов (параметры A, B, C - целые числа).");

            try
            {
                string inputFile3 = "input3.xml";
                XElement input3 = XElement.Load(inputFile3);
                var numbers = input3.Descendants("Number").Select(e => int.Parse(e.Value)).ToArray(); //select - проецирует каждый элемент последовательности в новую форму
                if (numbers.Length != 3)
                {
                    Console.WriteLine("Ошибка: должно быть ровно три числа в входном файле.");
                }

                int min = Min3(numbers[0], numbers[1], numbers[2]);

                var result = new XElement("Output",
                new XElement("MinimumValue", min));

                result.Save("output3.xml");
                Console.WriteLine($"Минимальное значение: {min} записано в output1.xml");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Сообщение:" + ex);
            }

            Console.WriteLine("Задание 4 - Вводится строка, состоящая из слов, разделенных подчеркиваниями (одним или несколькими). Длина строки может быть разной. Определить и вывести на экран слово/слова, которые содержат ровно три буквы 'x'.");

            try
            {
                string inputFile4 = "input4.xml";
                XElement input4 = XElement.Load(inputFile4);
                var sentence = input4.Descendants("Sentence").FirstOrDefault()?.Value;
                if (string.IsNullOrEmpty(sentence))
                {
                    Console.WriteLine("Ошибка: входные данные отсутствуют или пустые.");
                    return;
                }

                var words = sentence.Split(new[] { '_' });
                var words2 = words.Where(word => word.Count(c => c == 'x') == 3).ToList();
                var output = new XElement("Output",
                new XElement("WordsWithThreeX",
                words2.Select(word => new XElement("Word", word))));

                output.Save("output4.xml");
                Console.WriteLine("Результат записан в output4.xml");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Сообщение:" + ex);
            }
        }
    }
}
