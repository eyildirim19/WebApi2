using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi2.Models;

namespace WebApi2.Controllers
{
    public class RotaController : ApiController
    {
        // bütün kullanıcılar...
        public IHttpActionResult GetList()
        {
            ApiDbContext db = new ApiDbContext();
            return Ok(db.Users.ToList());
        }

        public IHttpActionResult GetUserById(int id)
        {
            ApiDbContext db = new ApiDbContext();
            return Ok(db.Users.Find(id));
        }

        public IHttpActionResult GetBenimMetot()
        {
            return Ok("bende sizler gibi Get bir metodum....");
        }
    }
}