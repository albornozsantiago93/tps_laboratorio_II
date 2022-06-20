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
    public partial class FrmInforme : Form
    {
        private static Serializador<List<Venta>> serializador;
        private static string path;
        private List<Venta> ventas;

        
        public FrmInforme()
        {
            InitializeComponent();
            serializador = new Serializador<List<Venta>>();
            path = $"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}";

        }

        private void btnExportarInforme_Click(object sender, EventArgs e)
        {
            try
            {
                serializador.SerializarJsonYGuardar($"{path}.txt", Ventas);                
                this.Close();
            }
            catch(ErrorEnArchivosException ex)
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
            foreach(Venta aux in Ventas)
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
