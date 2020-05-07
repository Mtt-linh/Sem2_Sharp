using System;
using System.Threading;

namespace Sem2.Session8
{
    public class demo
    {
        private int number = 0;
        public static void Main(string[] args)
        {
            Thread t1 = new Thread(ThreadRun);
            t1.Start(" xin chao ");
Thread t2 = new Thread(new demo().Run2);
            t2.Start();
            for (int i = 0; i < 100; i++)
            {
                System.Console.WriteLine("main i ="+i);
                Thread.Sleep(100);
            }
        }

        public static void ThreadRun(object o) // duy nhat chi co 1 tham so object

        {
            string msg = (string) o;
            for (int i = 0; i < 100; i++)
            {
                System.Console.WriteLine("i ="+i);
                Thread.Sleep(100);
            }
        }

        public void Run2()
        {
            for (int i = 0; i < 50; i++)
            {
                System.Console.WriteLine("xuy = "+ (number +=2));
                Thread.Sleep(50);
            }
        }
    }
}