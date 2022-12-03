using BLL.BO;
using BLL.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EasyTravelAPI.Controllers
{
    public class ReportController : ApiController
    {
        [Route("api/Report/All")]
        [HttpGet]
        public List<ReportModel> GetAll()
        {
            return ReportService.Get();
        }
        [Route("api/Report/Create")]
        [HttpPost]
        public HttpResponseMessage Create(ReportModel r)
        {
            ReportService.Create(r);
            return Request.CreateResponse(HttpStatusCode.OK, "Created");
        }
        [Route("api/Report/{id}")]
        [HttpGet]
        public HttpResponseMessage Get(int id)
        {
            var data = ReportService.GetOnly(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [Route("api/Report/update")]
        [HttpPost]
        public HttpResponseMessage Update(ReportModel r)
        {
            ReportService.Update(r);
            return Request.CreateResponse(HttpStatusCode.OK, "Updated");

        }
        [Route("api/Report/delete/{id}")]
        [HttpDelete]
        public HttpResponseMessage Delete(int id)
        {
            ReportService.Delete(id);
            return Request.CreateResponse(HttpStatusCode.OK, "Deleted");
        }
    }
}
