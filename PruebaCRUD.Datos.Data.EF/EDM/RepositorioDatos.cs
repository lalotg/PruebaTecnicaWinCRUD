using PruebaCRUD.Data.Helper;
using PruebaCRUD.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaCRUD.Datos.Data.EF.EDM
{
    public class RepositorioDatos : IDisposable
    {
        DatosEntities db;
        public RepositorioDatos()
        {
            string meta = "res://*/EDM.EDMDatos.csdl|res://*/EDM.EDMDatos.ssdl|res://*/EDM.EDMDatos.msl";
            db = new DatosEntities(BuildConnection.GetConnectionString(meta));
        }

        public IEnumerable<Sexo> Sexos()
        {
            try
            {
                return db.SPS_PER_Sexos().Select(
                    item=> new Sexo
                    {
                     IdSexo = item.IdSexo,
                     Descripcion = item.Descripcion
                    }
                );
            }
            catch (Exception)
            {
                return null;
            }
        }

        public IEnumerable<Dato> Datos()
        {
            try
            {
                return db.SPS_EXA_Datos().Select(
                    item=> new Dato
                    {
                        IdDato= item.IdDato,
                        Nombre = item.Nombre,
                        PrimerApellido = item.PrimerApellido,
                        SegundoApellido = item.SegundoApellido,
                        FechaNacimiento = item.FechaNacimiento,
                        IdSexo = item.IdSexo,
                        EstadoNacimiento = item.EstadoNacimiento,
                        CURP = item.CURP,
                        Telefono = item.Telefono,
                        DireccionActual = item.DireccionActual,
                        CP=  item.CP,
                        Municipio = item.Municipio,
                        Asentamiento = item.Asentamiento,
                        Calle = item.Calle,
                        Numero = item.Numero
                    }
                );
            }
            catch (Exception)
            {
                return null;
            }
        }

        public Dato AddDato(Dato model)
        {
            try
            {
                var parameter = new ObjectParameter("Id", typeof(int));
                db.SPI_EXA_Datos(
                    model.Nombre,
                    model.PrimerApellido,
                    model.SegundoApellido,
                    model.FechaNacimiento,
                    model.IdSexo,
                    model.EstadoNacimiento,
                    model.CURP,
                    model.Telefono,
                    model.DireccionActual,
                    model.CP,
                    model.Municipio,
                    model.Asentamiento,
                    model.Calle,
                    model.Numero,
                    parameter
                );

                model.IdDato = int.Parse(parameter.Value.ToString());
                return model;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public int UpDato(Dato model)
        {
            try
            {
                return db.SPU_EXA_Datos(
                    model.Nombre,
                    model.PrimerApellido,
                    model.SegundoApellido,
                    model.FechaNacimiento,
                    model.IdSexo,
                    model.EstadoNacimiento,
                    model.CURP,
                    model.Telefono,
                    model.DireccionActual,
                    model.CP,
                    model.Municipio,
                    model.Asentamiento,
                    model.Calle,
                    model.Numero,
                    model.IdDato
                );
            }
            catch (Exception)
            {
                return -1;
            }
        }

        public int DelDato(int id)
        {
            try
            {
                return db.SPD_EXA_Dato(id);
            }
            catch (Exception)
            {
                return -1;
            }
        }

        public void Dispose()
        {
            db.Dispose();
        }
    }
}
