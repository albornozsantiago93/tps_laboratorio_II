using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;


namespace AlbornozSantiago
{
    public partial class FrmEmpleado : Form
    {
        Empleado empleado;

        public FrmEmpleado()
        {
            InitializeComponent();
        }

        private void btnAgregarEmpleado_Click(object sender, EventArgs e)
        {
            if(txtApellido.Text != string.Empty && txtNombre.Text != string.Empty)
            {
                DateTime horaIngreso = new DateTime();
                horaIngreso.GetDateTimeFormats('t');
                DateTime horaSalida = new DateTime();
                horaSalida.GetDateTimeFormats('t');
                int dni = Validaciones.ValidarDni(txtDni.ToString());
                int nroDeTelefono = Validaciones.ValidarNroDeTelfono(txtNroTelefono.ToString());
                this.empleado = new Empleado(txtNombre.Text,txtApellido.Text,dni,nroDeTelefono.ToString(),txtDireccion.Text,horaIngreso,horaSalida);

                MessageBox.Show(txtNombre.Text.ToUpper() + ", " + txtApellido.Text.ToUpper() + "\nDADO DE ALTA");
                this.Close();
            }
            else
            {
                MessageBox.Show("Ingrese toda la informacion necesaria");
            }

        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region propiedades

        public Empleado Empleado
        {
            get { return this.empleado; }
            set { this.empleado = value; }
        }

        #endregion
    }
}
