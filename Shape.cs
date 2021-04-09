using System;
using System.Collections.Generic;
using System.Text;

namespace RECCIRTRI
{
    public abstract class Shape
    {
        private string color;

        public string GetColor()
        {
            return color;
        }

        public void SetColor(string color)
        {
            this.color = color;
        }

        public abstract double GetArea();


        public abstract double GetPerimeter();

        
    }

    
}
