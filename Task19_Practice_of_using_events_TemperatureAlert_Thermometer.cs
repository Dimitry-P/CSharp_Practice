using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice
{
    internal class Thermometer
    {
        public event EventHandler<ThresholdExeededEventArgs> ThresholdExeeded;

        public int Threshold { get; }

        public Thermometer(int threshold)
        {
            Threshold = threshold;
        }

        public void AddTemperature(int temp)
        {
            Console.WriteLine($"Получена температура {temp}");
            if (temp > Threshold)
            {
                OnThresholdExeededTemp(temp);
            }
        }

        protected void OnThresholdExeededTemp(int temp)
        {
            ThresholdExeeded?.Invoke(this, new ThresholdExeededEventArgs(temp));
        }
    }
}
