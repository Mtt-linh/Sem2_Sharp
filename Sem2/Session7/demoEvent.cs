using System;

namespace Sem2.Session7
{
    public delegate void buttonHander(string msg);
    public class demoEvent
    {
        public event buttonHander OnClick;

        public void ClickButton()
        {
            System.Console.WriteLine("Button Clicked!");
            DateTime now = DateTime.Now;
            if (OnClick ==null)
            {
                OnClick += ShowAlert;
            }

            OnClick("User clicked at : " + now);
        }

        public static void ShowAlert(string msg)
        {
            System.Console.WriteLine(msg);
        }
    }
}