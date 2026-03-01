using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace var4
{
    internal class Task2
    {
        //Дано количество часов,
        //минут и секунд (1 час = 60 минут, 1 минута = 60 секунд).
        //Вычислить и вывести общее количество секунд.

        public int hours = 0;
        public int minuts = 0;
        public int second = 0;

        public void Methood(int hours, int minuts, int second)
        {
            int x = hours * 60 * 60 + minuts * 60 + second;
            Console.WriteLine($"Общее количество секунд:{x}");
        }
    }
}
