using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using SilcoSedonaCustomApi;


namespace SilcoSedonaCustomApi.Controllers
{
    public class AR_Userdef_8Controller : ApiController
    {
        private SilcoSedona db = new SilcoSedona();

        // GET: api/AR_Userdef_8
        public IQueryable<AR_Userdef_8> GetAR_Userdef_8()
        {
            return db.AR_Userdef_8;
        }

        // GET: api/AR_Userdef_8/5
        [ResponseType(typeof(AR_Userdef_8))]
        public IHttpActionResult GetAR_Userdef_8(int id)
        {
            AR_Userdef_8 aR_Userdef_8 = db.AR_Userdef_8.Find(id);
            if (aR_Userdef_8 == null)
            {
                return NotFound();
            }

            return Ok(aR_Userdef_8);
        }

        // PUT: api/AR_Userdef_8/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutAR_Userdef_8(int id, AR_Userdef_8 aR_Userdef_8)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != aR_Userdef_8.Userdef_8_Id)
            {
                return BadRequest();
            }

            db.Entry(aR_Userdef_8).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AR_Userdef_8Exists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/AR_Userdef_8
        [ResponseType(typeof(AR_Userdef_8))]
        public IHttpActionResult PostAR_Userdef_8(AR_Userdef_8 aR_Userdef_8)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.AR_Userdef_8.Add(aR_Userdef_8);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = aR_Userdef_8.Userdef_8_Id }, aR_Userdef_8);
        }

        // DELETE: api/AR_Userdef_8/5
        [ResponseType(typeof(AR_Userdef_8))]
        public IHttpActionResult DeleteAR_Userdef_8(int id)
        {
            AR_Userdef_8 aR_Userdef_8 = db.AR_Userdef_8.Find(id);
            if (aR_Userdef_8 == null)
            {
                return NotFound();
            }

            db.AR_Userdef_8.Remove(aR_Userdef_8);
            db.SaveChanges();

            return Ok(aR_Userdef_8);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool AR_Userdef_8Exists(int id)
        {
            return db.AR_Userdef_8.Count(e => e.Userdef_8_Id == id) > 0;
        }
    }
}