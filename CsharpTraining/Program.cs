// See https://aka.ms/new-console-template for more information
using CsharpTraining.Snippets;

List<Vehicle> vehicleList = new List<Vehicle>();

Car car = new Car("Honda", "Civic", "2008");
car.NumberOfDoors = 4;
vehicleList.Add(car);

Motorcycle motorcycle = new Motorcycle("Honda", "SH125", "2024");
vehicleList.Add(motorcycle);

foreach (var item in vehicleList)
{
    Console.WriteLine($"year: {item.Year}");
    Console.WriteLine($"brand: {item.Brand}");
    Console.WriteLine($"model: {item.Model}");
}

OrangeJuice orangeJuice = new OrangeJuice();
Cup cup = new Cup(orangeJuice);
cup.Fill();

Water water = new Water();  
Cup cup2 = new Cup(water);
cup2.Fill();