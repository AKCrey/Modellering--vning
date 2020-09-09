using System;

namespace Modellering
{
    public class Weapon
    {
        Random generator = new Random();

        public int dmg = 35;
        public int accuracy = generator.Next(1, 10);

    }
}
