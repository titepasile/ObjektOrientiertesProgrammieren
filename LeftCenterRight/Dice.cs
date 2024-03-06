using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeftCenterRight
{
    internal class Dice
    {
        private const int MAX_NUMMBER = 6;
        private Random _random = new Random();
        private int _lastValue;

        public int LastValue
        {
            get { return _lastValue; }  
        }
        public void Roll()
        {
            _lastValue = _random.Next(1, MAX_NUMMBER);
        }
    }
}
