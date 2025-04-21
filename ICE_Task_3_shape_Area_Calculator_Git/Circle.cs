using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICE_Task_3_shape_Area_Calculator_Git
{
    class Circle : Shape, ICalculateArea
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public double CalculateArea()
        {
            double area = Math.PI * Radius * Radius;
            return area;
        }

        public override void Display()
        {
            Console.WriteLine($"Area of Circle: {CalculateArea()}");
        }

        bleh
    }
}
