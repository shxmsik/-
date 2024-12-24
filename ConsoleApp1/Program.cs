
using System;
using TeamLibrary;

namespace TeamApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Team team = new Team();
            team.Name = "Golden Dragons";
            team.Address = "123 Main Street";


            team.AddPlayer(new Player("John Doe", "Forward"));
            team.AddPlayer(new Player("Jane Smith", "Goalkeeper"));
            team.AddPlayer(new Player("Bob Johnson", "Midfielder"));

            // Шеченков Андрей 34 ис
            team.ShowAll();
            Console.ReadLine();
        }
    }
}
