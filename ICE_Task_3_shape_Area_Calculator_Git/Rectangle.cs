using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICE_Task_3_shape_Area_Calculator_Git
{
    class Rectangle : Shape, ICalculateArea
    {
        public double Length { get; set; }
        public double breadth { get; set; }

        public Rectangle(double length, double breadth)
        {
            this.Length = length;
            this.breadth = breadth;
        }

        public double CalculateArea()
        {
            double area = Length * breadth;
            return area;
        }

        public override void Display()
        {
            Console.WriteLine($"Area of Rectangle: {CalculateArea()}");
        }

    }
}
