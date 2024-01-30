using System;

interface IAnimal
{
    string Name { get; set; }
    string Colour { get; set; }
    string Height { get; set; }
    string Age { get; set; }

    void Eat();

    string Cry();
}
