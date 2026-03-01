using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace var4
{
    public class Task4
    {
        public int Calc(int A, int B, int Op)
        {
            switch (Op)
            {
                case 1:
                    return A - B;
                case 2:
                    return A * B;
                case 3:
                    return A / B;
                case 4:
                    return A + B;
                break;
            }
            return Calc(A, B, Op);
        }
    }
    
}
