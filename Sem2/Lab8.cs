using System.Threading;

namespace Sem2
{
    public class Lab8
    {
        private int number = 0;

        public static void Main(string[] args)
        {
            Thread t3 = new Thread(Run3);
            t3.Start(15);
            // Thread t1 = new Thread(ThreadRun)
            //t1.Start("xin chao ");//chay luong moi 
            //
            //Thread t2 = new Thread( new Lab8.Run2);
            // t2.Start();
            // for(int i = 0 ; i<100; i++){
            // console.writeLine("Main i = " +i);
            // Thread.Sleep(100);
            // }
        }

        public static void ThreadRun(object o)
        {
            string msg = (string) o;
            for (int i = 0; i < 100; i++)
            {
                System.Console.WriteLine(msg+ "i = "+i);
                Thread.Sleep(100);
            }
        }

        public void Run2()
        {
            for (int i = 0; i < 100; i++)
            {
                System.Console.WriteLine("xdf = " +(number += 2));
                Thread.Sleep(100);
            }
        }

        public static void Run3(object o)
        {
            int n = (int) o;
            for (int i = 0; i >= 0; i--)
            {
                for (int j = 59; j >= 0; j--)
                {
                    // keyword : number format 01 02 in c#
                    System.Console.WriteLine(i.ToString("D2")+":"+j.ToString("D2"));
                    Thread.Sleep(10);
                }
            }
            System.Console.WriteLine("BOOOOOOOMMMMMMMMMMMMM");
        }

    }
        
}