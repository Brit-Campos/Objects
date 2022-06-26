class Objects
{
    static void Main(string[] args)
    {
        // object = An instance of a class
        //          A class can be used as a blueprint to create objects (OOP)
        //          Objects can have fields & methods (characteristics & actions)

        Human human1 = new Human();

        human1.name = "Rick";
        human1.age = 65;

        human1.Eat();
        human1.Sleep();

        Console.ReadKey();
    }
}

class Human
{
    public String name;
    public int age;

    public void Eat()
    {
        Console.WriteLine(name + " is eating.");
    }
    public void Sleep()
    {
        Console.WriteLine(name + " is sleeping.");
    }
}