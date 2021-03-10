using System;
using System.Collections.Generic;
using System.Text;

namespace UC2_RollDie
{
    class ThrowDie
    {
        public int throwDie()     
        {
            Random rand = new Random();
            return rand.Next(1,7);
        }
    }
}
