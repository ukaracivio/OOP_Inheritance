using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Polymorphism
{
    internal class Animal
    {
        public string type;
        public string name;
        public string sound;
        string info;

        public string getInfo { get { return info; } } // bir bilgi döndüren bir prop

        public Animal()
        {
            // Constructor--yapıcı metot... class ile aynı adda
            // ilk initial değerleri alması için
            type = null;
            name = null;
            sound = null;
            info = null;

        }

        public Animal(string Type,string Sound)
        {
            // bu da ikinci bir constructor...ama polymorphism yapısını kullanıyor
            type= Type;
            sound = Sound;  

        }

        public Animal(string Type, string Sound,string Name)
        {
            // bu da üçüncü bir constructor...3lü parametre alıyor..polymorphisnm devrede

            type = Type;
            sound = Sound;
            name = Name;
        }

        public void infoText()
        {
            Console.WriteLine("Hayvanın kimliği --> \n\nTür: {0} - İsmi : {1} - Çıkardığı ses : {2}",type,name,sound);


        }



    }
}
