using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Inheritance
{
    internal class Human
    {
        // Classımın özelliklerini (properties) tanımlıyorum. Dışardan erişilebilmesi için de public
        // access modifier kullanıyor.

        public string Name { get; set; }
        public string Surname { get; set; }
        public string TRIDNo { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }

    }
}
