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

namespace Mundial2018.Controllers {
    public class NationsController : ApiController {
        private Mundial2018Db db = new Mundial2018Db();

        // GET: api/Nations
        public IHttpActionResult GetNations() {
            var resultado = db.Nations
               .Select(nation => new {
                   nation.ID,
                   nation.Name,
                   nation.Wins,
                   nation.Participations,
                   nation.Flag,
                   nation.Group,
                   nation.Caption,
                   nation.Anthem
               })
                .OrderBy(nation => new { nation.Name })
                .ToList();


            return Ok(resultado);
        }

        // GET: api/Nations/5
        [ResponseType(typeof(Nations))]
        public IHttpActionResult GetNations(int id) {
            Nations nations = db.Nations.Find(id);
            if (nations == null) {
                return NotFound();
            }

            return Ok(nations);
        }

        // GET: api/Nations/5/Players
        [HttpGet, Route("api/Nations/{id}/Players")]
        public IHttpActionResult GetNationPlayers(int id) {
            Nations nation = db.Nations.Find(id);

            var resultado = nation.Players
                .Select(players => new {
                    players.ID,
                    players.Name,
                    players.Position,
                    players.Image,
                    players.Introduction
                })
                .ToList();


            return Ok(resultado);
        }

        // GET: api/Nations/5/Players/5/Details
        [HttpGet, Route("api/Players/{idPlayer}/Details")]
        public IHttpActionResult GetPlayerDetails(int idPlayer) {
            Players player = db.Players.Find(idPlayer);

            var resultado = new {
                player.Name,
                player.Position,
                player.Image,
                player.Introduction
            };
            return Ok(resultado);
        }
    }
}