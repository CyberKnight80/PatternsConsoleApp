using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsConsoleApp
{
    public interface ICommand
    {
        public bool Execute();
    }

    public class DigTrench : ICommand
    {
        public bool Execute()
        {
            Console.WriteLine("Dva soldata iz stroybata zamenyaut exkavator)))");

            return true;
        }
    }

    public class PaintGrass : ICommand
    {
        public bool Execute()
        {
            Console.WriteLine("Grass was painted in blue.");

            return true;
        }
    }

    public class Soldier
    {
        public bool Execute(ICommand command)
        {
            command.Execute();
            return true;
        }
    }
}
