using DiceMultiPlayerGameLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGameMultiLibTests
{
    class FakeTimeProvider : ITimeProvider
    {
        public DateTime Now
        {
            get;set;
        }
    }
}
