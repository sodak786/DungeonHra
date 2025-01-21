using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonHra
{
    public class Dungeon
    {
        public List<Room> Rooms { get; private set; }

        public void GenerateRooms(int numberOfRooms)
        {
            Rooms = new List<Room>();
            Random rand = new Random();
            string[] RoomNames = { "Katakomby Stínů", "Propast Zkázy", "Krypta Zapomnění", "Pekelný Labyrint", "Jeskyně Věčného Smutku" };
            for (int i = 0; i < numberOfRooms; i++)
            {
                string description = RoomNames[i];
                Enemy enemy = rand.Next(0, 2) == 0 ? new Enemy() : null;
                Item item = rand.Next(0, 2) == 0 ? new Item() : null;
                Rooms.Add(new Room(description, enemy, item));
            }
        }
    }
}
