using NHL_Player.Adapter;
using NHL_Player.Decorator;
using NHL_Player.Factory;
using NHL_Player.Models;
using NHL_Player.Strategy;
using NHL_Player.Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace NHL_Player
{
    public class Utilites
    {
        public static void CreateHockeyPlayer()
        {
            Console.WriteLine("Choose a position (1 - Forward, 2 - Defense, 3 - Goalie):");
            string positionInput = Console.ReadLine();

            if (int.TryParse(positionInput, out int positionChoice))
            {
                IHockeyPlayerFactory playerFactory = null;

                switch (positionChoice)
                {
                    case 1:
                        playerFactory = new ForwardFactory();
                        break;
                    case 2:
                        playerFactory = new DefenseFactory();
                        break;
                    case 3:
                        playerFactory = new GoalieFactory();
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Exiting...");
                        return;
                }

                Console.WriteLine("Enter player details:");

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Surname: ");
                string surname = Console.ReadLine();

                Console.Write("Nationality: ");
                string nationality = Console.ReadLine();

                Console.Write("Height: ");
                float height;
                float.TryParse(Console.ReadLine(), out height);

                Console.Write("Weight: ");
                float weight;
                float.TryParse(Console.ReadLine(), out weight);

                Console.Write("Rating: ");
                int rating;
                int.TryParse(Console.ReadLine(), out rating);

                Console.Write("Age: ");
                int age;
                int.TryParse(Console.ReadLine(), out age);



                HockeyPlayer newPlayer = playerFactory.CreatePlayer(name, surname, nationality, height, weight, rating, age);


                var _player = PlayerService.AddPlayer(newPlayer.Name, newPlayer.Surname, newPlayer.Nationality,
                    newPlayer.Height, newPlayer.Weight, newPlayer.Rating, newPlayer.Age, newPlayer.Position);

                Tools.ApplyTactic(newPlayer);
                Tools.ChooseHand(_player);



            }
        }

        public static void DisplayHockeyPlayers()
        {

            PlayerService.DisplayPlayers();
        }

        public static void Notify()
        {
            var _players = PlayerService.GetAllPlayers();
            IObservable publisher = new Publisher();
            foreach (var player in _players)
            {
                Subscriber subscriber = new Subscriber();
                subscriber._player = player;
                publisher.AddObserver(subscriber);

            }
            Console.WriteLine("Enter your name: ");
            var coachName = Console.ReadLine();

            Console.WriteLine("Specify the training details: ");
            var details = Console.ReadLine();
         
            publisher.NewTraining(coachName, details);

        }
     

    }
}
