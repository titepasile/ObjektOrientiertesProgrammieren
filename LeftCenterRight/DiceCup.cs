using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace LeftCenterRight
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

        public void Shake()
        {
            foreach (Dice dice in _dice)
            {
                dice.Roll();
            }
        }

        public List<int> GetValue(int amount)
        {
            List<int> Values = new List<int>();
            foreach(Dice dice in _dice)
            {
                Values.Add(dice.LastValue); 
            }
            return Values.GetRange(0, amount);  
        }
    }
}
