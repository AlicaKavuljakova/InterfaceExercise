using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class Truck : IVehicle,ICompany
    {
        public int NumberOfWheels { get; set; } = 4;
        public bool IsDrivable { get; set; }= true;
        public string Logo { get; set; } = "none";
        public string HQCity { get; set; } = "none";

        public string Color { get; set; } = "none";

        public bool HasWindshieldWipers(bool answer)
        {
            return answer;
        }
        public bool HasBed(bool respond) => (respond) ? true : false; 
        public bool FourWheelDrive(bool drive) { return (drive ? true : false);  }
        public void Park()
        {
            Console.WriteLine($"{GetType().Name} is parking now...");
        }
        public void Drive()
        {
            if(IsDrivable) { Console.WriteLine("Truck is driving"); }

        } 
    }
}
