using OOP_Inheritance;

internal class Program
{
    private static void Main(string[] args)
    {
        // Human sınıfından human adı verdiğim bir nesne yaratıldı...classın tüm açık olarak ayarlamış propertylerine bilgi girebilirim..

        Human human = new Human();

        human.Name = "Ümit";
        human.Surname = "Karaçivi";
        human.Gender = "E";
        human.Age = 58;
        human.Address = "Foça";

        Personnel personnel= new Personnel();

        personnel.Name = "Nurgül";
        personnel.Age = 30;
        personnel.Address = "Bursa";


        SalesRep salesRep= new SalesRep();

        salesRep.SalesAmount = 500;
        salesRep.Name = "Abuzittin";
        salesRep.Age = 30;
        salesRep.Title = "Satış sorumlusu";

        Customer customer= new Customer();

        customer.CompanyName = "Novas Works Ltd.";
        customer.Name = "Ümit K";

        


        Console.ReadKey();  
    }
}