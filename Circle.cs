using System;
using System.Collections.Generic;
using System.Text;

namespace RECCIRTRI
{
   
    public class Circle : Shape
    {
        private double radius = 1;

        public Circle(double radius)
        {
            SetRadius(radius);

        }

        public override double GetArea()
        {
            return Math.PI * this.radius * this.radius; 
        }

        public double GetCircumference()
        {
            return 2 * Math.PI * this.radius;
        }

        public override double GetPerimeter()
        {
            throw new NotImplementedException();
        }

        public double GetRadius()
        {
            return radius;
        }

        public void SetRadius(double radius)
        {
            if (radius <= 0)
            {
                radius = -radius;
            }
            this.radius = radius;
        }
    }

   
    

    

    
}
