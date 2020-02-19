using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaCRUD.CPMX.Model
{
    public class Asentamiento
    {
        public int IdAsentamiento { get; set; }
        public string Descripcion { get; set; }
        public int IdMunicipio { get; set; }
        public int? IdEstado { get; set; }
        public int IdTipo { get; set; }
        public string CP { get; set; }
    }
}
