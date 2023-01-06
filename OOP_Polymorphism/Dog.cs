using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Polymorphism
{
    internal class Dog : Animal
    {
        public Dog(string name)
        {
            this.name = name;
            this.type = "Köpiş...";
            this.sound = "Hev hev";

        }

        public Dog(string name,string type)
        {
            this.name = name;
            this.type = type;
            this.sound = "Hav hav";
        }
        

    }
}
