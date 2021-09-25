using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi2.Models;

namespace WebApi2.Controllers
{
    public class AccountController : ApiController
    {
        public IHttpActionResult Post(Kullanici model)
        {
            // instance 2 scope arası kullan ve imha et (bellekten temizle)..sadece Idisposble interfacesindnen türeyen sınıflarda kullanılabilir...
            using (ApiDbContext db = new ApiDbContext())
            {
                // geriye aranan satırı veya objenin default değerini döner. obje sınıf olduğu default değeri nulldır..
                Kullanici kullanici = db.Users.SingleOrDefault(c => c.Email == model.Email && c.Sifre == model.Sifre);

                if (kullanici != null) // kullanıcı vardır...
                {
                    return Ok(kullanici); // geriye kulanıcı bilgilerini dön...
                }
                else // kullanıcı yoktur...
                {
                    return BadRequest("Kullanıcı Bulunamadı");
                }
            } //
        }
    }
}
