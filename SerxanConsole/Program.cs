using System;

namespace SerxanConsole
{
   
    class Program
    {
        static void Main(string[] args)
        {

            //Person p1 = new Person("Serxan", "Hacibeyov");
            //Person p2 = new Person("Xadica", "Allahverdi", 23, false);
            //p1.Display();
            //p2.Display();

            Rectangle rc = new Rectangle("Rect1", 20, 10);
            rc.Display();
            Console.WriteLine(rc.GetArea());
            Console.WriteLine(rc.GetPerimeter());
        }
    }
}
