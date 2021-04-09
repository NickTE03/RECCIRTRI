using System;
using System.Collections.Generic;
using System.Text;

namespace RECCIRTRI
{
    public class Rectangle : Shape
    {
        

        private double length;
        private double width;


       

        public Rectangle()
            : this(1.0, 1.0)
        {

        }

        public Rectangle(double length, double width)
        {
            if (length <= 0)
            {
                length = 1;
            }
            // or you can do this.
            if (width <= 0)
            {
                width = -width;
            }
            this.length = length; // parameter only
            this.width = width;
        }



        


        public override double GetArea()
        {
            return this.length * this.width;
        }

        public double GetLength()
        {
            return this.length;
        }

        public override double GetPerimeter()
        {
            throw new NotImplementedException();
        }

        public double GetWidth()
        {
            return this.width;
        }



        public void SetLength(double length)
        {
            if (length <= 0)
            {
                length = -length;
            }
            this.length = length;


        }


        public void SetWidth(double width)
        {
            if (width <= 0)
            {
                width = -width;
            }
            this.width = width;
        }

    }
}
