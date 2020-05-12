using System;
using System.ComponentModel.Design;
using System.Diagnostics;

namespace Sem2.Assignment7
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Student[] StudentList = new Student[7];
            int st = int.Parse(System.Console.ReadLine());
            StudentList = new Student[st];
            int index = 0;
            Menu:
            System.Console.Clear();
            System.Console.WriteLine("1.Add Student");
            System.Console.WriteLine("2.Edit Student");
            System.Console.WriteLine("3.Delete  student");
            System.Console.WriteLine("4.Sort student by Gpa");
            System.Console.WriteLine("5.Sort Student by Name");
            System.Console.WriteLine("6. Show Student");
            System.Console.WriteLine("0.Exit ");

            int number = Convert.ToInt32(System.Console.ReadLine());
            switch (number)
            {
                case 1:
                    
                    break;
            }
            

        }

        private static void AddStudent()
        {
            System.Console.WriteLine("Enter Id :");
            int id = Convert.ToInt32(System.Console.ReadLine());
            System.Console.WriteLine("Enter name :");
            string name = System.Console.ReadLine();
            System.Console.WriteLine("Enter Id :");
            int age = Convert.ToInt32(System.Console.ReadLine());
            System.Console.WriteLine("Enter Id :");
            string address= System.Console.ReadLine();
            System.Console.WriteLine("Enter Id :");
            double gpa = Convert.ToInt32(System.Console.ReadLine());
           
        }

    }
}