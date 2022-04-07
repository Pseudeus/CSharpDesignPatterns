using System;
using System.Linq;

namespace ProxyPattern
{
    /// <summary>
    /// Abstract class Subject
    /// </summary>
    public abstract class Subject
    {
        public abstract void DoSomeWork();
    }
    /// <summary>
    /// ConcreteSubject class
    /// </summary>
    public class ConcreteSubject : Subject
    {
        public override void DoSomeWork()
        {
            Console.WriteLine("ConcreteSubject.DoSomeWork()");
        }
    }
    /// <summary>
    /// Proxy class
    /// </summary>
    public class Proxy : Subject
    {
        Subject cs;
        string[] registeredUsers;
        string currentUser;

        public Proxy(string currentUser)
        {
            registeredUsers = new string[]{"Admin","Rohit","Sam"};
            this.currentUser = currentUser;
        }
        public override void DoSomeWork()
        {
            Console.WriteLine("Proxy call happening now...");
            Console.WriteLine("{0} wants to invoke a proxy methid.", currentUser);
            if(cs == null && registeredUsers.Contains(currentUser) || registeredUsers.Contains(currentUser))
            {
                cs = new ConcreteSubject();
                cs.DoSomeWork();
            }
            else
            {
                Console.WriteLine("Sorry {0}, you do not have access.", currentUser);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Proxy Pattern Demo***\n");
            Proxy px1 = new Proxy("Admin");
            px1.DoSomeWork();
            
            Proxy px2 = new Proxy("Robin");
            px2.DoSomeWork();
        }
    }
}
