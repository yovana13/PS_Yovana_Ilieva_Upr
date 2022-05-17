using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace PS_31_Yovana_Ilieva_Upr2_working
{
    public class UserContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public UserContext() : base(Properties.Settings.Default.DbConnect)
        {

        }
    }
}
