using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsConsoleApp.BridgePattern
{
    public class Student
    {
        DriverAgency driverAgency = new DriverAgency();

       public void GoTo(string place)
        {
            IDriver driver = driverAgency.GetDriver();
            driver.DriveTo(place);
        }

    }
}
