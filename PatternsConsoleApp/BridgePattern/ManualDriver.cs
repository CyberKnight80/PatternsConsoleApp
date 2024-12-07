﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsConsoleApp.BridgePattern
{
    public class ManualDriver : IDriver
    {
        public void DriveTo(string place)
        {
            Console.WriteLine($"Еду на механике в {place}");
        }
    }
}