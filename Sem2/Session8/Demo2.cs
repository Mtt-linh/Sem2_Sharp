﻿using System.Threading;

namespace Sem2.Session8
{
    public class Demo2
    {
        public static void Main(string[] args)
        {
            NumberCounter nc = new NumberCounter();
            Thread t1 = new Thread(RunCounter);
            Thread t2 = new Thread(RunCounter);
            t1.Start();
            t2.Start();
        
        
        }
        public static  void RunCounter (object o)
        {
            NumberCounter nc = (NumberCounter) o ;
            for (int i = 0; i < 100; i++)
            {
                lock (nc)
                {
                    nc.Change();
                    nc.Show(); 
                }
               Thread.Sleep(100);
            }
        }
    }
}