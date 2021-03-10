using System;

namespace CheckOpt
{
    class Program
    {
        static void Main(string[] args)
        {
            Giveopt give = new Giveopt();
            int count=give.throwDie();
            int option=give.giveOption(count);
            if (option == 0)
                Console.WriteLine("Player stays in the same position "+option);
            else if (option == count)
                Console.WriteLine("Ladder: Player Moves ahead of diecount " +count);
            else if (option == (-1)*count)

                Console.WriteLine("Snake: Player Movesdown of diecount " +option);
        }

    }
}

