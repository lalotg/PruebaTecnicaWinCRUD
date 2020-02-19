using PruebaCRUD.CPMX.Business;
using PruebaCRUD.CPMX.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace PruebaCRUD.Service.WebApi.Controllers
{
    public class EstadosMXController : ApiController
    {
        LogicaNegocioCPMX db;

        public EstadosMXController()
        {
            db = new LogicaNegocioCPMX();
        }

        public IEnumerable<Estado> Get()
        {
            return db.ObtenerEstados();
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}