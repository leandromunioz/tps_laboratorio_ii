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
    public partial class Buscar_cliente : Form
    {
        Sistema<Clientes> sistema;

        public Buscar_cliente(Sistema<Clientes> sistema)
        {
            InitializeComponent();
            this.sistema = sistema;
        }

        private void btn_buscar_dni_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_buscar_dni.Text))
            {
                MessageBox.Show("Debe completar el campo para continuar.");
            }
            else
            {
                Clientes cliente = sistema.BuscarElemento(new Clientes("Leandro", "Munoz", txt_buscar_dni.Text, new DateTime(1996, 12, 22), "Mendoza 555", DateTime.Today));

                if(cliente is not null)
                {
                    Cliente_encontrado formClienteEncontrado = new Cliente_encontrado(cliente, sistema.Lista);
                    this.Close();
                    formClienteEncontrado.ShowDialog();
                    
                }
                
            }
        }

        private void txt_buscar_dni_KeyPress(object sender, KeyPressEventArgs e)
        {


            if ((e.KeyChar > 31 && e.KeyChar < 48) || (e.KeyChar > 57 && e.KeyChar < 256))
            {
                MessageBox.Show("Este campo admite sólo números.", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;

            }
            else
            {
                if (e.KeyChar == Convert.ToChar(Keys.Enter))
                {
                    Clientes cliente = sistema.BuscarElemento(new Clientes("a", "ape", txt_buscar_dni.Text, new DateTime(1996, 12, 22), "dd", DateTime.Today));

                    if (cliente is not null)
                    {
                        Cliente_encontrado formClienteEncontrado = new Cliente_encontrado(cliente, sistema.Lista);
                        this.Close();
                        formClienteEncontrado.ShowDialog();

                    }


                }
            }

        }

        private void Buscar_cliente_Load(object sender, EventArgs e)
        {

        }
    }

}
