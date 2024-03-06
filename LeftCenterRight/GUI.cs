using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeftCenterRight
{
    internal class GUI
    {
        public List<Player> RetrivePlayerData()
        {
            bool addNewPlayer = true;
            List<Player> newPlayers = new List<Player>();
            while (addNewPlayer)
            {
                Player newPlayer = new Player("");
                Console.WriteLine("Enter your name");
                newPlayer.Name = Console.ReadLine();
                newPlayers.Add(newPlayer);
                newPlayers[newPlayers.Count - 1].PlayerId = newPlayers.Count - 1;
                addNewPlayer = DecisionMorePlayers();
            }
            return newPlayers;
        }

        public bool DecisionMorePlayers()
        {
            string Input = "";
            while (Input != "yes" || Input != "no")
            {
                Console.WriteLine("Do you want to add a player? (1) Yes (2) No");
                //ToLower() --> alle buchstaben werden klein geschriben
                Input = Console.ReadLine().ToLower();
                if (Input == "yes" || Input == "1")
                {
                    return true;
                }
                else if (Input == "no" || Input == "2")
                {
                    return false;
                }
                Console.WriteLine("Your input wasn't correct!");
            }
            return false;
        }

        public void PrintStatus(List<Player> players)
        {
            foreach (Player player in players)
            {
                Console.WriteLine(player.PrintNameAndChips());
            }
        }

        public void PrintWinner(List<Player> players)
        {
            foreach (Player player in players)
            {
                if (player.HasChipsLeft)
                {
                    Console.WriteLine("");
                    Console.WriteLine(player.Name + " has won the game!!!");
                }
            }
        }
    }
}
