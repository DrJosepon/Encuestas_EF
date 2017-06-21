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
    public class En_AlternativaController : ApiController
    {
        private Encuesta_EFContext db = new Encuesta_EFContext();

        // GET: api/En_Alternativa
        public IQueryable<En_Alternativa> GetEn_Alternativa()
        {
            return db.En_Alternativa;
        }

        // GET: api/En_Alternativa/5
        [ResponseType(typeof(En_Alternativa))]
        public async Task<IHttpActionResult> GetEn_Alternativa(int id)
        {
            En_Alternativa en_Alternativa = await db.En_Alternativa.FindAsync(id);
            if (en_Alternativa == null)
            {
                return NotFound();
            }

            return Ok(en_Alternativa);
        }

        // PUT: api/En_Alternativa/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutEn_Alternativa(int id, En_Alternativa en_Alternativa)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != en_Alternativa.Cod_Alternativa)
            {
                return BadRequest();
            }

            db.Entry(en_Alternativa).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!En_AlternativaExists(id))
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

        // POST: api/En_Alternativa
        [ResponseType(typeof(En_Alternativa))]
        public async Task<IHttpActionResult> PostEn_Alternativa(En_Alternativa en_Alternativa)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.En_Alternativa.Add(en_Alternativa);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = en_Alternativa.Cod_Alternativa }, en_Alternativa);
        }

        // DELETE: api/En_Alternativa/5
        [ResponseType(typeof(En_Alternativa))]
        public async Task<IHttpActionResult> DeleteEn_Alternativa(int id)
        {
            En_Alternativa en_Alternativa = await db.En_Alternativa.FindAsync(id);
            if (en_Alternativa == null)
            {
                return NotFound();
            }

            db.En_Alternativa.Remove(en_Alternativa);
            await db.SaveChangesAsync();

            return Ok(en_Alternativa);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool En_AlternativaExists(int id)
        {
            return db.En_Alternativa.Count(e => e.Cod_Alternativa == id) > 0;
        }
    }
}