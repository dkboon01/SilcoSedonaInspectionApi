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
//dkb - 06/21/2017
// this was added to use the reason code for lost and refused for the technicians 
//It is not currently implemented into the past due processing --- maybe in the future 
//textbox 
//So when they select “ Other or a reason code that has “service Complaint”(table ar_userdef_9)”  , the screen will then show a text box to enter more info to be stored in textbox5(50 chars) in table Ar_customer_system_userdef.

namespace SilcoSedonaInspectionApi.Controllers
{
    public class AR_Userdef_9Controller : ApiController
    {
        private SilcoSedona db = new SilcoSedona();

        // GET: api/AR_Userdef_9
        public IQueryable<AR_Userdef_9> GetAR_Userdef_9()
        {
            return db.AR_Userdef_9;
        }

        // GET: api/AR_Userdef_9/5
        [ResponseType(typeof(AR_Userdef_9))]
        public IHttpActionResult GetAR_Userdef_9(int id)
        {
            AR_Userdef_9 aR_Userdef_9 = db.AR_Userdef_9.Find(id);
            if (aR_Userdef_9 == null)
            {
                return NotFound();
            }

            return Ok(aR_Userdef_9);
        }

        // PUT: api/AR_Userdef_9/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutAR_Userdef_9(int id, AR_Userdef_9 aR_Userdef_9)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != aR_Userdef_9.Userdef_9_Id)
            {
                return BadRequest();
            }

            db.Entry(aR_Userdef_9).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AR_Userdef_9Exists(id))
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

        // POST: api/AR_Userdef_9
        [ResponseType(typeof(AR_Userdef_9))]
        public IHttpActionResult PostAR_Userdef_9(AR_Userdef_9 aR_Userdef_9)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.AR_Userdef_9.Add(aR_Userdef_9);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = aR_Userdef_9.Userdef_9_Id }, aR_Userdef_9);
        }

        // DELETE: api/AR_Userdef_9/5
        [ResponseType(typeof(AR_Userdef_9))]
        public IHttpActionResult DeleteAR_Userdef_9(int id)
        {
            AR_Userdef_9 aR_Userdef_9 = db.AR_Userdef_9.Find(id);
            if (aR_Userdef_9 == null)
            {
                return NotFound();
            }

            db.AR_Userdef_9.Remove(aR_Userdef_9);
            db.SaveChanges();

            return Ok(aR_Userdef_9);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool AR_Userdef_9Exists(int id)
        {
            return db.AR_Userdef_9.Count(e => e.Userdef_9_Id == id) > 0;
        }
    }
}