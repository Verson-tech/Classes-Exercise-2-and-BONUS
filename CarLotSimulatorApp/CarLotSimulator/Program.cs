using System;
using System.Security.Cryptography.X509Certificates;


namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property
            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car
            var carLot = new CarLot();
            //carLot.ParkingLot = new List<Car>();   alternatively can be done in CarLot.cs

            // 1) .notation
            var car1 = new Car();
            car1.Year = 2016;
            car1.Make = "Nissan";
            car1.Model = "Micra";
            car1.EngineNoise = "Engine noise.";
            car1.HonkNoise = "Honk!";
            car1.IsDrivable = true;
            car1.MakeEngineNoise(car1.EngineNoise);
            car1.MakeHonkNoise(car1.HonkNoise);
            
            // 2) Object initializer
            var car2 = new Car()
            {
                Year = 2016,
                Make = "GMC",
                Model = "Limited",
                EngineNoise = "Engine noise 2.",
                HonkNoise = "Honk 2!",
                IsDrivable =true

            };
            car2.MakeEngineNoise(car2.EngineNoise);
            car2.MakeHonkNoise(car2.HonkNoise);

            //3) Constructor
            var car3 = new Car(2018, "Ford", "n/a", "Engine noise 3", "Honk 3!", true);
            car3.MakeEngineNoise(car3.EngineNoise);
            car3.MakeHonkNoise(car3.HonkNoise);
            //*************BONUS*************//
            carLot.ParkingLot.Add(car1);
            carLot.ParkingLot.Add(car2);
            carLot.ParkingLot.Add(car3);
            
            Console.WriteLine($"Number of cars created: {CarLot.numberOfCars} cars");

            foreach(var i in carLot.ParkingLot)
            {
                Console.WriteLine($"Parking lot inventory: \n1. {i.Make} \n2. {i.Year} \n3. {i.Model}");

            }
            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console

        }
    }
}
