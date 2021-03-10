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
