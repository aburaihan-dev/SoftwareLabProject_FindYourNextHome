using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HomeRentalBD.Models
{
    public class RentalAds
    {
        public int Id { get; set; }
        public string Banner { get; set; }
        public string City { get; set; }
        public string Area { get; set; }
        public string Category { get; set; }
        public string FloorType { get; set; }
        public bool LivingRoom { get; set; }
        public bool DiningRoom { get; set; }
        public bool DrawingRoom { get; set; }
        public double Size { get; set; }
        public double Price { get; set; }
        public double ServiceCharge { get; set; }
        public double SecurityDeposit { get; set; }
        public int LeaseTerm { get; set; }
        public int BedRoom { get; set; }
        public int AttachedBath { get; set; }
        public int CommonBath { get; set; }
        public int StaffBath { get; set; }
        public int Balcony { get; set; }
        public int FloorLevel { get; set; }
        public int Kitchen { get; set; }
        public int ServentRoom { get; set; }
        public double MapLng { get; set; }
        public double MapLat { get; set; }

    }
}