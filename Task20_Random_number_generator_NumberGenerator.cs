using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice
{
    internal class NumberGenerator
    {
        public event EventHandler<EventNumberEventArgs> EventNumberGenerated;

        public void Generate(int max)
        {
            for (int i = 0; i < max; i++)
            {
                if (i % 2 == 0)
                {
                    EventNumberGenerated?.Invoke(this, new EventNumberEventArgs(i));
                }
            }
        }
    }
}
