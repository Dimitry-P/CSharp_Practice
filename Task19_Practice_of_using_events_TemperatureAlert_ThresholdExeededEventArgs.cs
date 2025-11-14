using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice
{
    internal class ThresholdExeededEventArgs : EventArgs
    {
        public int Temperature { get; }

        public ThresholdExeededEventArgs(int temperature)
        {
            Temperature = temperature;
        }
    }
}
