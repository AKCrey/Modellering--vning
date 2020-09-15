using System;

namespace Modellering
{
    public class Weapon
    {
        Random generator = new Random();

        public int dmg = 35;
        public int accuracy;

        public Weapon()
        {
            accuracy = 2;
        }

        public int Attack()
        {
            int toHit = generator.Next(0, 10);

            if (toHit < accuracy) {
                return dmg;
            }
            else{
                return 0;
            }
        }

    }
}
