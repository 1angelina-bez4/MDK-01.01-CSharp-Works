using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pr_18
{
    public partial class Form1 : Form
    {
        public int Min2Of5Mul(int A2, int B2, int C2, int D2, int E2)
        {
            int[] array = { A2, B2, C2, D2, E2 };
            Array.Sort(array);
            int proizv = array[0]* array[1];

            return proizv;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Проверить истинность высказывания: "Квадратное уравнение A·x2 + B·x + C = 0
            //с данными коэффициентами A (A не равно 0), B, C имеет ровно два вещественных корня".

            double A = Convert.ToInt32(qA.Text);
            double B = Convert.ToInt32(qB.Text);
            double C = Convert.ToInt32(qC.Text);

            double diskrim = B * B - 4 * A * C;
            if (A !=0)
            {
                if (diskrim > 0)
                {
                    result.Text = " Квадратное уравнение имеет два корня - выражение является истинным. ";
                }
                else
                {
                    result.Text = " Квадратное уравнение имеет два корня - выражение является ложным";
                }
            }
            else
            {
                result.Text= "Ошибка! Условие A не равно 0 - не соблюдается.";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Даны два целых положительных числа A и B (число A меньше числа B).
            //Вывести все числа, расположенные между данными числами (не включая сами эти числа),
            //в порядке их убывания, а также количество этих чисел и их сумму.

            int A1 = Convert.ToInt32(q2A.Text);
            int B1 = Convert.ToInt32(q2B.Text);

            int sum = 0;
            int count = 0;

            if (A1<B1 && A1>0 && B1>0)
            {
                for (int i = B1 - 1; i > A1; i--)
                {
                    Console.WriteLine(i);
                    sum += i;   // Суммируем числа
                    count++;    // Увеличиваем счетчик
                }
            }
            else
            {
                result2.Text="Ошибка! Условие целые положительное A меньше целого положительного числа B - не соблюдается.";
                result3.Text = "Ошибка! Условие целые положительное A меньше целого положительного числа B - не соблюдается.";
            }

            result2.Text = Convert.ToString(count);
            result3.Text = Convert.ToString(sum);
        }
        private void button3_Click(object sender, EventArgs e)
        {
                //Написать функцию int Min2Of5Mul(A, B, C, D, E) целого типа,
                //возвращающую произведение двух самых минимальных из 5-ти своих аргументов
                //(параметры A, B, C, D, E - целые числа).
                int A2 = Convert.ToInt32(qA2.Text);
                int B2 = Convert.ToInt32(qB2.Text);
                int C2 = Convert.ToInt32(qC2.Text);
                int D2 = Convert.ToInt32(qD2.Text);
                int E2 = Convert.ToInt32(qE2.Text);

                int result_4 = Min2Of5Mul(A2, B2, C2, D2, E2);
                result4.Text = Convert.ToString($"Произведение двух минимальных: {result}");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Дан целочисленный массив, состоящий из N элементов (N > 0, N - четное число).
            //Поменять местами его первый элемент со вторым, третий - с четвертым и т. д.
            //Вывести полученный массив.

            int N = Convert.ToInt32(qN.Text);
            int[] array1 = new int[N];

            if ( N > 0 && N % 2 == 0 && N >= 20)
            {
                Random rand = new Random();
                for (int i = 0; i < N; i++)
                {
                    array1[i] = rand.Next(1, 100); // Заполняем массив случайными числами от 1 до 99
                }

                for (int i = 0; i < N - 1; i += 2)
                {
                    int temp = array1[i];
                    array1[i] = array1[i + 1];
                    array1[i + 1] = temp;

                    result5.Text = "Результат: " + string.Join(", ", array1);
                }
            }
            else
            {
                result5.Text = "Ошибка! Условие N > 0, N - четное число - не соблюдается";
            }
        }
    }
}
