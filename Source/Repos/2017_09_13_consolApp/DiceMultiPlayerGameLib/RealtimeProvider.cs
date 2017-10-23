using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceMultiPlayerGameLib
{
    public class RealtimeProvider : ITimeProvider
    {

        DateTime ITimeProvider.Now
        {
            get;set;
        }
    }
}
