using System;

namespace Sem2.Session3
{
    public abstract class Human
    {
        
        protected string name;
        protected int age;
        public abstract void AddFriend();
        public void Running()
        {
            Console.WriteLine("Run....");
        }
    }
}