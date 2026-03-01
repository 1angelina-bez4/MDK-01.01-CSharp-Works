using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace var4
{
    public class Task2
    {
        public double osadki(double[] array1)
        {
            int coint = 0;
            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] == 0)
                {
                    coint ++;
                }
                else
                {
                    continue;
                }
            }
            return coint;
        }
    }
}
