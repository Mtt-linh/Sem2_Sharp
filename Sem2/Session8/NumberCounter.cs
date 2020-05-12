namespace Sem2.Session8
{
    public class NumberCounter
    {
        public int x = 0;
        public int y = 0;

        public void Show()
        {
            System.Console.WriteLine("x = "+x);
            System.Console.WriteLine("y = "+y);
        }

        public void Change()
        {
            x++;
            y++;
        }
       
    }
}