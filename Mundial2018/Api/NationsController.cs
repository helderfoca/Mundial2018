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
using Mundial2018.Models;

namespace Mundial2018.Controllers
{
    [RoutePrefix("api/Nations")]
    public class NationsController : ApiController
    {
        private Mundial2018Db db = new Mundial2018Db();

        // GET: api/Nations
        public IHttpActionResult GetNations()
        {
            var resultado = db.Nations
               .Select(nation => new {
                   nation.ID,
                   nation.Name,
                   nation.Flag,
                   nation.GroupFK
               })
                .ToList();


            return Ok(resultado);
        }

        // GET: api/Nations/5
        [ResponseType(typeof(Nations))]
        public IHttpActionResult GetNations(int id)
        {
            Nations nations = db.Nations.Find(id);
            if (nations == null)
            {
                return NotFound();
            }

            return Ok(nations);
        }

        // GET: api/Nations/5/Players
        [HttpGet, Route("{id}/Players")]
        public IHttpActionResult GetNationPlayers(int id)
        {
            Nations nation = db.Nations.Find(id);

            var resultado = nation.Players
                .Select(players => new {
                    players.ID,
                    players.Name,
                    players.BirthDate,
                    players.Position,
                    players.Image,
                    players.Introduction
                })
                .ToList();


            return Ok(resultado);
        }

        // PUT: api/Nations/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutNations(int id, Nations nations)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != nations.ID)
            {
                return BadRequest();
            }

            db.Entry(nations).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!NationsExists(id))
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

        // POST: api/Nations
        [ResponseType(typeof(Nations))]
        public IHttpActionResult PostNations(Nations nations)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Nations.Add(nations);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = nations.ID }, nations);
        }

        // DELETE: api/Nations/5
        [ResponseType(typeof(Nations))]
        public IHttpActionResult DeleteNations(int id)
        {
            Nations nations = db.Nations.Find(id);
            if (nations == null)
            {
                return NotFound();
            }

            db.Nations.Remove(nations);
            db.SaveChanges();

            return Ok(nations);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool NationsExists(int id)
        {
            return db.Nations.Count(e => e.ID == id) > 0;
        }
    }
}