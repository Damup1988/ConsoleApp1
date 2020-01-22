using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _386_CarEvents
{
    public class CarEventArgs : EventArgs
    {
        public readonly string Msg;
        public CarEventArgs(string Msg)
        {
            this.Msg = Msg;
        }
    }
}
