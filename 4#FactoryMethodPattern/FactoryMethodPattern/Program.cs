using System;

namespace FactoryMethodPattern
{
    public interface IAnimal
    {
        void Speak();
        void Action();
    }
    public class Dog : IAnimal
    {
        public void Speak()
        {
            Console.WriteLine("Dog says: Bow-wow.");
        }
        public void Action()
        {
            Console.WriteLine("Dogs prefer barking...\n");
        }
    }
    public class Tiger : IAnimal
    {
        public void Speak()
        {
            Console.WriteLine("Tiger says: Halum.");
        }
        public void Action()
        {
            Console.WriteLine("Tigers prefer hunting...\n");
        }
    }
    public abstract class IAnimalFactory
    {
        public abstract IAnimal CreateAnimal();
    }
    public class DogFactory : IAnimalFactory
    {
        public override IAnimal CreateAnimal()
        {
            return new Dog();
        }
    }
    public class TigerFactory : IAnimalFactory
    {
        public override IAnimal CreateAnimal()
        {
            return new Tiger();
        }
    }
    class Client
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Facoty Pattern Demo***\n");

            IAnimalFactory tigerFactory = new TigerFactory();
            IAnimal aTiger = tigerFactory.CreateAnimal();
            aTiger.Speak();
            aTiger.Action();

            IAnimalFactory dogFactory = new DogFactory();
            IAnimal aDog = dogFactory.CreateAnimal();
            aDog.Speak();
            aDog.Action();
        }
    }
}
