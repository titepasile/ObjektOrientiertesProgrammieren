using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeftCenterRight
{
    internal class Player
    {
        private int _chips = 3;
        private string _name;
        private int _playerId;
        public string Name { get; set; }
        public int PlayerId { get; set; }

        public bool HasChipsLeft
        { 
            get { return _chips > 0; }   
        }

        public int NumberOfDice 
        { 
            get { return Math.Min(3 , _chips); }     
        }
        //-------------------------------------------------------------------

        public Player (string name)
        {
            _name = name;
        }

        public void ReceiveChip()
        {
            _chips++;
        }

        public void PassOnChip()
        {
            _chips--;
        }

        public List<int> DiceRoll(DiceCup diceCup)
        {
            diceCup.Shake();
            PrintDice(diceCup.GetValue(NumberOfDice));
            return diceCup.GetValue(NumberOfDice); 
        }

        public string PrintNameAndChips()
        {
            return "Player " + Name + " collected " + _chips + " chips.";
        }

        public void PrintDice(List<int> rolledNumbers)
        {
            int diceNumber = 1;
            if(rolledNumbers.Count != 0)
            {
                foreach (int number in rolledNumbers)
                { // Stringinterpolation
                    Console.WriteLine($"Dice {diceNumber}: {number}");
                    diceNumber++;
                }
            }
            else
            {
                Console.WriteLine("Skipped turn");
            }
        }
    }
}
