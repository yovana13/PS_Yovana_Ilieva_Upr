using System;
using System.Collections.Generic;

namespace PS_31_Yovana_Ilieva_Upr2_working
{
    public static class UserData
    {
        private static List<User> testUser;

        public static List<User> TestUser
        {
            get
            {
                ResetTestUserData();
                return testUser;
            }
            set { }
        }

        private static void ResetTestUserData()
        {
            if (testUser != null) return;

            testUser = new List<User>();
            testUser.Add(new User("Anaana", "test1234", "", UserRoles.ADMIN, new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day), DateTime.MaxValue));
            testUser.Add(new User("Emaema", "test1234", "", UserRoles.ADMIN, new DateTime(2022, 2, 2), DateTime.MaxValue));
            testUser.Add(new User("Evaeva", "test1234", "987654321", UserRoles.STUDENT, new DateTime(2022, 3, 3), DateTime.MaxValue));
        }

        public static void GetUsers()
        {
            foreach (var user in testUser)
            {
                Console.WriteLine(user.ToString());
            }
        }

        public static User IsUserPassCorrect(string username, string password)
        {
            //foreach (var user in TestUser)
            //{
            //    if (user.username == username && user.password == password)
            //        return user;
            //}

            User correctUser = (from user in TestUser where user.username == username && user.password == password select user).First();

            return correctUser;
        }

        public static void SetUserActiveTo(string username, DateTime activity)
        {
            foreach (var user in TestUser)
            {
                if (user.username == username)
                {
                    user.Created = activity;
                    Logger.LogActivity("Activity changed for " + username);
                }
            }
        }

        public static void AssignUserRole(string username, UserRoles newRole)
        {
            foreach (var user in TestUser)
            {
                if (user.username == username)
                {
                    UserContext context = new UserContext();
                    User usr = (from u in UserData.TestUser where u.username.Equals(username) select u).First();
                    usr.userRole = newRole;
                    context.SaveChanges();
                    Logger.LogActivity("Role changed for " + username);
                }
            }
        }
    }
}
