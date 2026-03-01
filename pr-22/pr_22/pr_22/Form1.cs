using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary1;

namespace pr_22
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Забираем данные с класса 
        Class1 cl1 = new Class1();

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //Забираем значения с формы
                int x = Convert.ToInt32(textBox1.Text);
                int y = Convert.ToInt32(textBox2.Text);

                //Забираем результат с метода и выводим его
                bool a = cl1.Meth(x, y);
                if (a)
                {
                    label7.Text = "true";
                }
                else
                {
                    label7.Text = "false";
                }
            }
            catch (Exception ex)
            {
                label17.Text = (ex.Message);

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                //создаем массив 
                string mas = textBox3.Text;
                string[] massiv = mas.Split(new[] { ' ' });

                if (massiv.Length == 5)
                {
                    //Забираем значения с метода и выводим результат
                    int result = cl1.Proiz(massiv);
                    label10.Text = Convert.ToString(result);
                }
                else
                {
                    label10.Text = "Ошибка! Чисел должно быть 5.";
                }
            }
            catch (Exception ex)
            {
                label10.Text = (ex.Message);

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {

                int N = Convert.ToInt32(textBox4.Text);
                
                //(int sum, int proiz) кортедж который забирает значения с метода SumProi
                (int sum, int proiz, string arrayString) = cl1.SumProi(N);

                label15.Text = Convert.ToString(arrayString);
                label17.Text = Convert.ToString(sum);
                label18.Text = Convert.ToString(proiz);
            }
            catch (Exception ex)
            {
                label15.Text =(ex.Message);

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {

                int A = Convert.ToInt32(textBox5.Text);
                int B = Convert.ToInt32(textBox6.Text);
                int C = Convert.ToInt32(textBox7.Text);
                int D = Convert.ToInt32(textBox8.Text);
                int E = Convert.ToInt32(textBox9.Text);

                int result2 = cl1.Min(A, B, C, D, E);
                label27.Text = Convert.ToString(result2);
            }
            catch (Exception ex)
            {
                label27.Text = (ex.Message);

            }
        }
    }
}
