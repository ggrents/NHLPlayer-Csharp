using NHL_Player.Decorator;
using NHL_Player.Models;
using NHL_Player.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHL_Player
{
    public class Tools
    {
        public static void ApplyTactic(HockeyPlayer newPlayer)
        {
            Console.WriteLine("Choose the tactic:");
            Console.WriteLine("1. Pressure");
            Console.WriteLine("2. Shooting");
            Console.WriteLine("3. Defense");
            var userInput = Console.ReadLine();
            if (userInput == "1")
            {

                newPlayer.ChangeStrategy(new PressureStrategy());
                Console.Write($"Player {newPlayer.Name} will");
                newPlayer.Play();
            }
            else if (userInput == "2")
            {

                newPlayer.ChangeStrategy(new ShotStrategy());
                Console.Write($"Player {newPlayer.Name} will");
                newPlayer.Play();
            }
            else if (userInput == "3")
            {

                newPlayer.ChangeStrategy(new DefenseStrategy());
                Console.Write($"Player {newPlayer.Name} {newPlayer.Surname} will");
                newPlayer.Play();
            }
            else
            {
                Console.WriteLine("Invalid tactic");
            }


        }

        public static void ChooseHand(HockeyPlayer newPlayer)
        {

            Console.WriteLine("What is your grip of the stick?");
            Console.WriteLine("1. Left");
            Console.WriteLine("2. Right");

            var userInput = Console.ReadLine();

            if (userInput == "1")
            {

                IHandDecorator decorator = new LeftHandDecorator(newPlayer);
                decorator.SetHand();
                PlayerService.UpdatePlayerHand(newPlayer.Id, false);
                Console.WriteLine($"{newPlayer.Name} {newPlayer.Surname} holds the stick on the left side");
            }

            else if (userInput == "2")
            {
                IHandDecorator decorator = new RightHandDecorator(newPlayer);
                decorator.SetHand();
                PlayerService.UpdatePlayerHand(newPlayer.Id, true);
                Console.WriteLine($"{newPlayer.Name} {newPlayer.Surname} holds the stick on the right side");
            }

            else
            {
                Console.WriteLine("Incorrect input...");
            }

        }
    }
}
