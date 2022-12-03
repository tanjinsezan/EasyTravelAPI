using DAL.EF;
using DAL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.REPO
{
    public class CusLoginRepo : IRepo<CusLogin, int>
    {
        Easy_TravelEntities db;
        public CusLoginRepo(Easy_TravelEntities db)
        {
            this.db = db;
        }
        public bool Create(HotelBooking obj)
        {
            db.CusLogins.Add(obj);
            var res = db.SaveChanges();
            return res > 0;
        }

        public bool Delete(int id)
        {
            db.CusLogins.Remove(db.CusLogins.FirstOrDefault(e => e.TouristId == id));
            var res = db.SaveChanges();
            return res == 0;
        }

        public List<CusLogin> Get()
        {
            return db.CusLogins.ToList();
        }

        public CusLogin Get(int id)
        {
            return db.CusLogins.Find(id);
        }

        public bool Update(CusLogin obj)
        {
            var data = db.CusLogin.FirstOrDefault(e => e.TouristID == obj.TouristId);
            data.Name = obj.Name;
            data.Password = obj.Password;
            data.Address = obj.Address;
            data.Phone = obj.Phone;
            data.Email = obj.Email;
            db.SaveChanges();
            return true;
        }
    }
}
