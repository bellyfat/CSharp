﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceMultiPlayerGameLib
{
    public interface ITimeProvider
    {
        DateTime Now { get; set; }
    }
}
