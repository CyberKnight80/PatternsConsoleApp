using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsConsoleApp.BridgePattern
{
    public class DriverAgency
    {
        private Random rand = new Random();


        public IDriver GetDriver()
        {
            switch (rand.Next(2))
            {
                case 0:
                    return new ManualDriver();
                case 1:
                    return new AutoDriver();
            }
            return new AutoDriver();
            
        }
    }
   
}
