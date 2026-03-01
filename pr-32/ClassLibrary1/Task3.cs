using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace var4
{
    /// <summary>
    /// Проверяет, что каждый следующий элемент больше предыдущего.
    /// </summary>
    public class AscendingSequenceChecker
    {
        /// <summary>
        ///  Проверка, образует ли данный набор возрастающую последовательность
        /// </summary>
        /// <param name="array">Массив введенный с консоли</param>
        /// <returns>True, если последовательность возрастающая; иначе — false.</returns>
        public bool IsAscending(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] <= array[i - 1])
                    return false;
            }
            return true;
        }
    }
}
