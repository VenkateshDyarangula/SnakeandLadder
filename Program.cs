#UC1
 using System;

namespace SnakeLagger
{
    class Program
    {
        static void Main(string[] args)
        {
            Player p=new Player();
            Console.WriteLine("Initial Position = " + p.getPosition());
        }
    }
}




#UC2
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



#UC3
using System;

namespace UC3_RollDie
{
    class Program
    {
        static void Main(string[] args)
        {
            ThrowDie t =new ThrowDie();
            Console.WriteLine("Dies are :" + t.throwDie());
        }
    }
}


#UC4
using System;

namespace UC4_PlayerReachesEndPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            SnakeLadderEngine.loader();
        }
    }
}

