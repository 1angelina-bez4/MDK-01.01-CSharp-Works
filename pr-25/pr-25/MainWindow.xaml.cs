using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace pr_25
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public int Min3(int A1, int B1, int C1)
        {
            //Написать функцию int Min3(A, B, C) целого типа, возвращающую одно минимальное значение
            //из 3-х своих аргументов (параметры A, B, C - целые числа).
            return Math.Min(A1, Math.Min(B1, C1));
        }
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Task1Button_Click(object sender, RoutedEventArgs e)
        {
            //Проверить истинность высказывания: "Данное целое положительное число является четным трехзначным числом".
            int number = Convert.ToInt32(input_textBox.Text);

            if (number > 99 && number < 1000 && number % 2 == 0)
            {
                MessageBox.Show("True");
            }
            else { MessageBox.Show("False"); }
        }

        private void Task2Button_Click(object sender, RoutedEventArgs e)
        {
            //Даны целые положительные числа A и B (A < B). Вывести все целые числа от A до B включительно;
            //при этом каждое число должно выводиться столько раз, каково его значение (например, число 3 выводится 3 раза).

            int A =Convert.ToInt32(input2_textBox.Text);
            int B = Convert.ToInt32(input3_textBox.Text);

            if (A<B && A>0 && B>0)
            {
                string resultat = "";
                for (int i = A; i <= B; i++)
                {
                    for (int j = 0; j < i; j++)
                    {
                        resultat+=i+ " ";
                        MessageBox.Show($"Результат: {resultat}");
                    }
                }
            }
            else { MessageBox.Show("Ошибка! Числа должны быть положительны и A<B."); }
        }

        private void Task3Button_Click(object sender, RoutedEventArgs e)
        {

                //Дан целочисленный массив, состоящий из N элементов (N > 0).
                //Сложить со всеми четными числами максимальное нечетное число из этого массива.
                //Вывести новый полученный массив.

                int N = Convert.ToInt32(input4_textBox.Text);
                int[] array = new int[N];
                if (N > 20)
                {
                    Random random = new Random();
                    for (int i = 0; i < N; i++)
                    {
                        array[i] = random.Next(1, 100);
                    }

                    //находим максимальное нечетное число
                    int max = 0;
                    for (int i = 0; i < array.Length; i++)
                    {
                        if (array[i] % 2 != 0 && array[i] > max)
                        {
                            max = array[i];
                            return;
                        }
                    }

                    // создаем новый массив 
                    int[] resultarray = new int[N];
                    for (int i = 0; i < N; i++)
                    {
                        if (array[i] % 2 == 0)
                        {
                            resultarray[i] = array[i] + max; //если число четное то складываем с максимальным нечетным числом
                            return;
                        }
                        else
                        {
                            resultarray[i] = array[i]; // Оставляем нечетные числа без изменений
                        }
                    }
                    string resultat3 = string.Join(", ", resultarray);
                    MessageBox.Show($"Результат: {resultat3}");

                }
                else { MessageBox.Show("Ошибка! N должно быть больше 0."); }
            
        }
        private void Task4Button_Click(object sender, RoutedEventArgs e)
        {
            //Написать функцию int Min3(A, B, C) целого типа, возвращающую одно минимальное значение
            //из 3-х своих аргументов (параметры A, B, C - целые числа).

            int A1= Convert.ToInt32(input5_textBox.Text);
            int B1 = Convert.ToInt32(input6_textBox.Text);
            int C1 = Convert.ToInt32(input7_textBox.Text);

            int resultat4 =Min3(A1 , B1 , C1 );
            MessageBox.Show($"Результат: {resultat4}");
        }

        private void Task5Button_Click(object sender, RoutedEventArgs e)
        {
            //Вводится строка, состоящая из слов, разделенных подчеркиваниями (одним или несколькими).
            //Длина строки может быть разной. Определить и вывести на экран слово/слова, которые содержат ровно три буквы 'x'.

            string input =Convert.ToString(input8_textBox1.Text);

            string[] words = input.Split(new char[] { '_' });

            string [] filtwords = new string[words.Length];
            int count = 0;

            foreach (string word in words)
            {
                // Считаем количество букв 'x' в текущем слове
                int countX = 0;
                foreach (char c in word)
                {
                    if (c == 'x')
                    {
                        countX++;
                    }
                }
                // Если количество 'x' равно 3, добавляем слово в список 
                if (countX == 3)
                {
                    filtwords[count] = word;
                    count++;
                }
            }
            string[] resultArray2 = new string[count];
            // Копируем отфильтрованные слова в новый массив
            for (int i = 0; i < count; i++)
            {
                resultArray2[i] = filtwords[i];
            }

            // Проверяем, есть ли отфильтрованные слова
            if (resultArray2.Length > 0)
            {
                MessageBox.Show(string.Join(", ", resultArray2));
            }
            else
            {
                MessageBox.Show("Слов, содержащих ровно три буквы 'x', не найдено.");
            }
        }
    }
}