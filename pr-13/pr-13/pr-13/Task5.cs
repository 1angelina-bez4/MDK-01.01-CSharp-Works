using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace var4
{
    public class Task5
    {
        public string Methoot(string V)
        {
            int first = V.IndexOf('.');
            int second = V.IndexOf('.', first+ 1);

            if (first == -1 || second == -1)
                return V;

            return V.Substring(first + 1, second - first - 1);
        }
    }
}
