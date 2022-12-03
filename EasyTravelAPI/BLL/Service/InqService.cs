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
    public class InqService
    {
        public static List<InqModel> Get()
        {
            var config = new MapperConfiguration(c =>

                c.CreateMap<Inq, InqModel>());

            var mapper = new Mapper(config);
            var data = mapper.Map<List<InqModel>>(DataAccessLayer.GetInqDataAccess().Get());
            return data;
        }
        public static void Create(InqModel r)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<InqModel, Inq>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<Inq>(r);
            DataAccessLayer.GetInqDataAccess().Create(data);
        }
        public static InqModel GetOnly(int id)
        {
            var Data = DataAccessLayer.GetInqDataAccess().Get(id);
            var d = new InqModel() { Id = Data.Id, Name = Data.Name, Question = Data.Question, Answer = Data.Answer, };
            return d;

        }
        public static void Update(InqModel r)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<InqModel, Inq>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<Inq>(r);
            DataAccessLayer.GetInqDataAccess().Update(data);
        }
        public static void Delete(int id)
        {
            DataAccessLayer.GetInqDataAccess().Delete(id);
        }
    }
}
