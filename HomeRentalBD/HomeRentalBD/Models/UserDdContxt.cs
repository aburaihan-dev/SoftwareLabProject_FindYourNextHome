using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace HomeRentalBD.Models
{
    public class UserDdContxt : DbContext
    {
        public DbSet<User> Users { get; set; }
    }
}