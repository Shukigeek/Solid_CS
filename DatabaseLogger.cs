﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principle
{
    internal class DatabaseLogger : ILogger
    {
        public void Log()
        {
            string[] loger = new string[] { "EMERGENCY OCCURRED" };  
        }
    }
}
