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
        bool nuevo;
        public MainForm()
        {
            InitializeComponent();
            estados = new List<Estado>();
            sexos = new List<Sexo>();
            datos = new List<Dato>();
            model = new Dato();
            model.IdSexo = 1;
            model.FechaNacimiento = DateTime.Now;

            cphelper = new CPMXClientHelper();
            datoshelper = new DatoClientHelper();
            nuevo = true;

            this.Load += MainForm_Load;
        }

        private async void MainForm_Load(object sender, EventArgs e)
        {
            //Cargar combos
            this.estados = await cphelper.Estados();
            this.sexos = await datoshelper.Sexos();
            await this.CargaDatosGrid();

            cboEstados.DataSource = this.estados;
            cboEstados.DisplayMember = "Descripcion";

            cboSexos.DataSource = this.sexos;
            cboSexos.DisplayMember = "Descripcion";

            AsignaEnlaceDatos();
        }

        void AsignaEnlaceDatos()
        {
            //Asigna enlace de datos a controles
            this.txtIdRegistro.DataBindings.Clear();
            this.txtIdRegistro.DataBindings.Add("Text", model, "IdDato", false);
            this.txtNombre.DataBindings.Clear();
            this.txtNombre.DataBindings.Add("Text", model, "Nombre", false);
            this.txtPrimerApellido.DataBindings.Clear();
            this.txtPrimerApellido.DataBindings.Add("Text", model, "PrimerApellido", false);
            this.txtSegundoApellido.DataBindings.Clear();
            this.txtSegundoApellido.DataBindings.Add("Text", model, "SegundoApellido", false);
            this.dtpFechaNacimiento.DataBindings.Clear();
            this.dtpFechaNacimiento.DataBindings.Add("Text", model, "FechaNacimiento", false);
            this.txtCurp.DataBindings.Clear();
            this.txtCurp.DataBindings.Add("Text", model, "CURP");
            this.txtTelefono.DataBindings.Clear();
            this.txtTelefono.DataBindings.Add("Text", model, "Telefono");
            this.txtDireccionActual.DataBindings.Clear();
            this.txtDireccionActual.DataBindings.Add("Text", model, "DireccionActual");
            this.txtCP.DataBindings.Clear();
            this.txtCP.DataBindings.Add("Text", model, "CP");
            this.txtMunicipio.DataBindings.Clear();
            this.txtMunicipio.DataBindings.Add("Text", model, "Municipio");
            this.txtAsentamiento.DataBindings.Clear();
            this.txtAsentamiento.DataBindings.Add("Text", model, "Asentamiento");
            this.txtCalle.DataBindings.Clear();
            this.txtCalle.DataBindings.Add("Text", model, "Calle");
            this.txtNumero.DataBindings.Clear();
            this.txtNumero.DataBindings.Add("Text", model, "Numero");
            //DatePicker
            this.dtpFechaNacimiento.DataBindings.Add("Value", model, "FechaNacimiento");

        }

        async Task CargaDatosGrid()
        {
            this.datos = await datoshelper.Datos();
            this.dgvDatos.DataSource = datos;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            model = new Dato();
            model.IdSexo = 1;
            model.FechaNacimiento = DateTime.Now;
            AsignaEnlaceDatos();
            this.nuevo = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Guardar o actualizar
            if(this.nuevo)
            {
                //Guardar

            }
            else
            {
                //Actualizar

            }
        }

        private void txtCurp_Enter(object sender, EventArgs e)
        {
            //Calcular rfc

        }


        private async void txtEstado_Enter(object sender, EventArgs e)
        {
            if (txtCP.Text.Length == 5)
            {
                //Busca asentamiento
                var asentamientos = await cphelper.AsentamientosPorCP(txtCP.Text);
                var asentamiento = asentamientos.First();
                //Obtener Estado
                var edo = await cphelper.EstadoPorId(int.Parse(asentamiento.IdEstado.ToString()));
                txtEstado.Text = edo.Descripcion;
                //Obtener Municipio
                var municipio = await cphelper.EstadoPorEM(int.Parse(asentamiento.IdEstado.ToString()), asentamiento.IdMunicipio);
                txtMunicipio.Text = municipio.Descripcion;

            }
        }
    }
}
