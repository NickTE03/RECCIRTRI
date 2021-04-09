using System;
using System.Collections.Generic;
using System.Text;

namespace RECCIRTRI
{
    public class Triangle : Shape 
    {
        private double sideA = 7;
        private double sideB = 3;
        private double sideC = 3;

        public Triangle(double sideA, double sideB, double sideC)
        {
            SetSideA(sideA);
            SetSideA(sideB);
            SetSideA(sideC);
        }

        public override double GetArea()
        {
            double halfper = (sideA + sideB + sideC) / 2;
            return Math.Sqrt(halfper * (halfper - sideA) * (halfper - sideB) * (halfper - sideC));
           
        }

        public override double GetPerimeter()
        {
            return sideA + sideB + sideC;
        }

        public double GetSideA()
        {
            return sideA;
        }

        public double GetSideB()
        {
            return sideB;
        }

        public double GetSideC()
        {
            return sideC;
        }

        public void SetSideA(double sideA)
        {
            if (sideA <= 0)
            {
                sideA = -sideA;
            }
            this.sideA = sideA;
        }

        public void SetSideB(double sideB)
        {
            if (sideB <= 0)
            {
                sideB = -sideB;
            }
            this.sideB = sideB;
        }

        public void SetSideC(double sideC)
        {
            if (sideC <= 0)
            {
                sideC = -sideC;
            }
            this.sideC = sideC;
        }

    }
}
