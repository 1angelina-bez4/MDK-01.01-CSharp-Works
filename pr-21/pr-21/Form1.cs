using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Word = Microsoft.Office.Interop.Word;

namespace pr_21
{
    public partial class Form1 : Form
    {

        static int Min3(int A5,int  B5, int C5)
        {

            return Math.Min(A5, Math.Min(B5, C5)); // Возвращаем минимальное значение
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //Создание документа 
            Word.Application wrdApp = new Word.Application();
            Word.Document wrdDoc = new Word.Document();

            Object wdMiss = System.Reflection.Missing.Value;

            wrdDoc = wrdApp.Documents.Add(ref wdMiss, ref wdMiss, ref wdMiss, ref wdMiss);

            // устанавливаем ориентацию (вид) документа
            wrdDoc.PageSetup.Orientation = Word.WdOrientation.wdOrientPortrait;

            wrdDoc.PageSetup.TopMargin = wrdApp.InchesToPoints(0.60f);    
            wrdDoc.PageSetup.BottomMargin = wrdApp.InchesToPoints(0.60f);
            wrdDoc.PageSetup.LeftMargin = wrdApp.InchesToPoints(0.80f);
            wrdDoc.PageSetup.RightMargin = wrdApp.InchesToPoints(0.59f);

            // вывод документа на экран 
            wrdApp.Visible = true;

            // устанваливаем интервал между строками
            wrdApp.ActiveWindow.Selection.ParagraphFormat.LineSpacingRule = Word.WdLineSpacing.wdLineSpaceSingle;
            wrdApp.ActiveWindow.Selection.ParagraphFormat.SpaceAfter = 0.0F;

            // вставляем новый параграф
            // имя параграфа
            Word.Paragraph headline;
            headline = wrdDoc.Content.Paragraphs.Add(ref wdMiss);
            //текст в параграфе
            headline.Range.Text = "МДК.01.01 Разработка программных модулей";
            headline.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;//выравнивание по центру
            //размер шрифта
            headline.Range.Font.Size = Convert.ToInt32(22);
            headline.Format.LineSpacingRule = Word.WdLineSpacing.wdLineSpaceSingle; // интервал между строками
            headline.Format.SpaceAfter = 5.5F;
            headline.Range.InsertParagraphAfter();
            // закрываем параграф
            headline.CloseUp();

            //Подзаголовок
            Word.Paragraph Subtitle;
            Subtitle = wrdDoc.Content.Paragraphs.Add(ref wdMiss);
            Subtitle.Range.Text = "ПР21 «Программное создание документов MS Word в языке С#»";
            Subtitle.Alignment =Word.WdParagraphAlignment.wdAlignParagraphCenter;
            Subtitle.Range.Font.Size= Convert.ToInt32(16);
            Subtitle.Range.InsertParagraphAfter();
            Subtitle.CloseUp();

            //подпись кто выполнил 
            Word.Paragraph signature;
            signature = wrdDoc.Content.Paragraphs.Add(ref wdMiss);
            signature.Range.Text = "Выполнила студентка группы ИС-23Б";
            signature.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
            signature.Range.Font.Size = Convert.ToInt32(16);
            signature.Range.InsertParagraphAfter();
            signature.CloseUp();

            wrdApp.ActiveWindow.Selection.ParagraphFormat.LineSpacingRule = Word.WdLineSpacing.wdLineSpaceSingle;
            wrdApp.ActiveWindow.Selection.ParagraphFormat.SpaceAfter = 1.0F;

            Word.Paragraph name;
            name = wrdDoc.Content.Paragraphs.Add(ref wdMiss);
            name.Range.Text = "Безрукова Ангелина";
            name.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
            name.Range.Font.Size = Convert.ToInt32(16);
            name.Range.InsertParagraphAfter();
            name.CloseUp();

            wrdApp.ActiveWindow.Selection.ParagraphFormat.LineSpacingRule = Word.WdLineSpacing.wdLineSpaceSingle;
            wrdApp.ActiveWindow.Selection.ParagraphFormat.SpaceAfter = 1.0F;

            Word.Paragraph task1;
            task1 = wrdDoc.Content.Paragraphs.Add(ref wdMiss);
            task1.Range.Text = "Задание 1:";
            task1.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify;
            task1.Range.Font.Bold = 1;
            task1.Range.Font.Size = Convert.ToInt32(14);
            task1.Range.InsertParagraphAfter();
            task1.CloseUp();


            Word.Paragraph zadanie;
            zadanie = wrdDoc.Content.Paragraphs.Add(ref wdMiss);
            zadanie.Range.Text = "Проверить истинность высказывания: \"Сумма двух первых цифр данного целого положительного четырехзначного числа равна сумме двух его последних цифр\".";
            zadanie.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify;
            zadanie.Range.Font.Bold = 0;
            zadanie.Range.Font.Size = Convert.ToInt32(14);
            zadanie.Range.InsertParagraphAfter();
            zadanie.CloseUp();

            wrdApp.ActiveWindow.Selection.ParagraphFormat.LineSpacingRule = Word.WdLineSpacing.wdLineSpaceSingle;
            wrdApp.ActiveWindow.Selection.ParagraphFormat.SpaceAfter = 0.0F;

            // Проверить истинность высказывания:
            // "Сумма двух первых цифр данного целого положительного
            // четырехзначного числа равна сумме двух его последних цифр".

            try
            {
                int A = Convert.ToInt32(textBox1.Text);

                //Заносим введенное число в word
                Word.Paragraph input;
                input = wrdDoc.Content.Paragraphs.Add(ref wdMiss);
                input.Range.Text = "Введенное число: " + A;
                input.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify;
                input.Range.Font.Bold = 1;
                input.Range.Font.Size = Convert.ToInt32(14);
                input.Range.InsertParagraphAfter();
                input.CloseUp();

                if ( A < 10000 && A > 999)
                {
                    int B = A / 1000;
                    int C = (A / 100) % 10;
                    int D = (A / 10) % 10;
                    int E = A % 10;

                    int B1 = B + C;
                    int C1 = E + D;
                   
                        bool result = (B1 == C1);

                        Word.Paragraph output;
                        output = wrdDoc.Content.Paragraphs.Add(ref wdMiss);
                        output.Range.Text = $"Ответ: {result}";
                        output.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify;
                        output.Range.Font.Bold = 1;
                        output.Range.InsertParagraphAfter();
                        output.Range.Font.Size = Convert.ToInt32(14);
                        output.Range.InsertParagraphAfter();
                        output.CloseUp();
                    
                }
                else
                {
                    label4.Text = "Ошибка! Число должно быть целым, положительным и четырехзначным.";
                }


            }
            catch(Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }

            wrdApp.ActiveWindow.Selection.ParagraphFormat.LineSpacingRule = Word.WdLineSpacing.wdLineSpaceSingle;
            wrdApp.ActiveWindow.Selection.ParagraphFormat.SpaceAfter = 1.0F;

            Word.Paragraph task2;
            task2 = wrdDoc.Content.Paragraphs.Add(ref wdMiss);
            task2.Range.Text = "Задание 2:";
            task2.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify;
            task2.Range.Font.Bold = 1;
            task2.Range.Font.Size = Convert.ToInt32(14);
            task2.Range.InsertParagraphAfter();
            task2.CloseUp();


            Word.Paragraph zadanie1;
            zadanie1 = wrdDoc.Content.Paragraphs.Add(ref wdMiss);
            zadanie1.Range.Text = "С некоторого момента прошло N дней (N > 0). Сколько полных недель прошло за этот период?";
            zadanie1.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify;
            zadanie1.Range.Font.Bold = 0;
            zadanie1.Range.Font.Size = Convert.ToInt32(14);
            zadanie1.Range.InsertParagraphAfter();
            zadanie1.CloseUp();


            int A2 = Convert.ToInt32(textBox2.Text);

            //Заносим введенное число в word
            Word.Paragraph input1;
            input1 = wrdDoc.Content.Paragraphs.Add(ref wdMiss);
            input1.Range.Text = "Введенное число: " + A2;
            input1.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify;
            input1.Range.Font.Bold = 1;
            input1.Range.Font.Size = Convert.ToInt32(14);
            input1.Range.InsertParagraphAfter();
            input1.CloseUp();

            if (A2 > 0)
            {
                int week = A2 / 7;

                Word.Paragraph output1;
                output1 = wrdDoc.Content.Paragraphs.Add(ref wdMiss);
                output1.Range.Text = $"Ответ: {week}";
                output1.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify;
                output1.Range.Font.Bold = 1;
                output1.Range.InsertParagraphAfter();
                output1.Range.Font.Size = Convert.ToInt32(14);
                output1.Range.InsertParagraphAfter();
                output1.CloseUp();

            }
            else
            {
                label6.Text = "Ошибка! Число должно быть > 0 .";
            }

            Word.Paragraph task3;
            task3 = wrdDoc.Content.Paragraphs.Add(ref wdMiss);
            task3.Range.Text = "Задание 3:";
            task3.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify;
            task3.Range.Font.Bold = 1;
            task3.Range.Font.Size = Convert.ToInt32(14);
            task3.Range.InsertParagraphAfter();
            task3.CloseUp();

            Word.Paragraph zadanie2;
            zadanie2 = wrdDoc.Content.Paragraphs.Add(ref wdMiss);
            zadanie2.Range.Text = "Даны пять целых ненулевых положительных чисел. Найти сумму двух наименьших чисел.";
            zadanie2.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify;
            zadanie2.Range.Font.Bold = 0;
            zadanie2.Range.Font.Size = Convert.ToInt32(14);
            zadanie2.Range.InsertParagraphAfter();
            zadanie2.CloseUp();

            string mas = textBox3.Text;

            Word.Paragraph input2;
            input2 = wrdDoc.Content.Paragraphs.Add(ref wdMiss);
            input2.Range.Text = "Введенные числа: " + mas;
            input2.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify;
            input2.Range.Font.Bold = 1;
            input2.Range.Font.Size = Convert.ToInt32(14);
            input2.Range.InsertParagraphAfter();
            input2.CloseUp();


            string[] massiv = mas.Split(new[] { ' ' });
            int[] numbers = new int[5];
            if (massiv.Length == 5 )
            {

                // Преобразуем строки в целые числа
                for (int i = 0; i < massiv.Length; i++)
                {
                    numbers[i] = Convert.ToInt32(massiv[i]);
                }
                Array.Sort(numbers);

                int result1 = numbers[0] + numbers[1];

                Word.Paragraph output2;
                output2 = wrdDoc.Content.Paragraphs.Add(ref wdMiss);
                output2.Range.Text = $"Ответ: {result1}";
                output2.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify;
                output2.Range.Font.Bold = 1;
                output2.Range.InsertParagraphAfter();
                output2.Range.Font.Size = Convert.ToInt32(14);
                output2.Range.InsertParagraphAfter();
                output2.CloseUp();

            }
            else 
            {
                label10.Text = "Ошибка! Чисел должно быть 5.";
            }

            Word.Paragraph task4;
            task4 = wrdDoc.Content.Paragraphs.Add(ref wdMiss);
            task4.Range.Text = "Задание 4:";
            task4.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify;
            task4.Range.Font.Bold = 1;
            task4.Range.Font.Size = Convert.ToInt32(14);
            task4.Range.InsertParagraphAfter();
            task4.CloseUp();

            Word.Paragraph zadanie3;
            zadanie3 = wrdDoc.Content.Paragraphs.Add(ref wdMiss);
            zadanie3.Range.Text = "Дан целочисленный массив, признак его завершения - число 0. Размер массива может быть разный. Вывести сумму всех положительных четных чисел из данного массива. Если требуемые числа в наборе отсутствуют, то вывести 0.";
            zadanie3.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify;
            zadanie3.Range.Font.Bold = 0;
            zadanie3.Range.Font.Size = Convert.ToInt32(14);
            zadanie3.Range.InsertParagraphAfter();
            zadanie3.CloseUp();

            int N=Convert.ToInt32(textBox4.Text);
            if (N > 30)
            {
                int sum = 0;
                int[] array = new int[N];
                Random random = new Random();
                for (int i = 0; i < N; i++)
                {
                    array[i] = random.Next(-100, 100);

                    if (array[i] == 0) // Проверка на выпадение нуля
                    {
                        Console.WriteLine("Сгенерирован ноль, завершение генерации массива.");
                        break; // Прерываем генерацию
                    }
                }
                for (int i = 0; i < N; i++)
                {
                    if (array[i] > 0 && array[i] % 2 == 0) // Проверка на положительность и четность
                    {
                        sum += array[i]; // Суммируем положительные четные числа
                    }
                }


                // Преобразуем массив в строку для вывода
                string arrayString = string.Join(", ", array);


                Console.WriteLine();
                Word.Paragraph array1;
                array1 = wrdDoc.Content.Paragraphs.Add(ref wdMiss);
                array1.Range.Text = "Сгенерированный массив: " + arrayString;
                array1.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify;
                array1.Range.Font.Bold = 1;
                array1.Range.Font.Size = Convert.ToInt32(14);
                array1.Range.InsertParagraphAfter();
                array1.CloseUp();

                Word.Paragraph output3;
                output3 = wrdDoc.Content.Paragraphs.Add(ref wdMiss);
                output3.Range.Text = $"Сумма всех положительных четных чисел: {sum}";
                output3.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify;
                output3.Range.Font.Bold = 1;
                output3.Range.InsertParagraphAfter();
                output3.Range.Font.Size = Convert.ToInt32(14);
                output3.Range.InsertParagraphAfter();
                output3.CloseUp();

            }
            else
            {
                label17.Text = "Ошибка! Элементов должнотбыть больше 30";
            }

            Word.Paragraph task5;
            task5 = wrdDoc.Content.Paragraphs.Add(ref wdMiss);
            task5.Range.Text = "Задание 5:";
            task5.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify;
            task5.Range.Font.Bold = 1;
            task5.Range.Font.Size = Convert.ToInt32(14);
            task5.Range.InsertParagraphAfter();
            task5.CloseUp();

            Word.Paragraph zadanie4;
            zadanie4 = wrdDoc.Content.Paragraphs.Add(ref wdMiss);
            zadanie4.Range.Text = "Написать функцию int Min3(A, B, C) целого типа, возвращающую одно минимальное значение из 3-х своих аргументов (параметры A, B, C - целые числа).";
            zadanie4.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify;
            zadanie4.Range.Font.Bold = 0;
            zadanie4.Range.Font.Size = Convert.ToInt32(14);
            zadanie4.Range.InsertParagraphAfter();
            zadanie4.CloseUp();

            int A5 = Convert.ToInt32(textBox5.Text);
            int B5= Convert.ToInt32(textBox6.Text);
            int C5= Convert.ToInt32(textBox7.Text);

            Word.Paragraph input5;
            input5 = wrdDoc.Content.Paragraphs.Add(ref wdMiss);
            input5.Range.Text = $"Введенные число А: {A5}";
            input5.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify;
            input5.Range.Font.Bold = 1;
            input5.Range.Font.Size = Convert.ToInt32(14);
            input5.Range.InsertParagraphAfter();
            input5.CloseUp();

            Word.Paragraph input6;
            input6 = wrdDoc.Content.Paragraphs.Add(ref wdMiss);
            input6.Range.Text = $"Введенные число B: {B5}";
            input6.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify;
            input6.Range.Font.Bold = 1;
            input5.Range.Font.Size = Convert.ToInt32(14);
            input6.Range.InsertParagraphAfter();
            input6.CloseUp();

            Word.Paragraph input7;
            input7 = wrdDoc.Content.Paragraphs.Add(ref wdMiss);
            input7.Range.Text = $"Введенные число C: {C5}";
            input7.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify;
            input7.Range.Font.Bold = 1;
            input7.Range.Font.Size = Convert.ToInt32(14);
            input7.Range.InsertParagraphAfter();
            input7.CloseUp();

            int min = Min3(A5, B5, C5);
       
            Word.Paragraph output5;
            output5 = wrdDoc.Content.Paragraphs.Add(ref wdMiss);
            output5.Range.Text = $"Минимальное число равно:   {min}";
            output5.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify;
            output5.Range.Font.Bold = 1;
            output5.Range.InsertParagraphAfter();
            output5.Range.Font.Size = Convert.ToInt32(14);
            output5.Range.InsertParagraphAfter();
            output5.CloseUp();


            //сохранение документа word
            try
            {
                object filename = @"_example_file_ms-word" + ".doc";
                wrdDoc.SaveAs(ref filename);
                wrdDoc.Close(ref wdMiss, ref wdMiss, ref wdMiss);
                wrdDoc = null;
                wrdApp.Quit(ref wdMiss, ref wdMiss, ref wdMiss);
                wrdDoc = null;
            }
            catch (Exception y)
            {
                Console.WriteLine("Ошибка сохранения документа", y.ToString());
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
