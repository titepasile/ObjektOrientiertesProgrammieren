using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    internal class PlayerData
    {
        public List<Player> GetPlayerData()
        {
            bool addPlayer = true;
            List<Player> newPlayers = new List<Player>();
            int playerId = 0; // Starte die Spieler-ID mit 0
            while (addPlayer)
            {
                Player newPlayer = new Player("");
                Console.WriteLine("Enter your name:");
                newPlayer.Name = Console.ReadLine();
                newPlayer.Id = playerId; // Setze die Spieler-ID
                newPlayers.Add(newPlayer);
                playerId++; // Inkrementiere die Spieler-ID für den nächsten Spieler
                addPlayer = AddMorePlayers();
            }
            return newPlayers;

        }

        public bool AddMorePlayers()
        {
            Console.WriteLine("Do you want to add a player? type yes or no ");
            string userInput = Console.ReadLine();

            if (userInput == "yes")
            {
                return true;
            }
            else if (userInput == "no")
            {
                return false;
            }
            Console.WriteLine("Wrong input, please try again. Write in small letters. ");

            return false;
        }

        public void TheWinnerIs(List<Player> players)
        {
            foreach (Player player in players)
            {
                if (player.HasChipsLeft)
                {
                    Console.WriteLine(player.Name + "has won the game!!");
                }
            }

        }

    }
} 
