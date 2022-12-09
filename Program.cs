using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorio
{
    internal class Program
    {
        static void Main()
        {
        }
    }
    abstract class Item
    { }

    class Battery : Item
    {
        
    }

    class Medkit : Item
    { }

    abstract class Replicator
    {
        public abstract Item FactoryMethod();
    }

    class ConcreteCreatorA : Replicator
    {
        public override Item FactoryMethod() { return new Battery(); }
    }

    class ConcreteCreatorB : Replicator
    {
        public override Item FactoryMethod() { return new Medkit(); }
    }
}
