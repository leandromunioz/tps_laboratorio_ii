using Gimnasio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gimnasio_PAPUSA
{
    public partial class AgregarClientes : Form
    {

        private Clientes cliente;

        public Clientes Cliente
        {
            get
            {
                return cliente;
            }
        }

        public AgregarClientes()
        {
            InitializeComponent();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            string message = "¿ Desea cancelar la operación ?";
            string title = "Cancelar operación";
            DialogResult result = MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }




        private void btn_registrar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txt_reg_nombre.Text) || string.IsNullOrEmpty(txt_reg_apellido.Text) || string.IsNullOrEmpty(txt_reg_dni.Text) || string.IsNullOrEmpty(txt_reg_direccion.Text))
            {
                MessageBox.Show("Por favor, complete correctamente todos los campos antes de continuar.", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            if ((DateTime.Today.Year - fechaNac.Value.Year) < 16)
            {
                MessageBox.Show("La edad mínima para inscribirse al gimnasio es de 16 años.", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

            else
            {
                cliente = new Clientes(txt_reg_nombre.Text, txt_reg_apellido.Text, txt_reg_dni.Text, fechaNac.Value, txt_reg_direccion.Text, fechaPago.Value);
                ClientesDB.Guardar(cliente);

                this.DialogResult = DialogResult.OK;
            }

        }

        private void txt_reg_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar > 31 && e.KeyChar < 65) || (e.KeyChar > 90 && e.KeyChar < 97) || (e.KeyChar > 122 && e.KeyChar < 256))
            {
                MessageBox.Show("Este campo admite sólo letras, sin tildes ni caracteres especiales.", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;

            }

        }

        private void txt_reg_apellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar > 31 && e.KeyChar < 65) || (e.KeyChar > 90 && e.KeyChar < 97) || (e.KeyChar > 122 && e.KeyChar < 256))
            {
                MessageBox.Show("Este campo admite sólo letras, sin tildes ni caracteres especiales.", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;

            }
        }



        private void txt_reg_dni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar > 31 && e.KeyChar < 48) || (e.KeyChar > 57 && e.KeyChar < 256))
            {
                MessageBox.Show("Este campo admite sólo números.", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;

            }
        }
    }
}
