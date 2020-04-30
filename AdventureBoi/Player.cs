using System;
using System.Collections.Generic;
using System.Text;

namespace AdventureBoi
{
    public class Player
    {
        public List<Player> players = new List<Player>();
        public string Name { get; set; }

        Health plHP = new Health();
        public int Experience { get; set; }

        public Player CreateNewPlayer(List<Player> players)
        {
            Player player = new Player();
            Console.Write("Enter character name: ");
            player.Name = Console.ReadLine();
            player.Experience = 0;
            players.Add(player);
            return player;
        }
    }
}
