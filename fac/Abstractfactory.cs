using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorio
{
    class Program
    {
        static void Main()
        {
            Phone iphone13proMaxSuper = new Phone(new AppleFactory());
            iphone13proMaxSuper.Dispute();
            iphone13proMaxSuper.Download();

            Phone samsungGalaxyS1000 = new Phone(new SamsungFactory());
            samsungGalaxyS1000.Dispute();
            samsungGalaxyS1000.Download();

            Console.ReadLine();
        }
    }
    //абстрактный класс дискуссии
    abstract class system
    {
        public abstract void dispute();
    }
    // абстрактный класс загрузки
    abstract class store
    {
        public abstract void download();
    }

    // класс айкос
    class iOS : system
    {
        public override void dispute()
        {
            Console.WriteLine("РЯЯЯЯ ЯБЛОКО ЛУЧШЕ");
        }
    }
    // класс Ведроид
    class Android : system
    {
        public override void dispute()
        {
            Console.WriteLine("РЯЯЯЯ АНДРОИД ЛУЧШЕ");
        }
    }
    // Магазин - апстор
    class Appstore : store
    {
        public override void download()
        {
            Console.WriteLine("Скачано с App store");
        }
    }
    // Магазин - Плеймаркет
    class Playmarket : store
    {
        public override void download()
        {
            Console.WriteLine("Скачано с Google play");
        }
    }
    // класс абстрактной фабрики
    abstract class PhoneFactory
    {
        public abstract store CreateMovement();
        public abstract system CreateWeapon();
    }
    // Фабрика создания Айфонов
    class AppleFactory : PhoneFactory
    {
        public override store CreateMovement()
        {
            return new Appstore();
        }

        public override system CreateWeapon()
        {
            return new iOS();
        }
    }
    // Фабрика создания Самсунгов
    class SamsungFactory : PhoneFactory
    {
        public override store CreateMovement()
        {
            return new Playmarket();
        }

        public override system CreateWeapon()
        {
            return new Android();
        }
    }
    class Phone
    {
        private system weapon;
        private store movement;
        public Phone(PhoneFactory factory)
        {
            weapon = factory.CreateWeapon();
            movement = factory.CreateMovement();
        }
        public void Dispute()
        {
            weapon.dispute();
        }
        public void Download()
        {
            movement.download();
        }

    }
}
