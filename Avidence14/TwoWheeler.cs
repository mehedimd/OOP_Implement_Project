using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avidence14
{
    internal class TwoWheeler : Vehicle, IExteriorDesign
    {
        public string StartingMethod {  get; set; }
        public int MaxPowerBPH {  get; set; }
        public int MaxTorqueNM {  get; set; }
        public int MileageKMPL {  get; set; }
        public string Cooling {  get; set; }
        public string FrontBreak {  get; set; }
        public string RearBreak {  get; set; }


        //public TwoWheeler(string modelNo, int yearMake, int numberOfGear, int engCapacity, VehicleType vType, string startMethod, int maxPower,int maxTorque, int mileage, string cooling, string frontBreak, string rearBreak): base(modelNo,yearMake,numberOfGear,engCapacity, vType)
        //{
        //    //ModelNo = modelNo;
        //    //YearMake = yearMake;
        //    //NumberOfGear = numberOfGear;
        //    //EngCapacity = engCapacity;
        //    StartingMethod = startMethod;
        //    MaxPowerBPH = maxPower;
        //    MaxTorqueNM = maxTorque;
        //    MileageKMPL = mileage;
        //    Cooling = cooling;
        //    FrontBreak = frontBreak;
        //    RearBreak = rearBreak;


        //}

        public void ExteriorDesign(Motorcycle motorcycle)
        {
            Console.WriteLine("MotorCycle Details:");
            Console.WriteLine($"Model No: {motorcycle.ModelNo}, Year Make: {motorcycle.YearMake},Number Of Gear: {motorcycle.NumberOfGear} Vehicle Type: {motorcycle.Vtype}, Start Method: {motorcycle. StartingMethod}, Max Power: {motorcycle.MaxPowerBPH}, Max Torque: {motorcycle.MaxTorqueNM}, Milage: {motorcycle.MileageKMPL}, Cooling: {motorcycle.Cooling}, Front Break: {motorcycle.FrontBreak}, Rear Break: {motorcycle.RearBreak} ");
        }
    }
}
