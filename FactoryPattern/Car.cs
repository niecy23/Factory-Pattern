using System;
namespace FactoryPattern
{
	public class Car : IVehicle
	{
        //Constructor
		public Car()
		{
		}

        //Implementation of the IVehicle Drive method
        public void Drive()
        {
            Console.WriteLine("The car is driving! Wooo!");
            //Suggested from instructions - Console.WriteLine(“Building a new Car!”)
        }
    }
}

