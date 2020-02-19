using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaCRUD.Datos.Data.EF.EDM
{
    public partial class DatosEntities : DbContext
    {
        public DatosEntities(string connectionString)
            : base(connectionString)
        {
        }
    }
}