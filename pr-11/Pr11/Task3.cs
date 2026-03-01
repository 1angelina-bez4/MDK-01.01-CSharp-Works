using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace var4
{
    internal class Task3
    {
        public bool Positive(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] <= array[i - 1])
                {
                    return false; // Если  меньше или равно предыдущему то  выводим false
                }
            }
            return true; // Если все элементы возрастаются то выводим true
        }
    }
}
