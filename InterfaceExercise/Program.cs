using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var car = new Car();
            car.HasSunroof(true);
            car.TrunkSize("25");
            car.IsDrivable = true;
            car.HasWindshieldWipers(true);
            car.Logo = "Mariner";
            car.NumberOfWheels = 4;
            car.HQCity = "Los Angeles";
            

            var matter = new Truck();
            matter.NumberOfWheels = 4;
            matter.IsDrivable = true;
            matter.FourWheelDrive(true);
            matter.Logo = "Dinoco";
            matter.HQCity = "Radiator Springs";
            matter.Color="brown";
            matter.HasWindshieldWipers(false);

            var momsCar = new SUV();
            momsCar.Color = "pink";
            momsCar.IsDrivable= !true;
            momsCar.NumberOfWheels= 4;
            momsCar.CargoSize("25");
            momsCar.HQCity = "Oklahoma City";
            momsCar.Logo = "Baby on board";
            momsCar.HasWindshieldWipers(false);


           var vehicles=new List<IVehicle>() { momsCar,matter};
            
            vehicles.Add(car);
            foreach(var vehicle in vehicles)
            {
                vehicle.Drive();
                vehicle.Park();
                Console.WriteLine(  $"{vehicle.Color}");
            }

            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany+>DONE

            //Create 3 classes called Car , Truck , & SUV=> DONE

            //In your IVehicle

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */


            //In ICompany

            /*Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //In each of your car, truck, and suv classes

            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values
        }
    }
}
