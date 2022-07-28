using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Munioz.Leandro._2A.TP1
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
            cmbOperador.Items.Add(' ');
            cmbOperador.Items.Add('+');
            cmbOperador.Items.Add('-');
            cmbOperador.Items.Add('*');
            cmbOperador.Items.Add('/');
        }

        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {
            lblResultado.Text = "0";
            txtNumero1.Text = "";
            txtNumero2.Text = "";
            this.cmbOperador.SelectedIndex = 0;

        }

        private double Operar(string numero1, string numero2, string Operador)
        {

            return Math.Round(Calculadora.Operar(new Operando(numero1), new Operando(numero2), char.Parse(Operador)), 2);

        }

        private double validarNumero(string num)
        {
            double retorno;
            double numero;

            if (!double.TryParse(num, out numero))
            {
                retorno = 0;
            }
            else
            {
                retorno = numero;

            }
            return numero;
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            double resultado;
            string operador = cmbOperador.Text;
            if (operador == " ")
            {
                operador = "+";

            }

            txtNumero1.Text = txtNumero1.Text.Replace('.', ',');
            txtNumero2.Text = txtNumero2.Text.Replace('.', ',');
            resultado = Operar(txtNumero1.Text, txtNumero2.Text, operador);
            if (resultado == double.MinValue)
            {
                lstOperaciones.Items.Add("No se puede dividir por 0");
                lblResultado.Text = ("No se puede dividir por 0");
            }
            else
            {


                lblResultado.Text = resultado.ToString();
                lstOperaciones.Items.Add(validarNumero(txtNumero1.Text) + operador + validarNumero(txtNumero2.Text) + "=" + resultado);

            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            Operando auxiliar = new Operando();
            string strAux;
            string textAnterior = lblResultado.Text;
            strAux = auxiliar.DecimalABinario(lblResultado.Text);
            lblResultado.Text = strAux;
            lstOperaciones.Items.Add(textAnterior + "->" + strAux);
        }

        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            Operando auxiliar = new Operando();
            string strAux;
            string textAnterior = lblResultado.Text;
            strAux = auxiliar.BinarioDecimal(lblResultado.Text);
            lblResultado.Text = strAux;
            lstOperaciones.Items.Add(textAnterior + "->" + strAux);
        }

        private void FormCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Seguro que desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
