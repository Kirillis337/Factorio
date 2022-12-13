using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorio
{

    abstract class Item
    {
        public abstract void shoot();
        public abstract void info();

    }

    class Speedfire : Item
    {
        public string ammotype;
        public Speedfire(string ammo)
        {
            ammotype = ammo;
        }
        public override void info()
        {
            Console.WriteLine($"я использую {ammotype}");
        }
        public override void shoot()
        {
            Console.WriteLine("Пиу-Пиу-Пиу-Пиу-Пиу-Пиу-Пиу");
        }
    }

    class Peacekeeper : Item
    {
        public string ammotype;
        public Peacekeeper(string ammo)
        {
            ammotype = ammo;
        }
        public override void info()
        {
            Console.WriteLine($"я использую {ammotype}");
        }
        public override void shoot()
        {
            Console.WriteLine("Пиу....Пиу");
        }
    }

    abstract class Replicator
    {
        public abstract Item Craft();
    }

    class CreatorSpeedfire : Replicator
    {
        public override Item Craft() { return new Speedfire("Легкие боеприпасы"); }
    }

    class CreatorPeacekeeper : Replicator
    {
        public override Item Craft() { return new Peacekeeper("Боеприпасы для дробовика"); }
    }
}
