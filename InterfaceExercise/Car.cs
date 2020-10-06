using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class Car : IVehicle, ICompany
    {
        public Car()
        {

        }
            //From IVehicle
            public string Make { get; set; } = "GMC";
            public string Model { get; set; } = "Yukon";
            public int SeatCount { get; set; } = 4;
            public double EngineSize { get; set; } = 5.3;

            public bool HasChangedGears { get; set; } 

            //From ICompany
            public string CompanyName { get; set; }
            public string Logo { get; set; }

            public void Drive()
            {
                Console.WriteLine($"{GetType().Name} now is driving forward.");
            }
            public void Reverse()
            {
                if (HasChangedGears == true)
                {
                Console.WriteLine($"{GetType().Name} now reversing.");
                HasChangedGears = false;
                }
                else
                {
                Console.WriteLine("Can't reverse until we change gears");
                }
            }
            public void Park()
            {
                if (HasChangedGears == true)
                {
                Console.WriteLine($"{GetType().Name} is now in park.");
                HasChangedGears = false;
                }
                else
                {
                Console.WriteLine("Can't park until we change gears.");
                }
            }
            public void ChangeGears(bool isChanged)
            {
                HasChangedGears = isChanged;
            }

         }
    }

