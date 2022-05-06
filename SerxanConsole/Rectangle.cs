using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerxanConsole
{
    public class Rectangle : Shape
    {
        public override double GetArea()
        {
            return Width * Height;
        }

        //public double GetPerimeter()
        //{
        //    return 2 * (Width + Height);
        //}

        public Rectangle(string Name, double Width, double Height) : base(Name, Width, Height)
        {
         
        }
    }
}
