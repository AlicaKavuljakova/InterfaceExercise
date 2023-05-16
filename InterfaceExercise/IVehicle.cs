using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public  interface IVehicle
    {
        public int NumberOfWheels { get; set; }
        public bool IsDrivable { get; set; }
        public bool HasWindshieldWipers(bool answer);
        public string Color { get; set; }
        public void Park();
        public void Drive();

    }
}
