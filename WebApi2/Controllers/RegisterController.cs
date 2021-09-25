using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi2.Models;

namespace WebApi2.Controllers
{
    public class RegisterController : ApiController
    {
        public IHttpActionResult Post(Kullanici model)
        {
            ApiDbContext dbContext = new ApiDbContext();
            if (!ModelState.IsValid) // gönderilen modelin doğrulaması yapıldı mı???
            {
                return BadRequest(ModelState); // BadRequest ile ModelStatei dön...
            }

            try
            {
                //email adresi daha önce kaydedildimi?
                //var user = dbContext.Users.FirstOrDefault(c => c.Email == model.Email);
                var user = dbContext.Users.SingleOrDefault(c => c.Email == model.Email);

                if (user == null) // email ile kullanıcıyok...
                {
                    dbContext.Users.Add(model); // kullaniciyi veritabanına ekle
                    dbContext.SaveChanges();
                    return Ok("Kaydetme işlemi başarılıdır");
                }
                else
                {
                    return BadRequest("Bu email adresi daha önce kullanılmıştır");
                }
            }
            catch
            {
                return BadRequest("Kaydetme işlemi başarısız. Lütfen zorunlu alanları kontrol ediniz");
            }
        }
    }
}