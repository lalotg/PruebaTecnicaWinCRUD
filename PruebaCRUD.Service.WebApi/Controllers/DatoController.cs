using PruebaCRUD.Datos.Business;
using PruebaCRUD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PruebaCRUD.Service.WebApi.Controllers
{
    public class DatoController : ApiController
    {
        LogicaNegociosDatos db;
        public DatoController()
        {
            db = new LogicaNegociosDatos();
        }

        // GET: api/Dato
        public IEnumerable<Dato> Get()
        {
            return db.Datos();
        }

        //// GET: api/Dato/5
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST: api/Dato
        public Dato Post(Dato model)
        {
            return db.AddDato(model);
        }

        // PUT: api/Dato/5
        public int Put(Dato model)
        {
            return db.UpDato(model);
        }

        // DELETE: api/Dato/5
        public int Delete(int id)
        {
            return db.DelDato(id);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}
