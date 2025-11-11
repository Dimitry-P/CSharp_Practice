namespace CSharp_Practice
{
    public class Vehicle
    {
        public string LicensePlate
        {
            get;
            set;
        }

        public string Owner
        {
            get;
            set;
        }

        public Vehicle(string licensePlate, string owner)
        {
            LicensePlate = licensePlate;
            Owner = owner;
        }
    }
}
