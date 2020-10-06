using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var car = new Car();
            var truck = new Truck();
            var suv = new SUV();
            var vehicles = new List<IVehicle> { car, truck, suv }; 

            foreach(var vehicle in vehicles)
            {
                vehicle.Drive();
                vehicle.Reverse();
                vehicle.Park();
                vehicle.ChangeGears(true);

            }

            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany- DONE

            //In your IVehicle

            /* Create 4 members that Car, Truck, & SUV all have in common.- DONE
             * Example: All vehicles have a number of wheels... for now..
             */


            //In ICompany

            /*Create 2 members that are specific to each every company. - DONE
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //Create 3 classes called Car , Truck , & SUV- DONE

            //In each of your car, truck, and suv classes

            /*Create 2 members that are specific to each class- DONE
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //Now, create objects of your 3 classes and give their members values;- DONE
            //Creatively display and organize their values
        }
    }
}
