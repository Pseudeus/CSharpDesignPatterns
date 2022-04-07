using System;

namespace SimpleFactoryPattern
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
            Console.WriteLine("Dog says: Bow-wow");
        }
        public void Action()
        {
            Console.WriteLine("Dogs prefer barking...");
        }
    }
    public class Tiger : IAnimal
    {
        public void Speak()
        {
            Console.WriteLine("Tyger says: Halum.");
        }
        public void Action()
        {
            Console.WriteLine("Tigers prefer hunting...");
        }
    }
    public abstract class AISimpleFactory
    {
        public abstract IAnimal CreateAnimal();
    }
    public class SimpleFactory : AISimpleFactory
    {
        public override IAnimal CreateAnimal()
        {
            IAnimal intendedAnimal = null;
            Console.WriteLine("Enter your choise (0 for Dog, 1 for Tiger)");
            bool ina = int.TryParse(Console.ReadLine(), out int result);
            
            if(ina)
            {
                Console.WriteLine("You have entreded {0}", result);
                switch(result)
                {
                    case 0:
                        intendedAnimal = new Dog();
                        break;
                    case 1: 
                        intendedAnimal = new Tiger();
                        break;
                    default:
                        Console.WriteLine("You must enter either 0 or 1");
                        throw new ApplicationException(String.Format(" Unknown Animal, cannot be instantiated"));
                }
            }
            return intendedAnimal;
        }
    }
    class Client
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Simple Factory Pattern Demo***\n");
            IAnimal preferredType = null;
            AISimpleFactory simpleFactory = new SimpleFactory();
            #region The code region that will vary based on users preference
            preferredType = simpleFactory.CreateAnimal();
            #endregion
            #region  The codes that do not change frequently
            preferredType.Speak();
            preferredType.Action();
            #endregion
        }
    }
}
