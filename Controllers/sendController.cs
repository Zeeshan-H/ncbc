using nbcc.Models;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;

namespace nbcc.Controllers
{
    public class sendController : ApiController
    {
        [HttpPost]

        public IHttpActionResult Post(EmailClass em) {

            string subject = em.subject;
            string body = em.body;
            string to = em.to;

            MailMessage mm = new MailMessage();

            mm.From = new MailAddress("zeeshanh184@gmail.com");

            mm.To.Add(to);
            mm.Subject = subject;

            mm.Body = body;
            mm.IsBodyHtml = false;

            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.UseDefaultCredentials = false;
            smtp.Port = 25;

            smtp.EnableSsl = true;

            smtp.Credentials = new System.Net.NetworkCredential("zeeshanh184@gmail.com", "Mypass123");
            smtp.Send(mm);

            return Ok();
        }
       
    }
}
