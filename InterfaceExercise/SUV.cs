using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class SUV : IVehicle ,ICompany
    {
        public int NumberOfWheels { get; set; } = 4;
        public bool IsDrivable { get; set; }=true;
        public string Logo { get; set; } = "none";

        public string HQCity { get; set; } = "none";

        public string Color { get; set; } = "none";

        public bool HasWindshieldWipers(bool answer)
        {
            return (answer) ?true:false;
        }
        public int CargoSize(string size) { return int.Parse(size); }
        public bool SnowChains(bool chains) { return  (chains) ?true:false; }
        public void Park()
        {
            Console.WriteLine($"{GetType().Name} is parking at school now...");
        }
        public void Drive()
        {
            Console.WriteLine((IsDrivable)?$"{GetType().Name} is driving to pick up little people":$"{GetType().Name} is broken");

        }
    }
}
