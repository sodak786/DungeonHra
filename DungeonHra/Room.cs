using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonHra
{
    public class Room
    {
        public string Description { get; private set; }
        public Enemy Enemy { get; private set; }
        public Item Item { get; private set; }

        public Room(string description, Enemy enemy, Item item)
        {
            Description = description;
            Enemy = enemy;
            Item = item;
        }
    }
}
