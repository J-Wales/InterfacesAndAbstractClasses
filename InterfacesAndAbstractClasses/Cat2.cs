using System;

class Cat2 : IAnimal
{
    public string Name { get; set; }
    public string Colour { get; set; }
    public string Height { get; set; }
    public string Age { get; set; }

    public void Eat()
    {
        Console.WriteLine("Cats eat mice.");
    }

    public string Cry()
    {
        return "Meow!";
    }
}