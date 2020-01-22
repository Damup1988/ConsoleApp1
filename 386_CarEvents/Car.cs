using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _386_CarEvents
{
    class Car
    {
        //public delegate void CarEngineHandler(object sender, CarEventArgs e);        

        //public event CarEngineHandler Event_Exploded;
        //public event CarEngineHandler Event_AboutToBlow;

        public event EventHandler<CarEventArgs> Event_Exploded;
        public event EventHandler<CarEventArgs> Event_AboutToBlow;

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

        public void Accelerate(int delta)
        {
            if (CarIsDead)
            {
                //if (Event_Exploded != null)
                //    Event_Exploded("Sorry, this car is dead...");
                Event_Exploded?.Invoke(this, new CarEventArgs("Sorry, this car is dead..."));
            }
            else
            {
                CurrentSpeed += delta;

                if (10 == (MaxSpeed - CurrentSpeed)/* && Event_AboutToBlow != null*/)
                {
                    //Event_AboutToBlow("Careful! Gonna blow!");
                    Event_AboutToBlow?.Invoke(this, new CarEventArgs("Careful! Gonna blow!"));
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