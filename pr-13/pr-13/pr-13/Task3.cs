using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace var4
{
    internal class Task3
    {
        //Написать функцию int DigitN(K, N) целого типа,
        //возвращающую N-ю цифру целого положительного числа K
        //(цифры в числе нумеруются справа налево).
        //Если количество цифр в числе K меньше N,
        //то функция должна возвращать значение -1.
        public int DigitN(int K, int N1)
        {
            // Преобразуем число K в строку для удобного доступа к цифрам
            string number = K.ToString();
            // Проверяем, достаточно ли цифр в числе K
            if (N1 > number.Length)
            {
                return -1; // Если цифр меньше, чем N, возвращаем -1
            }
            // Возвращаем N-ю цифру, нумеруя справа налево
            return int.Parse(number[number.Length - N1].ToString());
        }
    }
}
