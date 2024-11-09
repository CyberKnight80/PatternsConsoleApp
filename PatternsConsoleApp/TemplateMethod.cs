using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsConsoleApp
{
    public interface ICommand1
    {
        public bool Execute();
    }

    public interface ICommand2
    {
        public bool Execute();
    }

    public class DressOn : ICommand1
    {
        public bool Execute()
        {
            Console.WriteLine("poka spichka gorit.");

            return true;
        }
    }

    public class PaintFloor : ICommand2
    {
        public bool Execute()
        {
            Console.WriteLine("Opyat` rabota");

            return true;
        }
    }

    public class Sergeant
    {
        public ICommand1 Command1;
        public ICommand2 Command2;

        public Sergeant(ICommand1 command1, ICommand2 command2)
        {
            Command1 = command1;
            Command2 = command2;
        }       

        public bool WakeUp()
        {
            Command1.Execute();
            Command2.Execute();
            return true;
        }
    }
}
