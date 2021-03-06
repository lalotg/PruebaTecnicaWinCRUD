﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PruebaCRUD.Datos.Data.EF.EDM
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class DatosEntities : DbContext
    {
        public DatosEntities()
            : base("name=DatosEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
    
        public virtual int SPD_EXA_Dato(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SPD_EXA_Dato", idParameter);
        }
    
        public virtual int SPI_EXA_Datos(string nombre, string primerApellido, string segundoApellido, Nullable<System.DateTime> fechaNacimiento, Nullable<int> idSexo, string estadoNacimiento, string cURP, string telefono, string direccionActual, string cP, string estado, string municipio, string asentamiento, string calle, string numero, ObjectParameter id)
        {
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var primerApellidoParameter = primerApellido != null ?
                new ObjectParameter("PrimerApellido", primerApellido) :
                new ObjectParameter("PrimerApellido", typeof(string));
    
            var segundoApellidoParameter = segundoApellido != null ?
                new ObjectParameter("SegundoApellido", segundoApellido) :
                new ObjectParameter("SegundoApellido", typeof(string));
    
            var fechaNacimientoParameter = fechaNacimiento.HasValue ?
                new ObjectParameter("FechaNacimiento", fechaNacimiento) :
                new ObjectParameter("FechaNacimiento", typeof(System.DateTime));
    
            var idSexoParameter = idSexo.HasValue ?
                new ObjectParameter("IdSexo", idSexo) :
                new ObjectParameter("IdSexo", typeof(int));
    
            var estadoNacimientoParameter = estadoNacimiento != null ?
                new ObjectParameter("EstadoNacimiento", estadoNacimiento) :
                new ObjectParameter("EstadoNacimiento", typeof(string));
    
            var cURPParameter = cURP != null ?
                new ObjectParameter("CURP", cURP) :
                new ObjectParameter("CURP", typeof(string));
    
            var telefonoParameter = telefono != null ?
                new ObjectParameter("Telefono", telefono) :
                new ObjectParameter("Telefono", typeof(string));
    
            var direccionActualParameter = direccionActual != null ?
                new ObjectParameter("DireccionActual", direccionActual) :
                new ObjectParameter("DireccionActual", typeof(string));
    
            var cPParameter = cP != null ?
                new ObjectParameter("CP", cP) :
                new ObjectParameter("CP", typeof(string));
    
            var estadoParameter = estado != null ?
                new ObjectParameter("Estado", estado) :
                new ObjectParameter("Estado", typeof(string));
    
            var municipioParameter = municipio != null ?
                new ObjectParameter("Municipio", municipio) :
                new ObjectParameter("Municipio", typeof(string));
    
            var asentamientoParameter = asentamiento != null ?
                new ObjectParameter("Asentamiento", asentamiento) :
                new ObjectParameter("Asentamiento", typeof(string));
    
            var calleParameter = calle != null ?
                new ObjectParameter("Calle", calle) :
                new ObjectParameter("Calle", typeof(string));
    
            var numeroParameter = numero != null ?
                new ObjectParameter("Numero", numero) :
                new ObjectParameter("Numero", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SPI_EXA_Datos", nombreParameter, primerApellidoParameter, segundoApellidoParameter, fechaNacimientoParameter, idSexoParameter, estadoNacimientoParameter, cURPParameter, telefonoParameter, direccionActualParameter, cPParameter, estadoParameter, municipioParameter, asentamientoParameter, calleParameter, numeroParameter, id);
        }
    
        public virtual ObjectResult<SPS_EXA_Datos_Result> SPS_EXA_Datos()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SPS_EXA_Datos_Result>("SPS_EXA_Datos");
        }
    
        public virtual ObjectResult<SPS_PER_Sexos_Result> SPS_PER_Sexos()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SPS_PER_Sexos_Result>("SPS_PER_Sexos");
        }
    
        public virtual int SPU_EXA_Datos(string nombre, string primerApellido, string segundoApellido, Nullable<System.DateTime> fechaNacimiento, Nullable<int> idSexo, string estadoNacimiento, string cURP, string telefono, string direccionActual, string cP, string estado, string municipio, string asentamiento, string calle, string numero, Nullable<int> id)
        {
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var primerApellidoParameter = primerApellido != null ?
                new ObjectParameter("PrimerApellido", primerApellido) :
                new ObjectParameter("PrimerApellido", typeof(string));
    
            var segundoApellidoParameter = segundoApellido != null ?
                new ObjectParameter("SegundoApellido", segundoApellido) :
                new ObjectParameter("SegundoApellido", typeof(string));
    
            var fechaNacimientoParameter = fechaNacimiento.HasValue ?
                new ObjectParameter("FechaNacimiento", fechaNacimiento) :
                new ObjectParameter("FechaNacimiento", typeof(System.DateTime));
    
            var idSexoParameter = idSexo.HasValue ?
                new ObjectParameter("IdSexo", idSexo) :
                new ObjectParameter("IdSexo", typeof(int));
    
            var estadoNacimientoParameter = estadoNacimiento != null ?
                new ObjectParameter("EstadoNacimiento", estadoNacimiento) :
                new ObjectParameter("EstadoNacimiento", typeof(string));
    
            var cURPParameter = cURP != null ?
                new ObjectParameter("CURP", cURP) :
                new ObjectParameter("CURP", typeof(string));
    
            var telefonoParameter = telefono != null ?
                new ObjectParameter("Telefono", telefono) :
                new ObjectParameter("Telefono", typeof(string));
    
            var direccionActualParameter = direccionActual != null ?
                new ObjectParameter("DireccionActual", direccionActual) :
                new ObjectParameter("DireccionActual", typeof(string));
    
            var cPParameter = cP != null ?
                new ObjectParameter("CP", cP) :
                new ObjectParameter("CP", typeof(string));
    
            var estadoParameter = estado != null ?
                new ObjectParameter("Estado", estado) :
                new ObjectParameter("Estado", typeof(string));
    
            var municipioParameter = municipio != null ?
                new ObjectParameter("Municipio", municipio) :
                new ObjectParameter("Municipio", typeof(string));
    
            var asentamientoParameter = asentamiento != null ?
                new ObjectParameter("Asentamiento", asentamiento) :
                new ObjectParameter("Asentamiento", typeof(string));
    
            var calleParameter = calle != null ?
                new ObjectParameter("Calle", calle) :
                new ObjectParameter("Calle", typeof(string));
    
            var numeroParameter = numero != null ?
                new ObjectParameter("Numero", numero) :
                new ObjectParameter("Numero", typeof(string));
    
            var idParameter = id.HasValue ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SPU_EXA_Datos", nombreParameter, primerApellidoParameter, segundoApellidoParameter, fechaNacimientoParameter, idSexoParameter, estadoNacimientoParameter, cURPParameter, telefonoParameter, direccionActualParameter, cPParameter, estadoParameter, municipioParameter, asentamientoParameter, calleParameter, numeroParameter, idParameter);
        }
    }
}
