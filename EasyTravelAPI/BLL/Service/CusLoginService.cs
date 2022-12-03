using AutoMapper;
using BLL.BO;
using DAL;
using DAL.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Service
{
    public class CusLoginService
    {
        public static List<CusLoginModel> Get()
        {
            var config = new MapperConfiguration(c =>

                c.CreateMap<CusLogin, CusLoginModel>());

            var mapper = new Mapper(config);
            var data = mapper.Map<List<CusLoginModel>>(DataAccessLayer.GetCusLoginDataAccess().Get());
            return data;
        }
        public static void Create(CusLoginModel r)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<HotelBookingModel, CusLogin>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<CusLogin>(r);
            DataAccessLayer.GetCusLoginDataAccess().Create(data);
        }
        public static CusLoginModel GetOnly(int id)
        {
            var Data = DataAccessLayer.GetCusLoginDataAccess().Get(id);
            var d = new CusLoginModel() { TouristId = Data.TouristId, Name = Data.Name, Password = Data.Password, Address = Data.Address, Phone = Data.Phone, Email = Data.Email,};
            return d;

        }
        public static void Update(CusLoginModel r)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<CusLoginModel, CusLogin>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<CusLogin>(r);
            DataAccessLayer.GetCusLoginDataAccess().Update(data);
        }
        public static void Delete(int id)
        {
            DataAccessLayer.GetCusLoginDataAccess().Delete(id);
        }
    }
}
