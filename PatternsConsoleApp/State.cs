using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsConsoleApp
{
    public class Water
    {
        public WaterState WaterState { get; set; }

        public Water(WaterState waterState = WaterState.Liquid)
        {
            this.WaterState = waterState;
        }

        public void WarmUp()
        {
            if (this.WaterState == WaterState.Liquid)
            {
                this.WaterState = WaterState.Gas;
                Console.WriteLine("Now i`m gas");
            }
            else if (this.WaterState == WaterState.Solid)
            {
                this.WaterState = WaterState.Liquid;
                Console.WriteLine("Now i`m liquid");
            }
            else
            {
                Console.WriteLine("I can`t be plasma...");
            }
        }

        public void WarmDown() 
        {
            if (this.WaterState == WaterState.Gas)
            {
                this.WaterState = WaterState.Liquid;
                Console.WriteLine("Now i`m liquid");
            }
            else if (this.WaterState == WaterState.Liquid)
            {
                this.WaterState = WaterState.Solid;
                Console.WriteLine("Now i`m solid");
            }
            else
            {
                Console.WriteLine("I`m already solid!!!!");
            }
        }
    }

    public enum WaterState
    {
        Gas,
        Liquid,
        Solid,
    }
}
