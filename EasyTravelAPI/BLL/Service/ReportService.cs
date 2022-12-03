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
    public class ReportService
    {
        public static List<ReportModel> Get()
        {
            var config = new MapperConfiguration(c =>

                c.CreateMap<Report, ReportModel>());

            var mapper = new Mapper(config);
            var data = mapper.Map<List<ReportModel>>(DataAccessLayer.GetReportDataAccess().Get());
            return data;
        }
        public static void Create(ReportModel r)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<ReportModel, Report>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<Report>(r);
            DataAccessLayer.GetReportDataAccess().Create(data);
        }
        public static ReportModel GetOnly(int id)
        {
            var Data = DataAccessLayer.GetReportDataAccess().Get(id);
            var d = new ReportModel() { Id = Data.Id, Name = Data.Name, Topic = Data.Topic, Details = Data.Details, };
            return d;

        }
        public static void Update(ReportModel r)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<ReportModel, Report>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<Report>(r);
            DataAccessLayer.GetReportDataAccess().Update(data);
        }
        public static void Delete(int id)
        {
            DataAccessLayer.GetReportDataAccess().Delete(id);
        }
    }
}
