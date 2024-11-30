using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsConsoleApp
{
    public class FacadePattern
    {
        
    }
    
    public class MotherBoard
    {
        private PowerBlock powerBlock;
        private RAM _RAM;
        private CPU _CPU;
        public MotherBoard(PowerBlock powerBlock, RAM ram, CPU cpu)
        {
            this.powerBlock = powerBlock;
            this._RAM = ram;
            this._CPU = cpu;
        }
        public void Start()
        {
            powerBlock.Run();
            _RAM.Run();
            _CPU.Run();

        }
    }
    public class PowerBlock
    {
        public void Run()
        {
            Console.WriteLine("Щелк");
        }
    }
    public class RAM
    {
        public void Run()
        {
            Console.WriteLine("Вжух");
        }
    }
    public class CPU
    {
        public void Run()
        {
            Console.WriteLine("Хопа");
        }
    }

    public class ComputerFacade
    {
        public static MotherBoard Build1()
        {
            return new MotherBoard(new PowerBlock(), new RAM(), new CPU());
        }
    }
}
