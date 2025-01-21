using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonHra
{
    internal class Player
    {
        public int Attack()
        {
            return AttackPower;
        }
        public string Name { get; private set; }
        public int Health;
        public int AttackPower;
        


        public Player(string name)
        {
            Name = name;
            Random rnd = new Random();
            Health = rnd.Next(8,15);
            AttackPower = rnd.Next(8,11);
        }
    }
}
