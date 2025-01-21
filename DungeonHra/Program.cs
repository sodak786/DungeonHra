using System;
using System.Collections.Generic;

namespace DungeonHra
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadejte sve jmeno: ");
            string playerName = Console.ReadLine();
            var player = new Player(playerName);
            Console.WriteLine($"Vítejte v Dungeon hře {player.Name}!");
            var dungeon = new Dungeon();
            dungeon.GenerateRooms(4);

            foreach (var room in dungeon.Rooms)
            {
                Console.WriteLine($"\nNacházíte se v místnosti: {room.Description}");

                if (room.Enemy != null)
                {
                    Console.WriteLine($"Narazili jste na nepřítele: {room.Enemy.Name} (Síla: {room.Enemy.Strength})");
                    Console.WriteLine($"Vaše síla: {player.AttackPower} (Život: {player.Health})");
                    Console.WriteLine("Co chcete udělat? (1: Bojovat, 2: Utéct)");
                    string action = Console.ReadLine();

                    if (action == "1")
                    {
                        Console.WriteLine($"Bojujete s {room.Enemy.Name}...");

                        while (player.Health >= 0)
                        {
                            room.Enemy.Health -= player.Attack();
                            Console.WriteLine($"Dali jste nepřítelovi za {player.Attack()}, má {room.Enemy.Health} životů");
                            if (room.Enemy.Health <= 0)
                            {
                                Console.WriteLine($"Má {room.Enemy.Health} životů, porazili jste nepřítele!");
                                break;
                            }
                            else
                            {
                                player.Health -= room.Enemy.Strength;
                                Console.WriteLine($"Nepřítel vám dal za {room.Enemy.Strength}");
                                Console.WriteLine($"Máte {player.Health} životů");
                                if (player.Health <= 0)
                                {
                                    Console.WriteLine("Nepřítel vás zabil..");
                                    return;
                                }
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Utekli jste do bezpečí, ale nechali jste místnost za sebou.");
                        continue;
                    }
                }
                if (room.Item != null)
                {
                    Console.WriteLine($"Našli jste předmět: {room.Item.Name} {room.Item.TypeNumber} ({room.Item.Type})");
                    switch (room.Item.Type)
                    {
                        case "Lektvar":
                            player.Health += room.Item.TypeNumber;
                            break;
                        case "Meč":
                            player.AttackPower += room.Item.TypeNumber;
                            break;
                        case "Brnění":
                            player.Health += (room.Item.TypeNumber + 1);
                            break;
                    }
                }

                Console.WriteLine("Pokračujete do další místnosti...");
                Console.ReadLine();
            }

            Console.WriteLine("Gratulujeme, dokončili jste dungeon!");
        }
    }
}
