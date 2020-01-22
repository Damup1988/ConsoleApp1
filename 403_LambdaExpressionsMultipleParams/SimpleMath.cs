using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _403_LambdaExpressionsMultipleParams
{
    class SimpleMath
    {
        public delegate void MathMessage(string Msg, int result);
        private MathMessage mmDelegate;

        public void SetMathHandler(MathMessage mmDelegate)
        {
            this.mmDelegate = mmDelegate;
        }

        public void Add(int x, int y)
        {
            mmDelegate?.Invoke("Adding has completed", x + y);
        }
    }
}