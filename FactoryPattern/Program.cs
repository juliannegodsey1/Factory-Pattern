namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many wheels does the vehicle you'd like to build have?");
            var userInput = int.Parse(Console.ReadLine());

            IVehicle myVehicle = VehicleFactory.GetVehicle(userInput);

            myVehicle.Drive();
            

        }
    }
}
