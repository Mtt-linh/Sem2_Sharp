using System;

namespace Sem2.PRACTICAL.GeometryExample
{
    public class Cylinder
    {
       
        public double BaseArea;
        public double LateralArea;
        public double TotalArea;
        public double Volume;

        public   void Process(double radius , double height)
        {
            
            BaseArea =  radius * radius * Math.PI;
            LateralArea = 2 * Math.PI * radius * height;
            TotalArea = 2 * Math.PI * radius * (height + radius);
            Volume = Math.PI * radius * radius * height;
        }

        public   void Result()
        {
            System.Console.WriteLine("Base Area :"+ this.BaseArea+
                                     "\n Lateral Area :"+this.LateralArea+
                                     "\n Total Area : " +this.TotalArea+
                                     "\n Volume"+this.Volume);
        }

       
    }
}