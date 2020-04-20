using System;
using System.Collections.Generic;

namespace Sem2.Session2.assignment_2
{
    public class Product
    {
        public int id;
        public string name;
        public double Price;
        private int qty;
        public string image;
        public string desc;
        public List<string> gallery;

        public Product(int id, string name, double price, int qty, string image, string desc)
        {
            this.id = id;
            this.name = name;
            Price = price;
            this.qty = qty;
            this.image = image;
            this.desc = desc;
        }

        public Product()
        {
        }

        public string GetInfo()
        {
            return "ID : " + id +
                   "\nName: " + name +
                   "\nPrice: " + Price +
                   "\nQty: " + qty +
                   "\nimage: " + image +
                   "\ndesc: " + desc
                ;
        }

        public void instock(int qty)
        {
            if (qty > 0)
            {
                Console.WriteLine("con hang ");
                return;
            }
            else
            {
                Console.WriteLine("het hang ");
                return;
            }
        }

        public void galleryAdd(string file)
        {
            if (gallery.Count < 10)
            {
                gallery.Add(file);
            }
            else
            {
                for (var i = 0; i < 10; i++)
                {
                    Console.WriteLine(gallery[i]);
                }

                Console.WriteLine("chon file ban muon xoa");
                int number;
                number = Convert.ToInt32(Console.ReadLine());
                gallery.Remove(gallery[number]);
                gallery.Add(file);
            }
        }
    }
}