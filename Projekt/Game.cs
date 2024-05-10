using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    internal class Game
    {
        private Player _currentPlayer = new Player(""); 
        private List<Player> _playerList = new List<Player>();
        private PlayerData _playerData = new PlayerData();

        public Game() {
            _playerList = _playerData.GetPlayerData();  

        }

        public void WhoBeginsPlaying()
        {
            _currentPlayer = _playerList[new Random().Next(_playerList.Count)];
        }

        public void Play()
        {
            //Probleme
        }
    }
}
