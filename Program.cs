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
