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
            big.quantity = 1;

            Weapon bazooka = new Weapon();
            bazooka.dmg = 10000;
            bazooka.accuracy = 1;

            Enemy bigBoi = new Enemy();
            bigBoi.hp = 10000; 
            
            Console.ReadLine();
        }
    }
}
