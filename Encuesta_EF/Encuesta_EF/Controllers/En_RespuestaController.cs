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
    public class En_RespuestaController : ApiController
    {
        private Encuesta_EFContext db = new Encuesta_EFContext();

        // GET: api/En_Respuesta
        public IQueryable<En_Respuesta> GetEn_Respuesta()
        {
            return db.En_Respuesta;
        }

        // GET: api/En_Respuesta/5
        [ResponseType(typeof(En_Respuesta))]
        public async Task<IHttpActionResult> GetEn_Respuesta(int id)
        {
            En_Respuesta en_Respuesta = await db.En_Respuesta.FindAsync(id);
            if (en_Respuesta == null)
            {
                return NotFound();
            }

            return Ok(en_Respuesta);
        }

        // PUT: api/En_Respuesta/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutEn_Respuesta(int id, En_Respuesta en_Respuesta)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != en_Respuesta.Cod_Respuesta)
            {
                return BadRequest();
            }

            db.Entry(en_Respuesta).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!En_RespuestaExists(id))
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

        // POST: api/En_Respuesta
        [ResponseType(typeof(En_Respuesta))]
        public async Task<IHttpActionResult> PostEn_Respuesta(En_Respuesta en_Respuesta)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.En_Respuesta.Add(en_Respuesta);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = en_Respuesta.Cod_Respuesta }, en_Respuesta);
        }

        // DELETE: api/En_Respuesta/5
        [ResponseType(typeof(En_Respuesta))]
        public async Task<IHttpActionResult> DeleteEn_Respuesta(int id)
        {
            En_Respuesta en_Respuesta = await db.En_Respuesta.FindAsync(id);
            if (en_Respuesta == null)
            {
                return NotFound();
            }

            db.En_Respuesta.Remove(en_Respuesta);
            await db.SaveChangesAsync();

            return Ok(en_Respuesta);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool En_RespuestaExists(int id)
        {
            return db.En_Respuesta.Count(e => e.Cod_Respuesta == id) > 0;
        }
    }
}