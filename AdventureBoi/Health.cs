using System;
using System.Collections.Generic;
using System.Text;

namespace AdventureBoi
{
    public class Health
    {
        public List<int> PlayerHealth = new List<int>();

        public List<int> EnemyHealth = new List<int>();


        public List<int> AddHealth(List<int> health, int add)
        {
            for (int i = 0; i < add; i++)
            {
                health.Add(1); 
            }
            return health;
        }

        public List<int> RemoveHealth(List<int> health, int remov)
        {
            for (int i = 0; i < remov; i++)
            {
                health.RemoveAt(0);
            }
            return health;
        }

        public void DisplayHealth(List<int> health)
        {
            for (int i = 0; i <= health.Count; i++)
            {
                Console.WriteLine("♥ ");
            }
        }
    }
}
