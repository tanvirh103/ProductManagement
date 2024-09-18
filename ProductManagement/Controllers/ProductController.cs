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
    [RoutePrefix("Product")]
    public class ProductController : ApiController
    {
        [HttpPost]
        [Route("Create")]
        public HttpResponseMessage Create(ProductDTO p) {
            try
            {
                var data = ProductService.Create(p);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex) {
            return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex);
            }
        }
        [HttpPost]
        [Route("Update")]
        public HttpResponseMessage Update(ProductDTO p) {
            try
            {
                var data = ProductService.Update(p);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex) {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex);
            }
        }
        [HttpGet]
        [Route("{id}")]
        public HttpResponseMessage Get(int id) {
            try
            {
                var data = ProductService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex) {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex);
            }
        }
        [HttpGet]
        [Route("Delete/{id}")]
        public HttpResponseMessage Delete(int id) {
            try
            {
                var data = ProductService.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK, data)
;
            }
            catch (Exception ex) {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex);
            }
        }

        [HttpGet]
        [Route("Get")]
        public HttpResponseMessage Get() {
            try
            {
                var data = ProductService.GetAll();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex) {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex);
            }
        }
    }
}
