using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice
{
    internal class EventNumberEventArgs
    {
        public int Number { get; }

        public EventNumberEventArgs(int number)
        {
            Number = number;
        }
    }
}
