using nbcc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace nbcc.Controllers
{
    public class contactController : ApiController
    {
        [HttpGet]

        public IHttpActionResult Get() {

            ncbcEntities entities = new ncbcEntities();
            return Ok(entities.tb_contact.ToList());
        }

        [HttpPost]

        public IHttpActionResult Post(tb_contact model) {

            int flag = 1;

            ncbcEntities db = new ncbcEntities();

            if (!ModelState.IsValid)
                return BadRequest(ModelState);


            db.tb_contact.Add(model);

            db.SaveChanges();

            return Ok(flag);


        }
    }
}
