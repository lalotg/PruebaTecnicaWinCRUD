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

        public Municipio Get(int idestado,int idmunicipio)
        {
            return db.MunicipioPorEM(idestado,idmunicipio);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}