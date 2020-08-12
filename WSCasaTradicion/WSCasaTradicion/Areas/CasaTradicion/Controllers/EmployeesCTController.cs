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
using WSCasaTradicion.Models;

namespace WSCasaTradicion.Areas.CasaTradicion.Controllers
{
    [Authorize]
    [RoutePrefix("api/CasaTradicion/Employees")]
    public class EmployeesCTController : ApiController
    {
        private SBO_CasaTradicion_ProdEntities db = new SBO_CasaTradicion_ProdEntities();

        // GET: api/EmployeesCT
        [HttpGet]
        public IQueryable<OHEM> GetOHEM()
        {
            return db.OHEM;
        }

        // GET: api/EmployeesCT/5
        [HttpGet]
        [ResponseType(typeof(OHEM))]
        public IHttpActionResult GetOHEM(int id)
        {
            OHEM oHEM = db.OHEM.Find(id);
            if (oHEM == null)
            {
                return NotFound();
            }

            return Ok(oHEM);
        }

        // PUT: api/EmployeesCT/5
        //[ResponseType(typeof(void))]
        //public IHttpActionResult PutOHEM(int id, OHEM oHEM)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    if (id != oHEM.empID)
        //    {
        //        return BadRequest();
        //    }

        //    db.Entry(oHEM).State = EntityState.Modified;

        //    try
        //    {
        //        db.SaveChanges();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!OHEMExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return StatusCode(HttpStatusCode.NoContent);
        //}

        // POST: api/EmployeesCT
        //[ResponseType(typeof(OHEM))]
        //public IHttpActionResult PostOHEM(OHEM oHEM)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    db.OHEM.Add(oHEM);

        //    try
        //    {
        //        db.SaveChanges();
        //    }
        //    catch (DbUpdateException)
        //    {
        //        if (OHEMExists(oHEM.empID))
        //        {
        //            return Conflict();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return CreatedAtRoute("DefaultApi", new { id = oHEM.empID }, oHEM);
        //}

        //// DELETE: api/EmployeesCT/5
        //[ResponseType(typeof(OHEM))]
        //public IHttpActionResult DeleteOHEM(int id)
        //{
        //    OHEM oHEM = db.OHEM.Find(id);
        //    if (oHEM == null)
        //    {
        //        return NotFound();
        //    }

        //    db.OHEM.Remove(oHEM);
        //    db.SaveChanges();

        //    return Ok(oHEM);
        //}

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool OHEMExists(int id)
        {
            return db.OHEM.Count(e => e.empID == id) > 0;
        }
    }
}