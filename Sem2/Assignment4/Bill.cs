using System;
using System.Collections.Generic;

namespace Sem2.Assignment4
{
    public class Bill
    {
        private int id;
        private double grandTotal;
        private double QuantityTotal;
        private List<Customer> ListCustomer;

        public Bill(int id, double grandTotal, double quantityTotal, List<Customer> listCustomer)
        {
            this.id = id;
            this.grandTotal = grandTotal;
            QuantityTotal = quantityTotal;
            ListCustomer = listCustomer;
        }

        public int Id
        {
            get => id;
            set => id = value;
        }

        public double GrandTotal
        {
            get => grandTotal;
            set => grandTotal = value;
        }

        public double QuantityTotal1
        {
            get => QuantityTotal;
            set => QuantityTotal = value;
        }

        public List<Customer> Customers
        {
            get => ListCustomer;
            set => ListCustomer = value;
        }

        public bool AddCustomer(Customer customer)
        {
            Customers.Add(customer);
            return true;
        }

        public double ResultTotal1()
        {
            double grand = 0;
            foreach (Customer tb in ListCustomer)
            {
                grand += tb.Total1();
            }

            this.grandTotal = grand;
            return grandTotal;
        }

        public double ResultTotal2()
        {
            double grand = 0;
            foreach (Customer tt in ListCustomer)
            {
                grand += tt.Total2();
            }

            this.grandTotal = grand;
            return grandTotal;
        }
        
    }
}