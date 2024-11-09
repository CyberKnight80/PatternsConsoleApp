using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsConsoleApp
{
    //Observer pattern
    public interface IObserver
    {
        public void Update(string data);
    }

    public interface IObservable 
    {
        public void AddObserver(IObserver observer);
        public void RemoveObserver(IObserver observer);
        public void Notify(string data);
    }

    public class UN : IObservable
    {
        public HashSet<IObserver> Observers;    
        public UN() 
        {
            this.Observers = new HashSet<IObserver>();
        }

        public void AddObserver(IObserver observer)
        {
            this.Observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            this.Observers.Remove(observer);
        }

        public void Notify(string data) 
        {
            foreach(var obs in Observers)
            {
                obs.Update(data);
            }
        }
    }

    public class USA : IObserver
    {
        public void Update(string data)
        {
            if(!string.IsNullOrEmpty(data))
            {
                Console.WriteLine("Going to war...");
            }
        }
    }

    public class Russia : IObserver
    {
        public void Update(string data)
        {
            if (!string.IsNullOrEmpty(data))
            {
                Console.WriteLine("Don`t going to war...");
            }
        }
    }
}
