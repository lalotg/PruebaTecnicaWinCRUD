using PruebaCRUD.CPMX.Data.EF.EDM;
using PruebaCRUD.CPMX.Model;
using PruebaCRUD.Data.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaCRUD.CPMX.Data.EF
{
    public class RepositorioCPMX : IDisposable
    {
        CPMXEntities db;

        public RepositorioCPMX()
        {
            string meta = "res://*/EDM.EDMCPMX.csdl|res://*/EDM.EDMCPMX.ssdl|res://*/EDM.EDMCPMX.msl";
            db = new CPMXEntities(BuildConnection.GetConnectionString(meta));
        }

        public int AgregaEstato(Estado model)
        {
            try
            {
                return db.SPI_CPMX_Estado(
                    model.Descripcion,
                    model.IdEstado
                );
            }
            catch (Exception e)
            {
                return -1;
            }
        }

        public int AgregaMunicipio(Municipio model)
        {
            try
            {
                return db.SPI_CPMX_Municipio(
                    model.IdMunicipio,
                    model.IdEstado,
                    model.Descripcion
                );
            }
            catch (Exception)
            {
                return -1;
            }
        }

        public int AgregaTipoAsentamiento(TipoAsentamiento model)
        {
            try
            {
                return db.SPI_CPMX_TipoAsentamiento(
                    model.IdTipo,
                    model.Descripcion
                );
            }
            catch (Exception)
            {
                return -1;
            }
        }

        public int AgregaAsentamiento(Asentamiento model)
        {
            try
            {
                return db.SPI_CPMX_Asentamiento(
                    model.IdAsentamiento,
                    model.Descripcion,
                    model.IdMunicipio,
                    model.IdEstado,
                    model.IdTipo,
                    model.CP
                );
            }
            catch (Exception)
            {
                return -1;
            }
        }

        public IEnumerable<Estado> ObtenerEstados()
        {
            try
            {
                return db.SPS_CPMX_Estados().Select(
                    item => new Estado
                    {
                        IdEstado = item.IdEstado,
                        Descripcion = item.Estado
                    }
                ).ToList();
            }
            catch (Exception)
            {
                return null;
            }
        }

        public IEnumerable<Municipio> ObtenerMunicipiosPorEstado(int idestado)
        {
            try
            {
                return db.SPS_CPMX_MunicipiosPorEstado(idestado).Select(
                    item => new Municipio
                    {
                        IdMunicipio = item.IdMunicipio,
                        IdEstado = item.IdEstado,
                        Descripcion = item.Municipio
                    }
                ).ToList();
            }
            catch (Exception)
            {
                return null;
            }
        }

        public IEnumerable<Asentamiento> ObtenerAsentamientos(int idestado, int idmunicipio)
        {
            try
            {
                return db.SPS_CPMX_Asentamientos(idestado, idmunicipio).Select(
                    item => new Asentamiento
                    {
                        IdAsentamiento = item.IdAsentamiento,
                        IdEstado = item.IdEstado,
                        IdMunicipio = item.IdMunicipio,
                        Descripcion = item.Asentamiento,
                        CP = item.CP
                    }
                ).ToList();
            }
            catch (Exception)
            {
                return null;
            }
        }

        public IEnumerable<Asentamiento> AsentamientosCP(string cp)
        {
            try
            {
                return db.SPS_CPMX_AsentamientosCP(cp).Select(
                    item => new Asentamiento
                    {
                        IdAsentamiento = item.IdAsentamiento,
                        IdEstado = item.IdEstado,
                        IdMunicipio = item.IdMunicipio,
                        Descripcion = item.Asentamiento,
                        CP = item.CP
                    }
                );
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public Estado EstadoId(int id)
        {
            try
            {
                return db.SPS_CPMX_EstadoId(id).Select(
                     item => new Estado
                     {
                         IdEstado = item.IdEstado,
                         Descripcion = item.Estado
                     }
                ).First();
            }
            catch (Exception)
            {
                return null;
            }
        }

        public Municipio MunicipioPorEM(int idestado, int idmunicipio)
        {
            try
            {
                return db.SPS_CPMX_MunicipioPorEM(idestado, idmunicipio).Select(
                    item => new Municipio
                    {
                        IdMunicipio = item.IdMunicipio,
                        IdEstado = item.IdEstado,
                        Descripcion = item.Municipio
                    }
                ).First();
            }
            catch (Exception)
            {
                return null;
            }
        }

        public void Dispose()
        {
            db.Dispose();
        }
    }
}
