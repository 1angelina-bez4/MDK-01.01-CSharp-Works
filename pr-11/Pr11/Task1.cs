using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace var4
{
    internal class Task1
    {
        public int A = 0;
        public int B = 0;
        public int C = 0;

        public void Task(int A, int B, int C)
        {
            if (A > 0 && B > 0 && C > 0)
            {
                Console.WriteLine("Выражение истинно:«Каждое из чисел A, B, C положительное» ");
            }
            else
            {
                Console.WriteLine("Выражение ложно: «Каждое из чисел A, B, C положительное»");
            }
        }
    }
}
