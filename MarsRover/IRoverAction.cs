﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
    interface IRoverAction
    {
        void PerformAction(RoverLocationDetails roverLocationDetails);
    }
}
