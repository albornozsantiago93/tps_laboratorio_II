using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApp1
{
    public partial class MiCalculadora : Form
    {
        public MiCalculadora()
        {
            InitializeComponent();
        }
        private double Operar(string numero1, string numero2, string operador)
        {
            double retorno = 0;
            Operando operando1 = new Operando(numero1);
            Operando operando2 = new Operando(numero2);
            string operando = this.cmbOperador.Text;

            if (operando1 != null && operando2 != null && operando != string.Empty)
            {
                retorno = Calculadora.Operar(operando1, operando2, operando[0]);
            }
            else
            {
                MessageBox.Show("Ingrese valores validos");
            }

            return retorno;
        }

        public void btnOperar_Click(object sender, EventArgs e)
        {
            if(this.txtNumero1.Text != string.Empty && this.txtNumero2.Text != string.Empty && this.cmbOperador.Text != string.Empty)
            {
                this.CargarOperaciones();            
            }
            else
            {
                MessageBox.Show("Ingrese valores validos");
            }

        }

        private void MiCalculadora_Load(object sender, EventArgs e)
        {
            this.Limpiar();
        }

        private void CargarOperaciones()
        {
            string numero1 = this.txtNumero1.Text.Replace(".", ",");
            string numero2 = this.txtNumero2.Text.Replace(".", ",");
            string operador = this.cmbOperador.Text;
           
            double resultado = Operar(numero1, numero2, operador);

            string operadorAMostrar = operador == " " ? "+" : operador;
            string numero1AMostrar = numero1;
            string numero2AMostrar = numero2;
            string resultadoAMostrar = resultado.ToString();

            if (numero1 == "" || !double.TryParse(numero1, out double n)) numero1AMostrar = "0";
            if (numero2 == "" || !double.TryParse(numero2, out n)) numero2AMostrar = "0";
            if (numero2.StartsWith("-")) numero2AMostrar = $"({numero2})";
            if ((resultado == double.MinValue && operador == "/")) resultadoAMostrar = "Inválido";

            this.lblResultado.Text = resultadoAMostrar;
            this.lstOperaciones.Items.Add($"{numero1AMostrar} {operadorAMostrar} {numero2AMostrar} = {resultadoAMostrar}");
            
        }

        /// <summary>
        /// El botón btnCerrar deberá cerrar el formulario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Limpiar()
        {
            this.txtNumero1.Text = "";
            this.txtNumero2.Text = "";
            this.lblResultado.Text = "";
            this.cmbOperador.SelectedItem = null;
        }


        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }

        /// <summary>
        /// El evento click del botón btnConvertirABinario convertirá el resultado, de existir, a binario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            string retorno = this.lblResultado.Text;

            if (retorno != "" && retorno != "Inválido")
            {
                Operando operando = new Operando(retorno);
                string binario = operando.DecimalBinario(retorno);
                if (binario.ToLower() == "valor inválido" )
                {
                    binario = "Inválido";
                }
                this.lblResultado.Text = binario;

            }
            else
            {
                MessageBox.Show("No se puede convertir a binario");
            }
        }

        /// <summary>
        /// El evento click del botón btnConvertirADecimal convertirá el resultado, de existir y ser binario, a decimal.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            string retorno = this.lblResultado.Text;

            if (retorno != "" && retorno != "Inválido")
            {
                Operando operando = new Operando(retorno);
                string decimalResult = operando.BinarioDecimal(retorno);
                if (decimalResult.ToLower() == "valor inválido")
                {
                    decimalResult = "Inválido";
                }
                this.lblResultado.Text = decimalResult;
            }
            else
            {
                MessageBox.Show("No se puede convertir a decimal");
            }
        }

        private void MiCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Seguro de querer salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void SoloNumeros(KeyPressEventArgs input)
        {
            if(char.IsDigit(input.KeyChar))
            {
                input.Handled = false;
            }
            else if(char.IsControl(input.KeyChar))
            {
                input.Handled= false;
            }
            else
            {
                input.Handled= true;
            }
        }

        private void txtNumero1_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        private void txtNumero2_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }
    }
}
