using System;
namespace FactoryPattern
{
	public class Motorcycle : IVehicle
	{
        //Constructor
        public Motorcycle()
		{
		}

        //Implementation of the IVehicle Drive method
        public void Drive()
        {
            Console.WriteLine("The motorcycle is revving up!");
            Console.WriteLine("Vrooooooommmmm");
            //Suggested from instructions - Console.WriteLine(“Building a new Car!”)
        }
    }
}

