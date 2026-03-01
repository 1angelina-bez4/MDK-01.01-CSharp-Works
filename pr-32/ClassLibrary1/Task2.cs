using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace var4
{
    /// <summary>
    /// Конвертирует размер файла в байтах в килобайты и мегабайты.
    /// </summary>
    public class FileSizeConverter
    {
        /// <summary>
        /// Находим количество полных килобайтов и мегабайтов файла
        /// </summary>
        /// <param name="sizefile">Размер файла введный с консоли</param>
        /// <returns>Возращаем Кортеж: (килобайты, мегабайты)</returns>
        public (int KB, int MB) Convert(int sizefile)
        {
            int KB = sizefile/1024;
            int MB = sizefile/(1024 * 1024);
            return (KB, MB);
        }
    }
}
