using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeLagger
{
    class Player
    {
        public static  int ENDPOSITION = 100;
        private int position;
        public Player()
        {
            position = 0;
        }
        public int getPosition()
        {
            return position;
        }
    }
}
