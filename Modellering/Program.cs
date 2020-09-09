using System;

namespace Modellering
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Healthpack big = new Healthpack();
            big.health = 100;
            big.cooldown = 20;
            
            
            Console.ReadLine();
        }
    }
}
