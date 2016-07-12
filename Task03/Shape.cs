using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task03
{
    interface IShape
    {
        double Area();
        double Perimeter();
    }

    public class Circle : IShape
    {
        public double Radius { get; set; }

        public double Area()
        {
            return Math.PI*Radius*Radius;
        }

        public double Perimeter()
        {
            return Math.PI*2*Radius;
        }
    }

    public class Triangle : IShape
    {
        public double HeightToFirstSide { get; set; }

        public double FirstSide { get; set; }

        public double SecondSide { get; set; }

        public double ThirdSide { get; set; }

        public double Area()
        {
            return 0.5*HeightToFirstSide*FirstSide;
        }

        public double Perimeter()
        {
            return FirstSide + SecondSide + ThirdSide;
        }
    }

    public class Rectangle : IShape
    {
        public double FirstSide { get; set; }
        public double SecondSide { get; set; }

        public double Area()
        {
            return FirstSide * SecondSide;
        }

        public double Perimeter()
        {
            return 2*(FirstSide + SecondSide);
        }
    }

    public class Square : IShape
    {
        public double Side { get; set; }

        public double Area()
        {
            return Side * Side;
        }

        public double Perimeter()
        {
            return 4 * Side;
        }
    }
}
