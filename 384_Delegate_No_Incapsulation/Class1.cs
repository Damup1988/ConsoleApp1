using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _384_Delegate_No_Incapsulation
{
    class Car
    {
        public delegate void CarEngineHandler(string MsgForCaller);
        public CarEngineHandler ListOfHandlers;

        public void Accelerate(int delta)
        {
            if (ListOfHandlers != null)
                ListOfHandlers("Sorry, the car is dead...");
        }
    }
}
