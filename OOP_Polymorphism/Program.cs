using OOP_Polymorphism;

internal class Program
{
    private static void Main(string[] args)
    {

        Dog dog = new Dog("Patron","Kangal");
        Dog dog1 = new Dog("Hector");
        Dog dog2 = new Dog("Haydut", "Fino");
        Cat cat = new Cat("Hardal", "Tricolour");

        dog.infoText();
        dog1.infoText();
        dog2.infoText();

        cat.infoText();



        Console.ReadKey();



    }
}