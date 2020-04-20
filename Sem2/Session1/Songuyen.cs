using System;

namespace Sem2.Session1
{
    public class Songuyen
    {
        public static void Main(string[] args)
        {
            int number;
            Console.WriteLine("nhap vao mot so\n");
            number = Convert.ToInt32(Console.ReadLine());
            int first_fibo = 0, second_fibo = 1, next_fibo, i;
            for (i = 0; first_fibo + second_fibo < number; i++)
            {
                if (i <= 1)
                {
                    next_fibo = i;
                }
                else
                {
                    next_fibo = first_fibo + second_fibo;
                    first_fibo = second_fibo;
                    second_fibo = next_fibo;
                }
            }

            Console.WriteLine("the Fibonacci number near " + number + " is: ");
            Console.WriteLine(second_fibo);
        }
    }
}