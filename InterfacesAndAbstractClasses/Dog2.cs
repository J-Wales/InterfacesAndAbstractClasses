using System;

class Dog2 : IAnimal
{
    public string Name { get; set; }
    public string Colour { get; set; }
    public string Height { get; set; }
    public string Age { get; set; }

    public void Eat()
    {
        Console.WriteLine("Dogs eat meat.");
    }

    public string Cry()
    {
        return "Woof!";
    }
}
