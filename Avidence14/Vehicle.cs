using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avidence14
{
    internal abstract class Vehicle
    {
        // ModelNo, YearMake, NumberOfGear, EngCapacity
        public string ModelNo {  get; set; }
        public int YearMake {  get; set; }
        public int NumberOfGear {  get; set; }
        public int EngCapacity {  get; set; }
        public VehicleType Vtype {  get; set; }

        //public Vehicle(string modelNo,int yearMake, int numberOfGear, int engCapacity, VehicleType vType)
        //{
        //    ModelNo = modelNo;
        //    YearMake = yearMake;
        //    NumberOfGear = numberOfGear;
        //    EngCapacity = engCapacity;
        //    Vtype = vType;
        //}

        // enum for Vehicle Type
        public enum VehicleType{ Car, MotorCycle }
    }
}
