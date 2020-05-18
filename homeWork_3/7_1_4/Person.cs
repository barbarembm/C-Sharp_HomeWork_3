using System;
using System.Collections.Generic;
using System.Text;

namespace _7_1_4
{
    class Person
    {
        protected string Lastname, Name;
        protected byte Age;

        public Person(string Lastname, string Name, byte Age)
        {
            this.Lastname = Lastname;
            this.Name = Name;
            this.Age = Age;
        }
        public Person()
        {
            Lastname = "dzidziguri";
            Name = "barbi";
            Age = 13;
        }
        public void Write(Person write1)
        {
            Console.WriteLine($"Lastname: {write1.Lastname}\nName: {write1.Name}\nAge: {write1.Age}");
        }
    }
  

}
 
}
