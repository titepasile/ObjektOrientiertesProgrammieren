using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace LeftCenterRight
{
    internal class Game
    {
        private Player _currentPlayer = new Player("");
        private List<Player> _playerList = new List<Player>();
        private GUI _gui = new GUI();
        private DiceCup _diceCup = new DiceCup();

        public Game()
        {
            _playerList = _gui.RetrivePlayerData();
        }

        public void Play()
        {
            string Input = "";
            do
            {
                if(_playerList.Count == 0)
                {
                    _playerList = _gui.RetrivePlayerData();
                }
                SetStartPlayer();
                while (MoreThanOnePlayerHasChips())
                {
                    Console.WriteLine("");
                    Console.WriteLine("It's " + _currentPlayer.Name + "'s turn.");
                    _currentPlayer.DiceRoll(_diceCup);
                    ProcessDiceRoll(_diceCup.GetValue(_currentPlayer.NumberOfDice));
                    _gui.PrintStatus(_playerList);
                    _currentPlayer = PlayerToTheRight();
                }
                _gui.PrintWinner(_playerList);

                Console.WriteLine("Do you want to play again? enter 'yes' or 'no''");
                Input = Console.ReadLine().ToLower();
                _playerList.Clear();
            } while (Input == "yes");

            if (Input != "yes")
            {
                Console.WriteLine("Bey :)");
            }
        }

        public void ProcessDiceRoll(List<int> numbers)
        {
            foreach (int number in numbers)
            {
                switch (number)
                {
                    case 4:
                        PassChipToTheLeft();
                        break;
                    case 5:
                        PlaceChipInPot();
                        break;
                    case 6:
                        PassChipToTheRight();
                        break;
                }
            }
        }


        public void SetStartPlayer()
        {
            _currentPlayer = _playerList[new Random().Next(_playerList.Count)];
        }

        public Player PlayerToTheRight()
        {
            if (_playerList.Last() == _currentPlayer)
            {
                return _playerList.First();
            }
            else
            {
                return _playerList[_currentPlayer.PlayerId+1];
            }
        }

        public Player PlayerToTheLeft()
        {
            if (_playerList[0] == _currentPlayer)
            {
                return _playerList.Last();
            }
            else
            {
                return _playerList[_currentPlayer.PlayerId-1];
            }
        }

        public bool MoreThanOnePlayerHasChips()
        {
            int playersWithChips = 0;
            foreach (Player player in _playerList)
            {
                if (player.HasChipsLeft)
                {
                    playersWithChips++;
                }
            }
            if (playersWithChips > 1)
            {
                return true;
            }
            return false;
        }

        public void PassChipToTheLeft()
        {
            _playerList[PlayerToTheLeft().PlayerId].ReceiveChip();
            _playerList[_currentPlayer.PlayerId].PassOnChip();
        }

        public void PassChipToTheRight()
        {
            _playerList[PlayerToTheRight().PlayerId].ReceiveChip();
            _playerList[_currentPlayer.PlayerId].PassOnChip();
        }

        public void PlaceChipInPot()
        {
            _playerList[_currentPlayer.PlayerId].PassOnChip();
        }


    }
}
