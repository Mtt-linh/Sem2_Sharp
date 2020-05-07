using System;

namespace Sem2.Session3
{
    public class Womann:Human
    {
        public override void AddFriend()
        {
            throw new NotImplementedException();
        }

        public virtual void Running() // khi viet 1 ham cho pheps gi de thi viet thaam virtual 
            // override nhan dien xem co duoc phep ghi de hay khong 
        {
            System.Console.WriteLine("vua di vua hat ..........");
        }

        public new void Eat()
        {
            System.Console.WriteLine("eating .........");
        }
    }
}