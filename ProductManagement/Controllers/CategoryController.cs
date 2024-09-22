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
                if (ModelState.IsValid)
                {
                    var data = CategoryService.Create(c);
                    return Request.CreateResponse(HttpStatusCode.OK, data);
                }
                else {
                    return Request.CreateResponse(HttpStatusCode.OK, new {Msg="Validation Error occour" });
                }

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
                if (data != null)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, data);
                }
                else {
                    return Request.CreateResponse(HttpStatusCode.OK, new { Msg="No Category found"});
                }
                
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
                if (data != null)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, data);
                }
                else {
                    return Request.CreateResponse(HttpStatusCode.OK, new { Msg = "No data found" });
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
                var data= CategoryService.Delete(id);
                if (data == true)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, new { Msg = "Delete Operation done" });
                }
                else {
                    return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Msg = "Error occour" });
                }
                
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
