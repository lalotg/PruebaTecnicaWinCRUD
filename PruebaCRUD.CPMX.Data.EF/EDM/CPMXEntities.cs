using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaCRUD.CPMX.Data.EF.EDM
{
    public partial class CPMXEntities : DbContext
    {
        public CPMXEntities(string connectionString)
            : base(connectionString)
        {
        }
    }
}
