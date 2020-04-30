using System;
using System.Collections.Generic;
using System.Text;

namespace AdventureBoi
{
    public class Dice
    {
        public int RandomDie()          //roll a d6 and return int value
        {
            Random rand = new Random();
            return rand.Next(1, 7);
        }

        public int RandomInt(int min, int max)  //roll a number between the min and max value (max value is never reached), technically I could use this instead of RandomDie(), but maybe I don't wish to define a random min & max every time
        {
            Random rand = new Random();
            return rand.Next(min, max);
        }
    }
}
