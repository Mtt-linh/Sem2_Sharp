using System;
using System.Collections.Generic;
using Sem2.Session2.assignment_2;

namespace Sem2.Assignment3
{
    public class Cart : product
    {
        private int id;
        private string customer;

        private int grandTotal;
        private string city;
        private string country;
        private List<product> Listproduct;
        private int total = 0;


        public Cart(int id, string customer, int grandTotal, string city, string country, List<product> listproduct)
        {
            this.id = id;
            this.customer = customer;
            this.grandTotal = grandTotal;
            this.city = city;
            this.country = country;
            this.Listproduct = new List<product>();
        }

        public int Find(product product)
        {
            return this.Listproduct.IndexOf(product);
        }

        public Boolean Add(product product)
        {
            if (Find(product) > 0)
            {
                Console.WriteLine("thoat ");
                return false;
            }

            Listproduct.Add(product);
            return true;
        }

        public Boolean Remove(product product)
        {
            int note = Find(product);
            if (note < 0)
            {
                Console.WriteLine(" product not found ");
                return false;
            }

            this.Listproduct.Remove(product);
            Console.WriteLine(" delete");
            return true;
        }

        public int Find(string name)
        {
            for (int i = 0; i < Listproduct.Count; i++)
            {
                var products = Listproduct[i];
                if (products.name.Equals(name))
                {
                    return i;
                }
            }

            return -1;
        }

        public void Print()
        {
            Console.WriteLine("customer : " + this.customer +
                              "\nCity: " + this.city +
                              "\nCountry: " + this.country);
            Console.WriteLine("cart:      ");
            for (int i = 0; i < Listproduct.Count; i++)
            {
                Console.WriteLine(Listproduct[i].id + ":" + Listproduct[i].name + "price" + Listproduct[i].Price +
                                  "Quantity" + Listproduct[i].qty + "Image" + Listproduct[i].image);
            }

            Console.WriteLine("your grand Total :" + GetGrandTotal());
        }

        public product Query(string name)
        {
            int position = Find(name);
            if (position >= 0)
            {
                return this.Listproduct[position];
            }

            return null;
        }

        public string Query(product product)
        {
            if (Find(product) >= 0)
            {
                return product.name;
            }

            return null;
        }

        public void SetTotal()
        {
            int a = GetTotal();
            if (this.country.Equals("Viet nam"))
            {
                if (this.city.Equals("ha noi") || this.city.Equals("hcm"))
                {
                    grandTotal = a + (a * 1 / 100);
                }
                else
                {
                    grandTotal = a + (a * 2 / 100);
                }
            }
            else
            {
                grandTotal = a + (a * 5 / 100);
            }

        }

        public int GetGrandTotal()
        {
            return grandTotal;
        }

        public int GetTotal()
        {
            for (int i = 0; i < Listproduct.Count; i++)
            {
                var product = Listproduct[i];
            }

            return total;
        }
    }
}