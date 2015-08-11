using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Test
{
    public class Triangle
    {
        private double side_1 { get; set; }
        private double side_2 { get; set; }
        private double side_3 { get; set; }

        public Triangle() { }
        public Triangle(double side_1, double side_2, double side_3)
        {
            this.side_1 = side_1;
            this.side_2 = side_2;
            this.side_3 = side_3;
        }

        public double Perimeter()
        {
            return side_1 + side_2 + side_3;
        }

        public double Area()
        {
            double area, semiperimeter = this.Perimeter() / 2;            
            area = System.Math.Sqrt(semiperimeter * (semiperimeter - side_1) * (semiperimeter - side_2) * (semiperimeter - side_3));
            return area;
        }

    }
}
