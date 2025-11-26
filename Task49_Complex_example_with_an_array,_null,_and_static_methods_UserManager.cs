using System;

namespace CSharp_Practice
{
    public class UserManager()
    {
        public static string FindUserName(List<Users> users, string name)
        {
            foreach (Users user in users)
            {
                if (string.Equals(user.UserName, name, StringComparison.OrdinalIgnoreCase))
                {
                    return $"Найден пользователь: {user.UserName}";
                }
            }
            return "Имя для данного пользователя не было задано";
        }

        public static string NullNameCount(List<Users> users)
        {
            int nullCount = 0;
            foreach (Users user in users)
            {
                if (user.UserName == "") nullCount++;
            }
            return $"Количество пользователей с именем null: " + nullCount;
        }
    }
}
