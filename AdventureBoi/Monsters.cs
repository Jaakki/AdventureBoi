using System;
using System.Collections.Generic;
using System.Text;

namespace AdventureBoi
{
    public class Monsters
    {
        public string GoblinName = "Goblin";
        public int GoblinEXP = 1;

        public string OrkName = "Ork";
        public int OrkEXP = 2;

        public Monsters(string GobName, int GobEXP)
        {
            this.GoblinName = GobName;
            this.GoblinEXP = GobEXP;
        }

        public Monsters(int OrcEXP, string OrcName)
        {
            this.OrkName = OrcName;
            this.OrkEXP = OrcEXP;
        }

        public Monsters EncounterOrk()
        {
            Monsters ork = new Monsters(2, "Ork");
            return ork;
        }

        public Monsters EncounterGoblin()
        {
            Monsters gob = new Monsters("Goblin", 1);
            return gob;
        }

        public Monsters EncouterGenerator()
        {
            Dice dice = new Dice();
            int x = dice.RandomInt(1, 3);
            if (x == 1)
            {
                return EncounterGoblin();
            }
            else
            {
                return EncounterOrk();
            }
        }
    }
}
