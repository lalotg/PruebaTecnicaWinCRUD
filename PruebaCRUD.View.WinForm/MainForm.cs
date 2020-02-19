using PruebaCRUD.CPMX.Model;
using PruebaCRUD.Model;
using PruebaCRUD.View.ClientHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaCRUD.View.WinForm
{
    public partial class MainForm : Form
    {
        List<Estado> estados;
        List<Sexo> sexos;
        List<Dato> datos;
        Dato model;
        CPMXClientHelper cphelper;
        DatoClientHelper datoshelper;
        public MainForm()
        {
            InitializeComponent();
            estados = new List<Estado>();
            sexos = new List<Sexo>();
            datos = new List<Dato>();
            model = new Dato();

            cphelper = new CPMXClientHelper();
            datoshelper = new DatoClientHelper();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //Cargar combos
        }
    }
}
