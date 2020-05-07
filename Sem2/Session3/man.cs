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
            System.Console.WriteLine("hello baby");
        }

        public void SayHello(string msg)
        {
            System.Console.WriteLine(msg);
        }
    }
}