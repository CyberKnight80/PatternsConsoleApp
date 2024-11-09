using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsConsoleApp
{
    public class Memento
    {
        public object GetLastState()
        {
            return new object();
        }

        public void SaveState(object obj)
        {

        }
    }

    public class Hero
    {
        Memento memento = new Memento();

        public int BulletNumber { get; set; }

        public int HealthNumber { get; set; }

        public void Fire()
        {
            if(BulletNumber > 0)
            {
                BulletNumber--;
                Console.WriteLine("FIRE FIRE");
            }

            Console.WriteLine("Not enough ammo");
        }

        public void FallDown()
        {
            if(HealthNumber > 0)
            {
                HealthNumber--;
                Console.WriteLine($"Fail! Count of lifes now {HealthNumber}");
            }
            else
            {
                Console.WriteLine("Game ended.");
            }
        }

        public void Save()
        {
            memento.SaveState(new object());
        }

        public void LoadLastSave()
        {
            memento.GetLastState();
        }
    }
}
