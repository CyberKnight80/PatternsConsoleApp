using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsConsoleApp.BridgePattern
{
    public interface IDriver
    {
        void DriveTo(string place);
    }
}
