using PruebaCRUD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaCRUD.View.WinForm.Model
{
    public class DatosHelper
    {
        Dato _dato;
        public Dato Dato
        {
            get { return this._dato; }
            set
            {
                this._dato = value;
                //this.RefreshDataBindings();
            }
        }
    }
}
