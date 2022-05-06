using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerxanConsole
{
    public abstract class Shape
    {
        private string Name { get; set; }
      
        public double Width { get; set; }
        public double Height { get; set; }

        public abstract double GetArea();

        public double GetPerimeter()
        {
            return Width + Height;
        }
        

        public void Display()
        {
            Console.WriteLine("Name: {0} , Width: {1}, Height {2}", Name, Width, Height);
        }

        public Shape(string Name, double Width, double Height)
        {
            this.Name = Name;
            this.Width = Width;
            this.Height = Height;
        }

    }
}
