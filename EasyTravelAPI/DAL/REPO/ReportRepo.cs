using DAL.EF;
using DAL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.REPO
{
    public class ReportRepo : IRepo<Report, int>
    {
        Easy_TravelEntities db;
        public ReportRepo(Easy_TravelEntities db)
        {
            this.db = db;
        }
        public bool Create(Report obj)
        {
            db.Reports.Add(obj);
            var res = db.SaveChanges();
            return res > 0;
        }

        public bool Delete(int id)
        {
            db.Reports.Remove(db.Reports.FirstOrDefault(e => e.Id == id));
            var res = db.SaveChanges();
            return res == 0;
        }

        public List<Report> Get()
        {
            return db.Reports.ToList();
        }

        public Report Get(int id)
        {
            return db.Reports.Find(id);
        }

        public bool Update(Report obj)
        {
            var data = db.Reports.FirstOrDefault(e => e.Id == obj.Id);
            data.Name = obj.Name;
            data.Topic = obj.Topic;
            data.Details = obj.Details;
            db.SaveChanges();
            return true;
        }
    }
}
