using System;
using System.Collections.Generic;
using Sem2.Session2.assignment_2;

namespace Sem2.Assignment3
{
    public class List
    {
        
    private static Cart cart = new Cart(1,"Linh mai",34,"ha noi","Viet nam",Lists);
    public static List<Product> Lists { get; set; }

    public static void Main(string[] args)
        {
            Boolean quit = false;
            PrintAction();
            while (!quit)
            {
                Console.WriteLine("\nEnter action: (5 to show available actions" );
                int action = Convert.ToInt32(Console.ReadLine());
                switch (action)
                {
                    case 0: 
                        CancelTheCart();
                        quit = true;
                        break;
                    case 1: 
                        AddNewProduct();
                        break;
                    case 2: 
                        RemoveProduct();
                        break;
                    case 3: 
                        cart.SetTotal();
                        cart.Print();
                        break;
                    case 4: 
                        CancelTheCart();
                        quit = true;
                        break;
                    case 5: 
                        PrintAction();
                        break;
                        
                }
            }
        }

        private static void AddNewProduct()
        {
            Console.WriteLine("Enter product Id ");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter name of product ");
            string name = Console.ReadLine();
            Console.WriteLine("enter price: ");
            int price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter quantity: ");
            int qty = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Image : ");
            string image = Console.ReadLine();
            Console.WriteLine("Enter description: ");
            string desc = Console.ReadLine();
            var p = new Product(id, name, price, qty, image, desc);
            if (cart.Add(Product))
            {
                Console.WriteLine("new product added: name= : " + name);
            }
            else
            {
                Console.WriteLine("Can not add " + name);
            }
        }

        public static Product Product { get; set; }

        private static void RemoveProduct()
        {
            Console.WriteLine("Enter existing product name: ");
            string str = Console.ReadLine();
            Product existingProduct = cart.Query(str);
            if (existingProduct == null)
            {
                Console.WriteLine("Product not found ");
                return;
            }

            if (cart.Remove(existingProduct))
            {
                Console.WriteLine("successful deleted");
            }
            else
            {
                Console.WriteLine("Error deleted contact");
            }
        }

        private static void QueryContact()
        {
            Console.WriteLine("Enter existing name: ");
            string name = Console.ReadLine();
            Product existingProduct = cart.Query(name);
            if (existingProduct == null)
            {
                Console.WriteLine("Product can not found ");
                return;
            }

            Console.WriteLine("name " + existingProduct.name + " exist in the cart");
        }

        private static void CancelTheCart()
        {
            Console.WriteLine("you have just cancel the cart :\\");
        }

        private static void PrintAction()
        {
            Console.WriteLine("\nAvailable actions: \npress "+"" +
                              "0 - To charge\n" +
                              "1 -To Add new Product\n" +
                              "2 -To Remove product\n" +
                              "3 -To Print your cart\n" +
                              "4 -To cancel\n" +
                              "5 -5 to show a list available actions\n");
                              
        }
    }
}