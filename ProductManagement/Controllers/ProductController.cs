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
                if (ModelState.IsValid)
                {
                    var data = ProductService.Create(p);
                    return Request.CreateResponse(HttpStatusCode.OK, data);
                }
                else {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new {Msg="Product Addition Unsuccessful" });
                }
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
                if (ModelState.IsValid)
                {
                    var data = ProductService.Update(p);
                    return Request.CreateResponse(HttpStatusCode.OK, data);

                }
                else {
                    return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Msg = "Error Occour to update product data" });
                }
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
                if (data != null)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, data);
                }
                else {
                    return Request.CreateResponse(HttpStatusCode.OK, new { Msg="No product found"});
                }
                
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
                if (data == true)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, new { Msg = "Product Deleted Successfully" });
                }
                else {
                    return Request.CreateResponse(HttpStatusCode.OK, new { Msg = "Delete operation unsuccessful" });
                }
                
;
            }
            catch (Exception ex) {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex);
            }
        }

        [HttpGet]
        [Route("GetAll")]
        public HttpResponseMessage Get() {
            try
            {
                var data = ProductService.GetAll();
                if (data != null)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, data);
                }
                else {
                    return Request.CreateResponse(HttpStatusCode.OK, new { Msg = "No User found" });
                }
            }
            catch (Exception ex) {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex);
            }
        }
    }
}
