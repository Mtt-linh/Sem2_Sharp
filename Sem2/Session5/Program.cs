using System;

namespace Sem2.Session5
{
    public class Program
    {
        public static int ProgramCode;
    }

    namespace MyNamespace
    {
        public class MyClass
        {
            public void ShowInfo()
            {
                try
                {
                    int x = 10;
                    int y = 0;
                    System.Console.WriteLine(x + y);
                }
                catch (Exception e)
                {
                    System.Console.WriteLine(e.Message);
                }
                System.Console.WriteLine("done");
            }
            
        }
    }
}
// tao doi tuong program cua namespace sem2. session5 -> biet tao tu 
namespace Console.Sem2.Session5.Demo
{
    public class Program
    {
        
    }

    public class DemoProgram
    {
        
    }
}