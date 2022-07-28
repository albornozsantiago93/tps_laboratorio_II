using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace AlbornozSantiago
{
    public partial class FrmInforme : Form
    {
        private static string rutaBase;
        private List<Venta> ventas;
        private static Serializador<Venta> serializador;
        char separador = Path.DirectorySeparatorChar;


        public FrmInforme()
        {
            InitializeComponent();
        }

        // INICIALIZA EL SERIALIZADOR Y EL FRM DE INFORME
        static FrmInforme()
        {
            serializador = new Serializador<Venta>();
            char separador = Path.DirectorySeparatorChar;
            rutaBase = $"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}{separador}Albornoz_Santiago{separador}Ventas{separador}";
            Directory.CreateDirectory(rutaBase);
        }

        // EXPORTA EL INFORME DE UN EMPLEADO Y LA VENTA REALIZADA EN UN ARCHIVO
        private void btnExportarInforme_Click(object sender, EventArgs e)
        {
            try
            {
                
                foreach(Venta venta in Ventas)
                {
                    serializador.SerializarJsonYGuardar($"{rutaBase}{venta.empleado.Nombre}.txt", venta);
                }

                this.Close();
            }
            catch (ErrorEnArchivosException ex)
            {
                throw new Exception(ex.Message);
            }
        }



        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void FrmInforme_Load(object sender, EventArgs e)
        {
            foreach (Venta aux in Ventas)
            {
                this.rchInforme.Text = aux.ToString();
            }
        }

        public List<Venta> Ventas
        {
            get { return this.ventas; }
            set { this.ventas = value; }
        }

    }
}
