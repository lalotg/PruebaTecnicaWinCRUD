using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaCRUD.Model
{
    public class Dato
    {
        public int IdDato { get; set; }
        public string Nombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public int? IdSexo { get; set; }
        public string EstadoNacimiento { get; set; }
        public string CURP { get; set; }
        public string Telefono { get; set; }
        public string DireccionActual { get; set; }
        public string CP { get; set; }
        public string Estado { get; set; }
        public string Municipio { get; set; }
        public string Asentamiento { get; set; }
        public string Calle { get; set; }
        public string Numero { get; set; }
    }
}
