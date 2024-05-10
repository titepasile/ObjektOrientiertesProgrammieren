using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    internal class Player
    {
        private int _Id;
        private string _name;
        public string Name { get; set; }
        public int Id { get; set; }
        private int _chips = 3;


        //Spieler kann Chips verlieren
        public void loseChips()
        {
            _chips--;
        }
 
        //Spieler kann Chips bekommen
        public void getChips()
        {
            _chips++;
        }

        //Spieler 
        public Player (string Name)
        {
            _name = Name;
        }


        //Wie viele Chips hat der Spieler, hat er noch welche ünbrig oder nicht?
        public int GetNumberOfChips()
        {
            return _chips;
        }

        public bool HasChipsLeft
        {
            get { return _chips > 0; }
        }

        public int NumberOfDice
        {
            get { return Math.Min(3, _chips); }
        }

        //Würfeln kopiert vom alten Projekt
        public List<int> DiceRoll(DiceCup diceCup)
        {
            diceCup.Roll();
            PrintDice(diceCup.GetValue(NumberOfDice));
            return diceCup.GetValue(NumberOfDice);
        }

        public void PrintDice(List<int> rolledNumbers)
        {
            int diceNumber = 1;
            if (rolledNumbers.Count != 0)
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
        //--------------------------------------------------------------
    }
}
