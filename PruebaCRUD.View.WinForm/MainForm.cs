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
            model.IdSexo = 1;

            cphelper = new CPMXClientHelper();
            datoshelper = new DatoClientHelper();


            this.Load += MainForm_Load;
        }

        private async void MainForm_Load(object sender, EventArgs e)
        {
            //Cargar combos
            this.estados = await cphelper.Estados();
            this.sexos = await datoshelper.Sexos();
            await this.CargaDatos();

            cboEstados.DataSource = this.estados;
            cboEstados.DisplayMember = "Descripcion";

            cboSexos.DataSource = this.sexos;
            cboSexos.DisplayMember = "Descripcion";

            //Asigna enlace de datos a controles
            this.txtIdRegistro.DataBindings.Add("Text", model, "IdDato",false);
            this.txtNombre.DataBindings.Add("Text", model, "Nombre", false);
            this.txtPrimerApellido.DataBindings.Add("Text", model, "PrimerApellido", false);
            this.txtSegundoApellido.DataBindings.Add("Text", model, "SegundoApellido", false);
            this.dtpFechaNacimiento.DataBindings.Add("Text", model, "FechaNacimiento", false);
            //this.cboSexos.DataBindings.Add("SelectedValue", model, "IdSexo");

        }


        async Task CargaDatos()
        {
            this.datos = await datoshelper.Datos();
            this.dgvDatos.DataSource = datos;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            model = new Dato();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Guardar o actualizar

        }
    }
}
