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
    [RoutePrefix("User")]
    public class UserController : ApiController
    {
        [HttpGet]
        [Route("GetAll")]
        public HttpResponseMessage GetAll() {
            try
            {
                    var data = UserService.GetAll();
                    return Request.CreateResponse(HttpStatusCode.OK, data);
               
                
            }
            catch (Exception ex) {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex);
            }
        }
        [HttpPost]
        [Route("Create")]
        public HttpResponseMessage Create(UserDTO c) {
            try
            {
                if (ModelState.IsValid)
                {
                    var data = UserService.Create(c);
                    return Request.CreateResponse(HttpStatusCode.OK, data);

                }
                else {
                    return Request.CreateResponse(HttpStatusCode.InternalServerError, ModelState);
                }
            }
            catch (Exception ex) {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex);
            }
        }
        [HttpPost]
        [Route("Update")]
        public HttpResponseMessage Update(UserDTO c) {
            try
            {
                if (ModelState.IsValid)
                {
                    var data = UserService.Update(c);
                    return Request.CreateResponse(HttpStatusCode.OK, data);

                }
                else {
                    return Request.CreateResponse(HttpStatusCode.InternalServerError, ModelState);
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
                var data = UserService.Delete(id);
                if (data == true)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, new { Msg = "User Deleted Successfully" });
                }
                else {
                    return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Msg = "Error occur to delete user" });
                }
            }
            catch (Exception ex) { 
                return Request.CreateResponse(HttpStatusCode.InternalServerError,ex);
            }
        }
        [HttpGet]
        [Route("{id}")]
        public HttpResponseMessage Get(int id) {
            try
            {
                var data = UserService.Get(id);
                if (data != null)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, data);
                }
                else {
                    return Request.CreateResponse(HttpStatusCode.OK, new { Msg = "No user found" });
                }
                
            }
            catch (Exception ex) {
                return Request.CreateResponse(HttpStatusCode.InternalServerError,ex);
            }
        }
    }
}
