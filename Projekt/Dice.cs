using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    internal class Dice
    {
        //Eigenschaften
        public int maxNumber = 6;
        public int minNumber = 1;

        // Würfeln
        private Random _random = new Random();

        public int _diceNumber;

        public int DiceNumber
        {
            get { return _diceNumber; }
        }

        public void rollTheDice()
        {
        // Zahl zwischen 1 und 6
            _diceNumber = _random.Next(minNumber, maxNumber);
        }
    }
}
