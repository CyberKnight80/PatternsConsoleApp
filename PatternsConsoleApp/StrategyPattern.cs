using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsConsoleApp
{
    //Strategy pattern

    public interface IStrategy
    {
        public bool Execute();
    }

    public class Blitzkrieg : IStrategy
    {
        public bool Execute()
        {
            Console.WriteLine("Battle was won by 1 day");
            return true;
        }
    }

    public class ColdWar : IStrategy
    {
        public bool Execute()
        {
            Console.WriteLine("More nuclear rockets!!!");
            return true;
        }
    }

    public class WarLord
    {
        public IStrategy Strategy;

        public WarLord(IStrategy strategy)
        {
            this.Strategy = strategy;
        }

        public void StartWar()
        {
            Strategy.Execute();
        }
    }
}
