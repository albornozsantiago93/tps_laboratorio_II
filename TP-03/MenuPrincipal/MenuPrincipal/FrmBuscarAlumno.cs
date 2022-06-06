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
using static System.Environment;

namespace MenuPrincipal
{
    public partial class FrmBuscarAlumno : Form
    {
        public List<Alumno> alumnos;

        public FrmBuscarAlumno()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Buscar en la lisa de alumnos por apellido
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            foreach(Alumno alum in alumnos)
            {
                if (txtApellido.Text.ToLower() == alum.Apellido.ToLower())
                {
                    lstDatosAlumnos.Items.Add(alum.ToString());
                }
            }
            
        }

        #region PROPIEDADES

        public List<Alumno> ListaAlumnos
        {
            get
            {
                return this.alumnos;
            }
            set
            {
                this.alumnos = value;
            }
        }

        #endregion

        private void btnDescargarFichaDeAlumno_Click(object sender, EventArgs e)
        {
                
            try
            {
                Alumno alumno = (Alumno)lstDatosAlumnos.SelectedItem;

                if (alumno != null)
                {
                    Serializadora<Alumno> serializadoraJSON = new Serializadora<Alumno>();


                    serializadoraJSON.Guardar(GetFolderPath(SpecialFolder.Desktop), alumno.Nombre, alumno);
                    MessageBox.Show("Se ha descargado la ficha con exito");
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un alumno");
                }
            }
            catch(Exception ex)
            {
                
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
