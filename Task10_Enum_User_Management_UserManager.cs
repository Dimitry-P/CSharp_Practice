using System.Collections.Generic;
using System.Xml.Linq;

namespace CSharp_Practice
{
    public class UserManager()
    {
        //UserManager.findUserByName(String name) – поиск пользователя по имени.
        //UserManager.countInactiveUsers() – подсчёт пользователей со статусом INACTIVE.

        public static User FindUserByName(List<User> users, string insertedName, out bool found)
        {
            foreach (var user in users)
            {
                if (user.Name.Equals(insertedName, StringComparison.OrdinalIgnoreCase))
                {
                    found = true;
                    return user;
                }
            }
            found = false;
            return null;
        }
        public static int countInactiveUsers(List<User> users)
        {
            int totalCountOfInactiveUsers = 0;
            foreach (var user in users)
            {
                if (user.Status == UserStatus.INACTIVE)
                {
                    totalCountOfInactiveUsers++;
                }
            }
            return totalCountOfInactiveUsers;
        }
    }
}
