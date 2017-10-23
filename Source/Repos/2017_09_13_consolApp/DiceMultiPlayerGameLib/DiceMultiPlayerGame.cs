using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceMultiPlayerGameLib
{
    public class DiceMultiPlayerGame
    {
        private ITimeProvider timeProvider;
        private DateTime startPoint;

        public DiceMultiPlayerGame(ITimeProvider timeProvider)
        {
            this.timeProvider = timeProvider;
            this.startPoint = timeProvider.Now;
        }

        public bool GameOver
        {
            get
            {
                return (timeProvider.Now - startPoint).TotalSeconds >= 10;
            }
        }
    }
}
