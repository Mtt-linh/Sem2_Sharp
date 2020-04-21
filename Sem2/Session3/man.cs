using System;

namespace Sem2.Session3
{
    public class man : Human
    {
        public  override void AddFriend()
        {
            
        }
        public void SayHello()
        {
            Console.WriteLine("hello baby");
        }

        public void SayHello(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}