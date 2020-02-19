using PruebaCRUD.Datos.Data.EF.EDM;
using PruebaCRUD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaCRUD.Datos.Business
{
    public class LogicaNegociosDatos : IDisposable
    {
        RepositorioDatos db;
        public LogicaNegociosDatos()
        {
            db = new RepositorioDatos();
        }

        public IEnumerable<Sexo> Sexos()
        {
            return db.Sexos();
        }

        public IEnumerable<Dato> Datos()
        {
            return db.Datos();
        }

        public Dato AddDato(Dato model)
        {
            return db.AddDato(model);
        }

        public int UpDato(Dato model)
        {
            return db.UpDato(model);
        }

        public int DelDato(int id)
        {
            return db.DelDato(id);
        }

        public void Dispose()
        {
            db.Dispose();
        }
    }
}
