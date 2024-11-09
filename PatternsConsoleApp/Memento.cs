using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsConsoleApp
{
    public class Memento
    {
        private object lastSave;

        public object GetLastState()
        {
            return lastSave as object;
        }

        public void SaveState(object obj)
        {
            lastSave = obj as object;
        }
    }

    public class Hero : ICloneable
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
            else
            {
                Console.WriteLine("Not enough ammo");
            }
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
            memento.SaveState(this.Clone());
        }

        public void LoadLastSave()
        {
            Hero save = memento.GetLastState() as Hero;

            this.BulletNumber = save.BulletNumber;
            this.HealthNumber = save.HealthNumber;
        }

        public object Clone()
        {
            Hero hero = new Hero();
            hero.BulletNumber = BulletNumber;
            hero.HealthNumber = HealthNumber;
            return hero;
        }
    }
}
