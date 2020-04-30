using System;
using System.Collections.Generic;

namespace AdventureBoi
{
    class Program
    {
        static void Main(string[] args)
        {
            Dice die = new Dice();
            Console.WriteLine(die.RandomDie());
            Player player = new Player();
            player.CreateNewPlayer(player.players);
        }
    }
}
