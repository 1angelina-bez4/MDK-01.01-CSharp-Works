using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace var4
{
    /// <summary>
    /// Проверяет, является ли число чётным двузначным.
    /// </summary>
    public class EvenTwoDigitChecker
    {
        /// <summary>
        ///  Проверяет истинность высказывания: число — чётное двузначное.
        /// </summary>
        /// <param name="number">Число вводимое с клавиатуры </param>
        /// <returns>Возращаем истинну высказывания true или false</returns>
        public bool IsEvenTwoDigit(int number)
        {
            if (number >= 10 && number <= 99 && number % 2 == 0)
            {
                return true;
            }
            else { return false; }
            
        }
    }
}
