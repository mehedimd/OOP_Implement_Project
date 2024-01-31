using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Avidence14
{
    internal class FourWheeler : Vehicle, IinteriorDesign
    {
        public int NumOfSeat {  get; set; }
        public int NumOfDoor {  get; set; }


        //public FourWheeler(string modelNo, int yearMake, int numberOfGear, int engCapacity, VehicleType vType, int numOfSeat, int numOfDoor) : base(modelNo, yearMake, numberOfGear, numOfSeat, vType)
        //{
        //    //Vtype = vType;
        //    //ModelNo = modelNo;
        //    //YearMake = yearMake;
        //    //NumberOfGear = numberOfGear;
        //    EngCapacity = engCapacity;
        //    NumOfSeat = numOfSeat;
        //    NumOfDoor = numOfDoor;

        //}

        public void InteriorDesign(Car car)
        {
            Console.WriteLine("Car Details:");
            Console.WriteLine($"Model No: {car.ModelNo}, Year Make: {car.YearMake},Number Of Gear: {car.NumberOfGear} Vehicle Type: {car.Vtype}, Number of Seat: {car.NumOfSeat}, Num Of Door: {car.NumOfDoor} ");
        }

    }
}
