using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace var4
{
    /// <summary>
    /// Извлекает подстроку между вторым и третьим знаком '='.
    /// </summary>
    public class SubstringExtractor
    {
        /// <summary>
        /// Находим подстроку, расположенную между вторым и третьим знаком '=' исходной строки
        /// </summary>
        /// <param name="input">Строка вводимая с консоли</param>
        /// <returns>Возвращаем третий элемент (индекс 2)</returns>
        public string ExtractBetweenSecondAndThirdEqual(string input)
        {
            string[] parts = input.Split('=');

            if (parts.Length < 4)
                return string.Empty; // Возвращаем пустую строку, если нет нужных частей

            return parts[2]; 
        }

    }
}
