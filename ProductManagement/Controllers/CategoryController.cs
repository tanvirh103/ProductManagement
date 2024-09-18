using BLL.DTOs;
using BLL.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProductManagement.Controllers
{
    [RoutePrefix("Category")]
    public class CategoryController : ApiController
    {
        [HttpPost]
        [Route("Create")]
        public HttpResponseMessage Create(CategoryDTO c) {
            try
            {
                var data = CategoryService.Create(c);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex) {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex);
            }
        }

        [HttpGet]
        [Route("GetAll")]
        public HttpResponseMessage GetAll() {
            try
            {
                var data = CategoryService.GetAll();
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex);
            }
        }
        [HttpGet]
        [Route("{id}")]
        public HttpResponseMessage Get(int id) {
            try
            {
                var data = CategoryService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex) {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex);
            }
        }
        [HttpPost]
        [Route("Delete/id")]
        public HttpResponseMessage Delete(int id) {
            try
            {
                var data= CategoryService.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK,data);
            }
            catch (Exception ex) {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex);
            }
        }

        [HttpPost]
        [Route("Update")]
        public HttpResponseMessage Update(CategoryDTO c) {
            try
            {
                var data = CategoryService.Update(c);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex) {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex);
            }
        }

    }
}
