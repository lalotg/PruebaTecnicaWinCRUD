using PruebaCRUD.CPMX.Data.EF;
using PruebaCRUD.CPMX.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaCRUD.CPMX.Business
{
    public class LogicaNegocioCPMX : IDisposable
    {
        RepositorioCPMX db;
        public LogicaNegocioCPMX()
        {
            db = new RepositorioCPMX();
        }

        public int AgregaEstato(Estado model)
        {
            return db.AgregaEstato(model);
        }
        public int AgregaMunicipio(Municipio model)
        {
            return db.AgregaMunicipio(model);
        }
        public int AgregaTipoAsentamiento(TipoAsentamiento model)
        {
            return db.AgregaTipoAsentamiento(model);
        }
        public int AgregaAsentamiento(Asentamiento model)
        {
            return db.AgregaAsentamiento(model);
        }

        public IEnumerable<Estado> ObtenerEstados()
        {
            return db.ObtenerEstados();
        }

        public IEnumerable<Municipio> ObtenerMunicipiosPorEstado(int idestado)
        {
            return db.ObtenerMunicipiosPorEstado(idestado);
        }

        public IEnumerable<Asentamiento> ObtenerAsentamientos(int idestado, int idmunicipio)
        {
            return db.ObtenerAsentamientos(idestado, idmunicipio);
        }

        public IEnumerable<Asentamiento> AsentamientosCP(string cp)
        {
            return db.AsentamientosCP(cp);
        }

        public Estado EstadoId(int id)
        {
            return db.EstadoId(id);
        }

        public Municipio MunicipioPorEM(int idestado, int idmunicipio)
        {
            return db.MunicipioPorEM(idestado, idmunicipio);
        }

        public void Dispose()
        {
            db.Dispose();
        }
    }
}
