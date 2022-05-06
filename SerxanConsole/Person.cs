using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerxanConsole
{
    public class Person
    {
        private string Name { get; set; }
        private string Surname { get; set; }
        private int Age { get; set; }
        private bool? IsMarried { get; set; }
        public Person()
        {

        }

        public Person(string Name, string Surname)
        {
            this.Name = Name;
            this.Surname = Surname;
        }

        public Person(string Name, string Surname, int Age, bool IsMarried)
        {
            this.Name = Name;
            this.Surname = Surname;
            this.Age = Age;
            this.IsMarried = IsMarried;
        }

        public void Display()
        {
            Console.WriteLine("Name: {0} , Surname: {1}, Age {2}, IsMarried {3}", Name, Surname, Age, IsMarried);
        }
    }
}
