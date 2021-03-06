﻿using System;
using System.Collections.Generic;

namespace Sem2.Session2.assignment_2
{
    public class Product
    {
        public int id;
        public string name;
        public double Price;
        public int qty;
        public string image;
        public string desc;
        public List<string> gallery;

        public Product(int id, string name, double price, int qty, string image, string desc)
        {
            this.id = id;
            this.name = name;
            this.Price = price;
            this.qty = qty;
            this.image = image;
            this.desc = desc;
        }
        

        public Product()
        {
        }

        public void GetInfo()
        {

            System.Console.WriteLine("ID : " + this.id +
                                     "\nName: " + this.name +
                                     "\nPrice: " + this.Price +
                                     "\nQty: " + this.qty +
                                     "\nimage: " + this.image +
                                     "\ndesc: " + this.desc);
           /* Console.WriteLine("ID : " + id +
                              "\nName: " + name +
                              "\nPrice: " + Price +
                              "\nQty: " + qty +
                              "\nimage: " + image +
                              "\ndesc: " +desc);*/
             return;
        }

        public void show(string name)
        {
            System.Console.WriteLine(name);
           return;
        }

        public void instock(int qty)
        {
            if (qty > 0)
            {
                System.Console.WriteLine("con hang ");
                return;
            }
            else
            {
                System.Console.WriteLine("het hang ");
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
                    System.Console.WriteLine(gallery[i]);
                }

                System.Console.WriteLine("chon file ban muon xoa");
                int number;
                number = Convert.ToInt32(System.Console.ReadLine());
                gallery.Remove(gallery[number]);
                gallery.Add(file);
            }
        }
    }
}
