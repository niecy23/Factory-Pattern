using System;
namespace FactoryPattern
{
	public static class VehicleFactory
	{
		//Method for the VehicleFactory class that creates
		//a new vehicle based on the amount of tires provided.
		public static IVehicle GetVehicle(int wheelCount)
		{
			////Alternate solution
			//if (wheelCount == 4)
			//{
			//	return new Car();
			//}
			//else
			//{
			//	return new Motorcycle();
			//}

			switch (wheelCount)
			{
				case 2:
					return new Motorcycle();

				default:
					return new Car();

			}
		}
    }
}

