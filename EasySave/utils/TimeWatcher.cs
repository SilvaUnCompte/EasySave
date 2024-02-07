﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasySave.utils
{
    internal class TimeWatcher
    {
        Stopwatch stopWatch = new Stopwatch();
        public TimeWatcher()
        {
            stopWatch.Start();
        }
        public string Stop()
        {
            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            return ts.TotalMilliseconds.ToString() + " ms";
        }
    }
}
