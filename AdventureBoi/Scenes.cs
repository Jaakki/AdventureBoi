using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AdventureBoi
{
    public class Scenes     //contains different scenes, a scene contains button choices and art - main menu(start adventure & exit), begin adventure(name character and possibly some story), encounter, encounter continues, die
    {
        public bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Adventure Boi\n");
            Console.WriteLine("Choose Option:");
            Console.WriteLine("1) Start");
            Console.WriteLine("2) Quit");

            switch (Console.ReadLine())
            {
                case "1":
                    BeginAdventure(List<Player>);
                    return false;

                case "2":
                    return false;
                default:
                    return true;
            }
        }

        public Scenes BeginAdventure(List<Player> players)
        {
            Console.Clear();
            Player player = new Player();
            player.CreateNewPlayer(players);
            Console.Clear();
            Console.WriteLine("You stand before a mighty ork army.\nOrk and goblins descend upon you.\nYou must fight!");
            return Encounter();
        }

        public Scenes Encounter()
        {
            throw new Exception();
        }


        public Scenes YouDied()
        {
            throw new Exception();
        }
    }
}
