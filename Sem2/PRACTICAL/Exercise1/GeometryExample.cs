using System;
using Sem2.PRACTICAL.GeometryExample;

namespace Sem2.PRACTICAL.Exercise1
{
    public class GeometryExample
    {
        public static void Main(string[] args)
        {
            Cylinder c1=new Cylinder();
            System.Console.WriteLine("Enter the dimension of the cynlinder: ");
            System.Console.WriteLine("Radius: ");
            double radius = Convert.ToDouble(System.Console.ReadLine());
            System.Console.WriteLine("Height: ");
            double height = Convert.ToDouble(System.Console.ReadLine());
            c1.Process(radius,height);
            System.Console.WriteLine("Cylinder characteristics");
            System.Console.WriteLine("Radius: "+radius);
            System.Console.WriteLine("height: "+height);
            c1.Result();
        }
    }
}