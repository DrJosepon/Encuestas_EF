using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using Encuesta_EF.Models;

namespace Encuesta_EF.Controllers
{
    public class En_EncuestaController : ApiController
    {
        private Encuesta_EFContext db = new Encuesta_EFContext();

        // GET: api/En_Encuesta
        public IQueryable<En_Encuesta> GetEn_Encuesta()
        {
            return db.En_Encuesta;
        }

        // GET: api/En_Encuesta/5
        [ResponseType(typeof(En_Encuesta))]
        public async Task<IHttpActionResult> GetEn_Encuesta(int id)
        {
            En_Encuesta en_Encuesta = await db.En_Encuesta.FindAsync(id);
            if (en_Encuesta == null)
            {
                return NotFound();
            }

            return Ok(en_Encuesta);
        }

        // PUT: api/En_Encuesta/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutEn_Encuesta(int id, En_Encuesta en_Encuesta)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != en_Encuesta.Cod_Encuesta)
            {
                return BadRequest();
            }

            db.Entry(en_Encuesta).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!En_EncuestaExists(id))
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

        // POST: api/En_Encuesta
        [ResponseType(typeof(En_Encuesta))]
        public async Task<IHttpActionResult> PostEn_Encuesta(En_Encuesta en_Encuesta)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.En_Encuesta.Add(en_Encuesta);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = en_Encuesta.Cod_Encuesta }, en_Encuesta);
        }

        // DELETE: api/En_Encuesta/5
        [ResponseType(typeof(En_Encuesta))]
        public async Task<IHttpActionResult> DeleteEn_Encuesta(int id)
        {
            En_Encuesta en_Encuesta = await db.En_Encuesta.FindAsync(id);
            if (en_Encuesta == null)
            {
                return NotFound();
            }

            db.En_Encuesta.Remove(en_Encuesta);
            await db.SaveChangesAsync();

            return Ok(en_Encuesta);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool En_EncuestaExists(int id)
        {
            return db.En_Encuesta.Count(e => e.Cod_Encuesta == id) > 0;
        }
    }
}