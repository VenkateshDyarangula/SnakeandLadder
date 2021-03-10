using System;
using System;
using System.Collections.Generic;
using System.Text;

namespace UC4_PlayerReachesEndPosition
{
    public class Player
    {
        public static int END_POSITION = 100;
        private int position;
        private int totNoMoves;
        private Boolean chance;
        public Player()
        {
            position = 0;
            totNoMoves = 0;
            chance = false;
        }

        public void move(int opt)
        {
            if (opt > 0)
            {
                if (position + opt > END_POSITION)
                    return;
                position += opt;
                totNoMoves++;
            }
            else
            {
                if (position == 0)
                    return;
                if (position + opt < 0)
                    position = 0;
                else
                    position += opt;
                totNoMoves++;
            }
        }
        public int getTotalMoves()
        {
            return totNoMoves;
        }
        public int getPosition()
        {
            return position;
        }
        public void setChance(Boolean var)
        {
            chance = var;
        }
        public Boolean getChance()
        {
            return chance;
        }
        public Boolean is_end_position()
        {
            return position == END_POSITION;
        }
    }
}

