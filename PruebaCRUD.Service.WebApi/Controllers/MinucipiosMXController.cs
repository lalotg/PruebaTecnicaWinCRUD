using PruebaCRUD.CPMX.Business;
using PruebaCRUD.CPMX.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace PruebaCRUD.Service.WebApi.Controllers
{
    public class MinucipiosMXController : ApiController
    {
        LogicaNegocioCPMX db;
        public MinucipiosMXController()
        {
            db = new LogicaNegocioCPMX();
        }

        public IEnumerable<Municipio> Get(int idestado)
        {
            return db.ObtenerMunicipiosPorEstado(idestado);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}