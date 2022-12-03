using DAL.EF;
using DAL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.REPO
{
    public class VehicleBookingRepo : IRepo<VehicleBooking, int>
    {
        Easy_TravelEntities db;
        public VehicleBookingRepo(Easy_TravelEntities db)
        {
            this.db = db;
        }
        public bool Create(VehicleBooking obj)
        {
            db.VehicleBookings.Add(obj);
            var res = db.SaveChanges();
            return res > 0;
        }

        public bool Delete(int id)
        {
            db.VehicleBookings.Remove(db.VehicleBookings.FirstOrDefault(e => e.TouristID == id));
            var res = db.SaveChanges();
            return res == 0;
        }

        public List<VehicleBooking> Get()
        {
            return db.VehicleBookings.ToList();
        }

        public VehicleBooking Get(int id)
        {
            return db.VehicleBookings.Find(id);
        }

        public bool Update(VehicleBooking obj)
        {
            var data = db.VehicleBookings.FirstOrDefault(e => e.TouristID == obj.TouristID); 
            data.TouristName = obj.TouristName;
            data.TouristPhone = obj.TouristPhone;
            data.VehicleID = obj.VehicleID;
            data.VehicleName = obj.VehicleName;
            data.Type = obj.Type;
            data.StartingPoint = obj.StartingPoint;
            data.FinishingPoint = obj.FinishingPoint;
            data.Price = obj.Price;
            data.Offer = obj.Offer;
            data.ExtraInfo = obj.ExtraInfo;
            data.No_of_Seat = obj.No_of_Seat;
            db.SaveChanges();
            return true; 
        }
    }
}
