using PruebaCRUD.CPMX.Business;
using PruebaCRUD.CPMX.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace PruebaCRUD.Service.WebApi.Controllers
{
    public class AsentamientosMXController : ApiController
    {
        LogicaNegocioCPMX db;

        public AsentamientosMXController()
        {
            db = new LogicaNegocioCPMX();
        }

        public IEnumerable<Asentamiento> Get(string cp)
        {
            return db.AsentamientosCP(cp);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}