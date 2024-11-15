using System;

namespace VehicleRental
{
    public class Vehicle
    {
        public string name;
        public string model;
        public string fuelType;

        public Vehicle(string name, string model, string fuelType)
        {
            this.name = name;
            this.model = model;
            this.fuelType = fuelType;
        }

        public virtual void Start()
        {
            Console.WriteLine($"The vehicle '{name}' is just about to start");
        }

        public virtual void Stop()
        {
            Console.WriteLine($"The vehicle has stopped due to an issue. It appears that the fuel type '{fuelType}' may be unsuitable.");
        }

        public virtual decimal CalculateRentalPrice(int rentalDuration)
        {
            return 0;
        }
    }

    public class Car : Vehicle
    {
        public Car(string  name, string model, string fuelType) : base(name, model, fuelType)
        {
            Console.WriteLine("\nThe Car section:");
        }

        public override void Start()
        {
            Console.WriteLine($"The Car '{name} {model}' is just about to start");
        }

        public override void Stop()
        {
            Console.WriteLine($"The Car has stopped due to an issue. It appears that the fuel type '{fuelType}' may be unsuitable.");
        }

        public override decimal CalculateRentalPrice(int rentalDuration)
        {
            decimal pricePerHour = 20.0m; 
            return pricePerHour * rentalDuration;
        }
    }

    public class Truck : Vehicle
    {
        public Truck(string name, string model, string fuelType) : base(name, model, fuelType)
        {
            Console.WriteLine("\nThe Truck section:");
        }

        public override void Start()
        {
            Console.WriteLine($"The Truck '{name} {model}' is just about to start");
        }

        public override void Stop()
        {
            Console.WriteLine($"The Truck has stopped due to an issue. It appears that the fuel type '{fuelType}' may be unsuitable.");
        }

        public override decimal CalculateRentalPrice(int rentalDuration)
        {
            decimal pricePerHour = 30.0m;
            return pricePerHour * rentalDuration;
        }
    }

    public class Bike : Vehicle
    {
        public Bike(string name, string model, string fuelType) : base(name, model, fuelType)
        {
            Console.WriteLine("\nThe Bike section:");
        }

        public override void Start()
        {
            Console.WriteLine($"The Bike '{name} {model}' is just about to start");
        }

        public override void Stop()
        {
            Console.WriteLine($"The Bike has stopped due to an issue. It appears that the fuel type '{fuelType}' may be unsuitable.");
        }

        public override decimal CalculateRentalPrice(int rentalDuration)
        {
            decimal pricePerHour = 10.0m;
            return pricePerHour * rentalDuration;
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("\n\"System for managing a vehicle rental service\"\n");

            int rentalDuration = 10;


            var vehicle = new Vehicle("Toyota","asd","asd");
            vehicle.Start();
            vehicle.Stop();
            Console.WriteLine($"Rental price for car: ${vehicle.CalculateRentalPrice(rentalDuration)}");

            var car = new Car("adds", "ASdasd", "asdasd");
            car.Start();
            car.Stop();
            Console.WriteLine($"Rental price for car: ${car.CalculateRentalPrice(rentalDuration)}");

            var truck = new Truck("adds", "ASdasd", "asdasd");
            truck.Start();
            truck.Stop();
            Console.WriteLine($"Rental price for car: ${truck.CalculateRentalPrice(rentalDuration)}");

            var bike = new Bike("adds", "ASdasd", "asdasd");
            bike.Start();
            bike.Stop();
            Console.WriteLine($"Rental price for car: ${bike.CalculateRentalPrice(rentalDuration)}");

            Console.ReadLine();
        }
    }
}
