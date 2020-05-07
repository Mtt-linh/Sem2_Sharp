using System;

namespace Sem2.Lab3
{
    public delegate void ButtonBuy(string buy);
    public class Eventbuy : product
    {
        public event ButtonBuy ClickMouse;

        public void ClickButton()
        {
            System.Console.WriteLine("click mouse !");
            DateTime now = new DateTime();
          
                if (ClickMouse ==null)
                {
                    ClickMouse += ShowCart;
                    System.Console.WriteLine( " da them 1 san pham vao gio hang ");
                    System.Console.WriteLine(qty= qty-1);
                }
                else
                {
                    System.Console.WriteLine(" sp da het hang ");
                }

                ClickMouse("user click at "+ now);
          
                

        }

        public static void ShowCart(string cart)
        {
            System.Console.WriteLine(cart);
        }
        
    }
}