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
    public class En_PreguntaController : ApiController
    {
        private Encuesta_EFContext db = new Encuesta_EFContext();

        // GET: api/En_Pregunta
        public IQueryable<En_Pregunta> GetEn_Pregunta()
        {
            return db.En_Pregunta;
        }

        // GET: api/En_Pregunta/5
        [ResponseType(typeof(En_Pregunta))]
        public async Task<IHttpActionResult> GetEn_Pregunta(int id)
        {
            En_Pregunta en_Pregunta = await db.En_Pregunta.FindAsync(id);
            if (en_Pregunta == null)
            {
                return NotFound();
            }

            return Ok(en_Pregunta);
        }

        // PUT: api/En_Pregunta/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutEn_Pregunta(int id, En_Pregunta en_Pregunta)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != en_Pregunta.Cod_Pregunta)
            {
                return BadRequest();
            }

            db.Entry(en_Pregunta).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!En_PreguntaExists(id))
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

        // POST: api/En_Pregunta
        [ResponseType(typeof(En_Pregunta))]
        public async Task<IHttpActionResult> PostEn_Pregunta(En_Pregunta en_Pregunta)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.En_Pregunta.Add(en_Pregunta);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = en_Pregunta.Cod_Pregunta }, en_Pregunta);
        }

        // DELETE: api/En_Pregunta/5
        [ResponseType(typeof(En_Pregunta))]
        public async Task<IHttpActionResult> DeleteEn_Pregunta(int id)
        {
            En_Pregunta en_Pregunta = await db.En_Pregunta.FindAsync(id);
            if (en_Pregunta == null)
            {
                return NotFound();
            }

            db.En_Pregunta.Remove(en_Pregunta);
            await db.SaveChangesAsync();

            return Ok(en_Pregunta);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool En_PreguntaExists(int id)
        {
            return db.En_Pregunta.Count(e => e.Cod_Pregunta == id) > 0;
        }
    }
}