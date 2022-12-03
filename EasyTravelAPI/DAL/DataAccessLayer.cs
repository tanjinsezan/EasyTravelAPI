using DAL.EF;
using DAL.Interface;
using DAL.REPO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccessLayer
    {
        static Easy_TravelEntities db = new Easy_TravelEntities();

        public static IRepo<HotelBooking, int> GetHotelBookingDataAccess()
        {
            return new HotelBookingRepo(db);
        }
        public static IRepo<VehicleBooking, int> GetVehicleBookingDataAccess()
        {
            return new VehicleBookingRepo(db);
        }
        public static IRepo<Inq, int> GetInqDataAccess()
        {
            return new InqRepo(db);
        }
        public static IRepo<Report, int> GetReportDataAccess()
        {
            return new ReportRepo(db);
        }
        public static IRepo<CusLogin, int> GetCusLoginDataAccess()
        {
            return new CusloginRepo(db);
        }
    }
}

