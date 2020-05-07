using System;
using System.Collections.Generic;
using Sem2.Session4;

namespace Sem2.Assignment4
{
    public class Customer
    {
        protected int Id;
        protected string name;
        protected string nationality;
        protected DateTime Date;
        protected string species; // doi tuong khach hang 
        protected int amount; // so luong 
        protected double price; // dơn gia 
        protected double quota; // dinh muc 

        public Customer()
        {
        }

        public Customer(int id, string name,string nationality, DateTime date, string species, int amount, double price, double quota)
        {
            Id = id;
            this.name = name;
            this.nationality = nationality;
            Date = date;
            this.species = species;
            this.amount = amount;
            this.price = price;
            this.quota = quota;
        }

        public void GetInfo()
        {
            System.Console.WriteLine("\nID: " + this.Id +
                              "\nHo va ten: " + this.name +
                              "\nQuoc tich: "+this.nationality+
                              "\nNgay thanh toan : " + this.Date +
                              "\nKhach hang thuoc :" + this.species +
                              "\nSo KW : " + this.amount +
                              "\nDon gia : " + this.price +
                              "\nDinh muc su dung :" + this.quota);
        }

        public int Id1
        {
            get => Id;
            set => Id = value;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public DateTime Date1
        {
            get => Date;
            set => Date = value;
        }

        public string Species
        {
            get => species;
            set => species = value;
        }

        public int Amount
        {
            get => amount;
            set => amount = value;
        }

        public double Price
        {
            get => price;
            set => price = value;
        }

        public double Quota
        {
            get => quota;
            set => quota = value;
        }

        public double Total1()
        {
            double total = 0;
            if (nationality.Equals("Viet Nam "))
            {
                if (quota <=50)
                {
                    total = quota * 1000;
                }

                if (50<quota && quota<=100)
                {
                    total = quota * 1000 + (quota - 50) * 2000;
                }

                if (100<quota && quota<=200)
                {
                    total = quota * 1000 + (quota - 50) * 1200 + (quota - 100) * 1500;
                }

                if (quota>200)
                {
                    total = quota * 1000 + (quota - 50) * 1200 + (quota - 100) * 1500 + (quota - 120) * 2000;
                }
            }

            return total;
        }

        public double Total2()
        {
            double total = 0;
            if (nationality!= ("Viet Nam"))
            {
                return total = quota * 2000;
                
            }

            return total;
        }
    }
}