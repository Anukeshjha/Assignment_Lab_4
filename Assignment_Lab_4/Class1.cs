using System;

class Program
{
    static void Main(string[] args)
    {
        Car myCar = new Car("Toyota", "Camry", 2022);
        Console.WriteLine("Full Car Name: " + myCar.FullCarName);
    }
}
