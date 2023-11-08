using NHL_Player.Factory;
using NHL_Player.Models;

namespace NHL_Player
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Choose an action:");
                Console.WriteLine("1. Create a hockey player");
                Console.WriteLine("2. Display hockey players");
                Console.WriteLine("3. Exit");

                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        Application.CreateHockeyPlayer();
                       
                        break;
                    case "2":
                        Application.DisplayHockeyPlayers();
                        break;
                    case "3":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

       
    }

}