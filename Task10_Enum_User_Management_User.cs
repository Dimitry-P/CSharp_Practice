using System;


namespace CSharp_Practice
{
    public class User
    {
        public string Name
        {
            get;
            private set;
        }

        public UserStatus Status
        {
            get;
            private set;
        }

        public User(string userName, UserStatus userStatus)
        {
            Name = userName;
            Status = userStatus;
        }

        public override string ToString()
        {
            return $"User(Name: {Name}, Status: {Status})";
        }
    }
}

//name(String) и status(enum)

