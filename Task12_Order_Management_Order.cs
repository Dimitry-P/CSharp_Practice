using System;

namespace CSharp_Practice
{
    public class Order
    {
        public int ID
        {
            get;
            set;
        }

        public StatusCheck Status
        {
            get;
            set;
        }

        public string Description
        {
            get;
            set;
        }

        public Order(int id, StatusCheck status, string description)
        {
            ID = id;
            Status = status;
            Description = description;
        }
    }
}
