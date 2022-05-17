using System;

namespace PS_31_Yovana_Ilieva_Upr2_working
{
    public class User
    {
        public string username { get; set; }
        public string password { get; set; }
        public string facultyNumber { get; set; }
        public UserRoles userRole { get; set; }
        public DateTime? Created { get; set; }
        public DateTime? activeUntil { get; set; }
        public int userId { get; set; }

        public User()
        {

        }

        public User(string username, string password, string facultyNumber, UserRoles userRole, DateTime created, DateTime activeUntil)
        {
            this.username = username;
            this.password = password;
            this.facultyNumber = facultyNumber;
            this.userRole = userRole;
            this.Created = created;
            this.activeUntil = activeUntil;
        }

        public override string ToString()
        {
            return username + " " + facultyNumber + " " + userRole + " " + Created;
        }
    }
}
