using System;
using System.Collections.Generic;

namespace TeamLibrary
{
    public class Team
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public List<Player> Players { get; set; }

        public Team()
        {
            Players = new List<Player>();
        }

        public void Show()
        {
            Console.WriteLine($"Team Name: {Name}");
            Console.WriteLine($"Team Address: {Address}");
            Console.WriteLine("Players:");
            foreach (var player in Players)
            {
                player.Show();
            }
        }

        public void ShowAll()
        {
            Players.Sort((p1, p2) => p1.Name.CompareTo(p2.Name));
            foreach (var player in Players)
            {
                player.Show();
            }
        }

        public void AddPlayer(Player player)
        {
            Players.Add(player);
        }
    }

    public class Player
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public Player(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public void Show()
        {
            Console.WriteLine($"- {Name}: {Description}");
        }
    }
}
