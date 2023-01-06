namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Scope - Creating a new vehicle based on the amount of tires provided
            Console.WriteLine($"Enter the amount of tires for the vehicle that you want to create.");
            var wheelCount = int.Parse(Console.ReadLine());

            var vehicle = VehicleFactory.GetVehicle(wheelCount);

            //Calling the Drive method of the created vehicle
            vehicle.Drive();

        }
    }
}
