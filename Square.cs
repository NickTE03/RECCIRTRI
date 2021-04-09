using System;
using System.Collections.Generic;
using System.Text;

namespace RECCIRTRI
{
    public class Square : Shape
    {
        private double side = 1;

        public Square(double side)
        {
            SetSide(side);

        }

        public override double GetArea()
        {
            return side * side;
        }

        public override double GetPerimeter()
        {
            return 4 * side;
        }

        public double GetSide()
        {
            return side;
        }

        public void SetSide(double side)
        {
            if (side <= 0)
            {
                side = -side;
            }
            this.side = side;
        }
    }
}
