using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonHra
{
    public class Item
    {
        public string Name { get; private set; }
        public string Type { get; private set; }
        public int TypeNumber;

        private static string[] itemTypes = { "Lektvar", "Meč", "Brnění" };

        public Item()
        {
            Random rand = new Random();
            Type = itemTypes[rand.Next(itemTypes.Length)];
            Name = Type;
            TypeNumber = rand.Next(1,3);
        }
    }
}
