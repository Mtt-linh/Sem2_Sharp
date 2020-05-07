using System;
using System.Diagnostics;

namespace Sem2.Session6
{
    public class marth
    {
        public static void Main(string[] args)
        {
            integer tl = new integer(total);
            integer ms = new integer(minus);
            integer my = new integer(multiply);
            integer de = new integer(divide);
            Boolean quit  = false;
            switch (!quit)
            {
               
            }
        }

        private static void PrintAction()
        {
            throw new NotImplementedException();
        }

        public delegate int integer(int a, int b);

        public static int total(int a, int b)
        {
            return a + b;
        }

        public static int minus(int a, int b)
        {
            return a - b;
        }

        public static int multiply(int a, int b)
        {
            return a * b;
        }

        public static int divide(int a, int b)
        {
            return a / b;
        }
    }
}