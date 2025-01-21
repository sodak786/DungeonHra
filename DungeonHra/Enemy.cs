using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonHra
{
    public class Enemy
    {
        public string Name { get; private set; }
        public int Strength { get; private set; }
        public int Health;

        private static string[] enemyTypes = { "Goblin", "Skeleton", "Orc", "Zombie" };

        public Enemy()
        {
            Random rand = new Random();
            Name = enemyTypes[rand.Next(enemyTypes.Length)];
            Strength = rand.Next(4, 10);
            Health = rand.Next(8,15);
        }
    }
}
