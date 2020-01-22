using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _379_CarDelegateMethodGroupConversion
{
    public class Car
    {
        public delegate void CarEngineHandler(string MsgForCaller);

        private CarEngineHandler ListOfHandlers;

        public int CurrentSpeed { get; set; }
        public int MaxSpeed { get; set; } = 100;
        public string PetName { get; set; }
        private bool CarIsDead;

        public Car()
        {

        }

        public Car(int CurrentSpeed, int MaxSpeed, string PetName)
        {
            this.CurrentSpeed = CurrentSpeed;
            this.MaxSpeed = MaxSpeed;
            this.PetName = PetName;
        }

        public void RegisterWithCarEngine(CarEngineHandler methodToCall)
        {
            ListOfHandlers += methodToCall;
        }

        public void UnRegisterWithCarEngine(CarEngineHandler methodToRemove)
        {
            ListOfHandlers -= methodToRemove;
        }

        public void Accelerate(int delta)
        {
            if (CarIsDead)
            {
                if (ListOfHandlers != null)
                    ListOfHandlers("Sorry, this car is dead...");
            }
            else
            {
                CurrentSpeed += delta;

                if (10 == (MaxSpeed - CurrentSpeed) && ListOfHandlers != null)
                {
                    ListOfHandlers("Careful! Gonna blow!");
                }
                if (CurrentSpeed >= MaxSpeed)
                    CarIsDead = true;
                else
                {
                    Console.WriteLine("Current speed = {0}", CurrentSpeed);
                }
            }
        }
    }
}
