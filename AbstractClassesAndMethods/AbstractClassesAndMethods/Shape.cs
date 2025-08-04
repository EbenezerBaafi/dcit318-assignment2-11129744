using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassesAndMethods
{
    abstract class Shape
    {
        public abstract float GetArea();

    }

     class Circle : Shape
    {
        public double Radius 
        { 
            get; 
            set; 
        }
        public Circle(double radius)
        {
            Radius = radius;
        }
        public override float GetArea()
        {
            return (float)(Math.PI * Radius * Radius);
        }
    }

     class Rectangle : Shape
    {
        public double Width 
        { 
            get; 
            set; 
        }
        public double Height 
        { 
            get; 
            set; 
        }
        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }
        public override float GetArea()
        {
            return (float)(Width * Height);
        }
    }
}
