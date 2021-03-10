using System;
using System.Collections.Generic;
using System.Text;

namespace CheckOpt
{
    class Giveopt
    {
        public int throwDie()
        {
            Random rand = new Random();
            return rand.Next(0,7);
        }

        public int giveOption(int dieCount)
        {
            Random rand = new Random();
            int opt = rand.Next(3);
            switch (opt)
            {
                case 0:
                    return 0;
                case 1:
                    return dieCount;
                default:
                    return (-1) * dieCount;
            }
        }
    }

}
