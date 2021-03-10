#UC2
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



#UC3
using System;

namespace UC2_RollDie
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
