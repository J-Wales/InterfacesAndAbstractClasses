using System;
abstract class Animal
{
    public string Name { get; set; }
    public string Colour { get; set; }
    public string Age { get; set; }

    public abstract void Eat();
}
