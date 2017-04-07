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
using SilcoSedonaInspectionApi;

namespace SilcoSedonaInspectionApi.Controllers
{
    public class SV_InspectionController : ApiController
    {
        private SilcoSedona db = new SilcoSedona();

        // GET: api/SV_Inspection
        public IQueryable<SV_Inspection> GetSV_Inspection()
        {
            return db.SV_Inspection;
        }

        // GET: api/SV_Inspection/5
        [ResponseType(typeof(SV_Inspection))]
        public IHttpActionResult GetSV_Inspection(int id)
        {
            // SV_Inspection sV_Inspection = db.SV_Inspection.Find(id);
            SV_Inspection sV_Inspection = db.SV_Inspection.SingleOrDefault(m => m.Inspection_Id == id);
            if (sV_Inspection == null)
            {
                return NotFound();
            }
        //    SV_Inspection a = p from SV_inspection

            return Ok(sV_Inspection);
        }
       

        // PUT: api/SV_Inspection/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutSV_Inspection(int id, SV_Inspection sV_Inspection)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != sV_Inspection.Inspection_Id)
            {
                return BadRequest();
            }

            db.Entry(sV_Inspection).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SV_InspectionExists(id))
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

        // POST: api/SV_Inspection
        [ResponseType(typeof(SV_Inspection))]
        public IHttpActionResult PostSV_Inspection(SV_Inspection sV_Inspection)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.SV_Inspection.Add(sV_Inspection);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (SV_InspectionExists(sV_Inspection.Inspection_Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = sV_Inspection.Inspection_Id }, sV_Inspection);
        }

        // DELETE: api/SV_Inspection/5
        [ResponseType(typeof(SV_Inspection))]
        public IHttpActionResult DeleteSV_Inspection(int id)
        {
            SV_Inspection sV_Inspection = db.SV_Inspection.Find(id);
            if (sV_Inspection == null)
            {
                return NotFound();
            }

            db.SV_Inspection.Remove(sV_Inspection);
            db.SaveChanges();

            return Ok(sV_Inspection);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool SV_InspectionExists(int id)
        {
            return db.SV_Inspection.Count(e => e.Inspection_Id == id) > 0;
        }
    }
}