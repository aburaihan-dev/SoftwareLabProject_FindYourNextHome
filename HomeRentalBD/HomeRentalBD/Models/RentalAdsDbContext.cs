using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace HomeRentalBD.Models
{
    public class RentalAdsDbContext : DbContext
    {
        public DbSet<RentalAds> RantalSet { get; set; }
    }
}