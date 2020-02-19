using PruebaCRUD.Datos.Business;
using PruebaCRUD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace PruebaCRUD.Service.WebApi.Controllers
{
    public class SexoController : ApiController
    {
        LogicaNegociosDatos db;

        public SexoController()
        {
            db = new LogicaNegociosDatos();
        }

        public IEnumerable<Sexo> Get()
        {
            return db.Sexos();
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}