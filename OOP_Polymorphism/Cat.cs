using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Polymorphism
{
    internal class Cat : Animal
    {
        public Cat(string name)
        {
            this.name = name;
            this.type = "sarman...";
            this.sound = "miyav miyav";

        }

        public Cat(string name, string type)
        {
            this.name = name;
            this.type = type;
            this.sound = "Meoww meoww";
        }
    }
}
