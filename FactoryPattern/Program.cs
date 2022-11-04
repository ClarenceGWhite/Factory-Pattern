namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfWheels;
            bool input = false;

            do
            {
                Console.WriteLine("How many tires do you want your vehicle to have? (2 or 4):");

                input = int.TryParse(Console.ReadLine(), out numOfWheels);

            } while (input == false);

            var vehicle = VehicleFactory.GetVehicle(numOfWheels);
            vehicle.Drive();




        }




        
    }
}
