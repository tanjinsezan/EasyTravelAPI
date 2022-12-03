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
        public class CusLoginController : ApiController
        {
            [Route("api/CusLogin/All")]
            [HttpGet]
            public List<CusLoginModel> GetAll()
            {
                return CusLoginService.Get();
            }
            [Route("api/CusLogin/Create")]
            [HttpPost]
            public HttpResponseMessage Create(CusLoginModel r)
            {
            CusLoginService.Create(r);
                return Request.CreateResponse(HttpStatusCode.OK, "Created");
            }
            [Route("api/CusLogin/{id}")]
            [HttpGet]
            public HttpResponseMessage Get(int id)
            {
                var data = CusLoginService.GetOnly(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            [Route("api/CusLogin/update")]
            [HttpPost]
            public HttpResponseMessage Update(CusLoginModel r)
            {
            CusLoginService.Update(r);
                return Request.CreateResponse(HttpStatusCode.OK, "Updated");

            }
            [Route("api/CusLogin/delete/{id}")]
            [HttpDelete]
            public HttpResponseMessage Delete(int id)
            {
            CusLoginService.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK, "Deleted");
            }
        }
 }
