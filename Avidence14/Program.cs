using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;
using static Avidence14.Vehicle;

namespace Avidence14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string response = "";
                do
                {
                    Console.WriteLine("Create Vehicle- Type '2' for Motorcycle or '4' for Car.");
                    int type = int.Parse(Console.ReadLine());
                    if (type == 4)
                    {
                        Console.WriteLine("Enter Car Details:");
                        Car car = new Car();
                        Console.WriteLine("Enter Model No");
                        car.ModelNo = Console.ReadLine();
                        Console.WriteLine("Enter Making Year");
                        car.YearMake = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter Number Of Gear");
                        car.NumberOfGear = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter Enginne Capacity");
                        car.EngCapacity = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter Num of Door");
                        car.NumOfDoor = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter Num of Seat");
                        car.NumOfSeat = int.Parse(Console.ReadLine());
                        car.Vtype = VehicleType.Car;

                        FourWheeler fourWheel = new FourWheeler();
                        fourWheel.InteriorDesign(car);

                    }
                    if (type == 2)
                    {
                        Console.WriteLine("Enter MotorCycle Details:");
                        Motorcycle motorcycle = new Motorcycle();
                        Console.WriteLine("Enter Model No");
                        motorcycle.ModelNo = Console.ReadLine();
                        Console.WriteLine("Enter Making Year");
                        motorcycle.YearMake = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter Number Of Gear");
                        motorcycle.NumberOfGear = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter Enginne Capacity");
                        motorcycle.EngCapacity = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter Starting Method");
                        motorcycle.StartingMethod = Console.ReadLine();
                        Console.WriteLine("Enter Max Power");
                        motorcycle.MaxPowerBPH = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter Max Torque (NM)");
                        motorcycle.MaxTorqueNM = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter Milage (KMPL)");
                        motorcycle.MileageKMPL = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter Cooling)");
                        motorcycle.Cooling = Console.ReadLine();
                        Console.WriteLine("Enter Front Break");
                        motorcycle.FrontBreak = Console.ReadLine();
                        Console.WriteLine("Enter Rear Break");
                        motorcycle.RearBreak = Console.ReadLine();
                        motorcycle.Vtype = VehicleType.MotorCycle;

                        TwoWheeler twoWheeler = new TwoWheeler();
                        twoWheeler.ExteriorDesign(motorcycle);

                    }
                    else
                    {
                        Console.WriteLine("Choose a valid Vehicle Type");
                    }

                } while (response.ToLower() == "yes");
                Console.WriteLine("Do you Want to Create another Vehicle? say 'yes' to create Vehicle. Otherwise go back");
                response = Console.ReadLine();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally 
            {
                Console.WriteLine("Thank You..");
            }
            


            // Car
            //Car car1 = new Car("M90", 2019, 6, 300, VehicleType.Car, 5, 4);
            //        // Console.WriteLine($"ModelNo: {car1.ModelNo}, MakingDate: {car1.YearMake}");
            //car1.InteriorDesign();


            // Motorcycle
            //Motorcycle m1 = new Motorcycle("Moto69", 2016, 5, 250, VehicleType.MotorCycle, "Celse and Menual", 3000, 55, 15000, "Yes", "Yes", "Yes");
            //        // Console.WriteLine($"ModelNo {m1.ModelNo}, Cooling: {m1.Cooling}, Engine Capacity: {m1.EngCapacity}, VehicleType: {m1.Vtype}");
            //m1.ExteriorDesign();

            Console.ReadKey();
            

        }
    }
}
