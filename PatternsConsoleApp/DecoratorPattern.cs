using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsConsoleApp
{
    public interface IRunner
    {
        public void RunGame();
    }
    public class Computer : IRunner
    {
        public void RunGame()
        {
            Console.WriteLine("Запущено с двумя фпс");
        }
    }
    public class ComputerDecorator : IRunner
    {
        public IRunner runner;
        public ComputerDecorator(IRunner runner)
        {
            this.runner = runner;
        }
        public void RunGame() 
        {
            runner.RunGame();
            Console.WriteLine("Добавили видеокарту. Теперь 30 фпс");
        }
    }
}
