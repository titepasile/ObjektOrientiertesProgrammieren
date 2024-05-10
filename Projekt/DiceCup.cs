using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    internal class DiceCup
    {
        private const int AmountOfDices = 3;
        private List<Dice> _dice = new List<Dice>();

        public DiceCup()
        {
            for (int i = 0; i < AmountOfDices; i++)
            {
                _dice.Add(new Dice());
            }
        }

        public void Roll()
        {
            foreach (Dice dice in _dice)
            {
                dice.rollTheDice();
            }
        }

        //Habe ich vom alten Projekt kopiert. 
        public List<int> GetValue(int amount)
        {
            List<int> Values = new List<int>();
            foreach (Dice dice in _dice)
            {
                Values.Add(dice.DiceNumber);
            }
            return Values.GetRange(0, amount);
        }
        //------------------------------------
    }
}
