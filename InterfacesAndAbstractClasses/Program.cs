namespace InterfacesAndAbstractClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog2 dog = new Dog2();
            Console.WriteLine("Enter dog name:");
            dog.Name = Console.ReadLine();
            Console.WriteLine("Enter dog height:");
            dog.Height = Console.ReadLine();
            Console.WriteLine("Enter dog colour:");
            dog.Colour = Console.ReadLine();
            Console.WriteLine("Enter dog age:");
            dog.Age = Console.ReadLine();

            Console.WriteLine(dog.Name);
            Console.WriteLine(dog.Height);
            Console.WriteLine(dog.Colour);
            Console.WriteLine(dog.Age);

            dog.Eat();

            Console.WriteLine($"The dog says: {dog.Cry()}");



            Cat2 cat = new Cat2();
            Console.WriteLine("Enter cat name:");
            cat.Name = Console.ReadLine();
            Console.WriteLine("Enter cat height:");
            cat.Height = Console.ReadLine();
            Console.WriteLine("Enter cat colour:");
            cat.Colour = Console.ReadLine();
            Console.WriteLine("Enter cat age:");
            cat.Age = Console.ReadLine();

            Console.WriteLine(cat.Name);
            Console.WriteLine(cat.Height);
            Console.WriteLine(cat.Colour);
            Console.WriteLine(cat.Age);

            cat.Eat();

            Console.WriteLine($"The cat says: {cat.Cry()}");

            var animals = new List<IAnimal>();

            animals.Add(new Cat2 { Name = "Mara" });
            animals.Add(new Cat2 { Name = "Sheo " });
            animals.Add(new Cat2 { Name = "Fab " });

            foreach (var animal in animals)
            {
                Console.WriteLine(animal.Name);
            }

            Console.ReadLine();
        }
    }
}
