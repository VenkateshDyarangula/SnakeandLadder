using System;
using System.Collections.Generic;
using System.Text;

namespace UC4_PlayerReachesEndPosition
{
    class SnakeLadderEngine
    {
        private static int countNoThrows = 0;
        public static void loader()
        {
            Player p1 = new Player();
            Player p2 = new Player();
            //Console.Read();
           // decidesThrowFirst(p1, p2);
            while (!p1.is_end_position() && !p2.is_end_position())
            {
                start(p1, p2);
               
            }
            if (p1.is_end_position())
            {
                Console.WriteLine("Player One won the game");
                Console.WriteLine("Total moves taken: " + p1.getTotalMoves());
            }
            else
            {
                Console.WriteLine("Player two won the game");
                Console.WriteLine("Total moves taken: " + p2.getTotalMoves());
            }
           // sc.close();
        }
        private static void start(Player p1, Player p2)
        {
            int dieCount = throwDie();
            int optAhead = giveOption(dieCount);
            updatePlayers(p1, p2, optAhead);
        }
        private static int throwDie()
        {
            Random rand = new Random();
            countNoThrows++;
            return rand.Next(0,7);
        }
        private static int giveOption(int dieCount)
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

        private static void updatePlayers(Player p1, Player p2, int opt)
        {
            if (p1.getChance())
            {
                if (opt <= 0)
                {
                    p1.setChance(false);
                    p2.setChance(true);
                    if (opt == 0)
                        Console.WriteLine("Player 1: No move");
                else
                        Console.WriteLine("Player 1: Bit by snake, going down by " + (-1) * opt);
                }
                if (opt > 0)
                    Console.WriteLine("Player 1: Going up the ladder by " + opt);
                p1.move(opt);
            }
            else
            {
                if (opt <= 0)
                {
                    p2.setChance(false);
                    p1.setChance(true);
                    if (opt == 0)
                        Console.WriteLine("Player 2: No move");
                else
                        Console.WriteLine("Player 2: Bit by snake, going down by " + (-1) * opt);
                }
                if (opt > 0)
                    Console.WriteLine("Player 2: Going up the ladder by " + opt);
                p2.move(opt);
            }
        }
    }
}
