using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2hw
{
    public abstract class Figure
    {
        public virtual double GetSquare() 
        {
            return 0;
        }
        public virtual double GetPerimeter()
        {
            return 0;
        }
    }

    public class Triangle:Figure
    {
        readonly public double[] Sides;
        public Triangle(double side1,double side2, double side3)
        {
            if(side1 > 0 && side2 > 0 && side3 > 0 && 
                side1 + side2 > side3 && side1 + side3 > side2 && side2 + side3 > side1)
            {
                Sides = new double[] { side1, side2, side3 };
            }
            else
            {
                throw new ArgumentException();
            }
        }

        public override double GetSquare()
        {
            double p = this.GetPerimeter() / 2;
            return Math.Sqrt(p * (p - Sides[0]) * (p - Sides[1]) * (p - Sides[2]));
        }

        public override double GetPerimeter()
        {
            return Sides[0] + Sides[1] + Sides[2];
        }
    }
    public class Circle : Figure
    {
        public double R { get; set; }
        public Circle(double _r)
        {
            if (_r > 0)
            {
                R = _r;
            }
            else
            {
                throw new ArgumentException();
            }

        }

        public override double GetSquare()
        {
            return Math.PI * R * R;
        }

        public override double GetPerimeter()
        {
            return 2 * Math.PI * R;
        }
    }
    public class Rectangle : Figure
    {
        public double Height { get; set; }
        public double Width { get; set; }
        public Rectangle(double _height,double _width)
        {
            if (_height > 0 && _width > 0)
            {
                Height = _height;
                Width = _width;
            }
            else
            {
                throw new ArgumentException();
            }
        }
        public override double GetSquare()
        {
            return Height * Width;
        }

        public override double GetPerimeter()
        {
            return 2 * (Height + Width);
        }
    }
    public class Square : Rectangle
    {
        public Square(double side) : base(side, side) { }
    }
    public class Rhombus : Figure
    {
        public double Diagonal1 { get; set; }
        public double Diagonal2 { get; set; }
        public Rhombus(double _diag1, double _diag2)
        {
            if (_diag1 > 0 && _diag2 > 0)
            {
                Diagonal1 = _diag1;
                Diagonal2 = _diag2;
            }
            else
            {
                throw new ArgumentException();
            }
        }
        public override double GetSquare()
        {
            return (Diagonal1 * Diagonal2) / 2;
        }

        public override double GetPerimeter()
        {
            double side = Math.Sqrt(Math.Pow(Diagonal1 / 2, 2) + Math.Pow(Diagonal2 / 2, 2));
            return side * 4;
        }
    }

}
