using System;
namespace Assignment
{

        public class Circle : Shape
        {
            private const double Pi = 3.14159;
            private double radius;

            public Circle(double radius)
            {
                this.radius = radius;
            }

            public override double CalculateArea()
            {
                return Pi * radius * radius;
            }
        }

    }

