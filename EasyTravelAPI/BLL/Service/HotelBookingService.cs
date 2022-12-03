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
        public class HotelBookingService
        {
            public static List<HotelBookingModel> Get()
            {
                var config = new MapperConfiguration(c =>

                    c.CreateMap<HotelBooking, HotelBookingModel>());

                var mapper = new Mapper(config);
                var data = mapper.Map<List<HotelBookingModel>>(DataAccessLayer.GetHotelBookingDataAccess().Get());
                return data;
            }
            public static void Create(HotelBookingModel r)
            {
                var config = new MapperConfiguration(c =>
                {
                    c.CreateMap<HotelBookingModel, HotelBooking>();
                });
                var mapper = new Mapper(config);
                var data = mapper.Map<HotelBooking>(r);
                DataAccessLayer.GetHotelBookingDataAccess().Create(data);
            }
            public static HotelBookingModel GetOnly(int id)
            {
                var Data = DataAccessLayer.GetHotelBookingDataAccess().Get(id);
                var d = new HotelBookingModel() { TouristID = Data.TouristID, TouristName = Data.TouristName, TouristPhone = Data.TouristPhone, HotelName = Data.HotelName, Place = Data.Place, Type = Data.Type, Price = Data.Price, Offer = Data.Offer, ExtraInfo = Data.ExtraInfo, No_of_Days = Data.No_of_Days, };
                return d;

            }
            public static void Update(HotelBookingModel r)
            {
                var config = new MapperConfiguration(c =>
                {
                    c.CreateMap<HotelBookingModel, HotelBooking>();
                });
                var mapper = new Mapper(config);
                var data = mapper.Map<HotelBooking>(r);
                DataAccessLayer.GetHotelBookingDataAccess().Update(data);
            }
            public static void Delete(int id)
            {
                DataAccessLayer.GetHotelBookingDataAccess().Delete(id);
            }
        }
}

