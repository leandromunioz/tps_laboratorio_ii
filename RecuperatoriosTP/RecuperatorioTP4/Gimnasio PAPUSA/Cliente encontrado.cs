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
    public partial class Cliente_encontrado : Form
    {

        Clientes cliente;
        List<Clientes> listaClientes;

        public Cliente_encontrado(Clientes clienteRecibido, List<Clientes> listaClientesRecibida)
        {
            InitializeComponent();
            this.cliente = clienteRecibido;
            this.listaClientes = listaClientesRecibida;
        }

        private void btn_clienteEncontrado_cancelar_Click(object sender, EventArgs e)
        {
            string message = "¿ Desea cancelar la operación ?";
            string title = "Cancelar operación";
            DialogResult result = MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void Cliente_encontrado_Load(object sender, EventArgs e)
        {
            rtb_clienteEncontrado.Text += cliente.ToString();
            fechaNac_clienteEncontrado.Value = cliente.FechaNacimiento;
        }

        private void btn_clienteEncontrado_eliminar_Click(object sender, EventArgs e)
        {

            string message = "¿ Desea eliminar este cliente ?";
            string title = "Eliminar cliente";
            DialogResult result = MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                ClientesDB.Eliminar(Convert.ToInt32(cliente.Dni));
                listaClientes.Remove(cliente);
                rtb_clienteEncontrado.Clear();
                this.Close();
                this.DialogResult = DialogResult.OK;
            }

        }

        private void btn_clienteEncontrado_modificar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_clienteEncontrado_nombre.Text))
            {
                cliente.Nombre = txt_clienteEncontrado_nombre.Text;
            }

            if (!string.IsNullOrEmpty(txt_clienteEncontrado_apellido.Text))
            {
                cliente.Apellido = txt_clienteEncontrado_apellido.Text;
            }

            if (!string.IsNullOrEmpty(txt_clienteEncontrado_direccion.Text))
            {
                cliente.Direccion = txt_clienteEncontrado_direccion.Text;
            }

            if (fechaNac_clienteEncontrado.Value != cliente.FechaNacimiento && !fechaNac_clienteEncontrado.Value.EsMenor())
            {
                cliente.FechaNacimiento = fechaNac_clienteEncontrado.Value;
            }
            else if (fechaNac_clienteEncontrado.Value.EsMenor())
            {
                MessageBox.Show("La edad del cliente no puede ser menor a 16 años.");
            }



            ClientesDB.Modificar(cliente);
            rtb_clienteEncontrado.Clear();
            rtb_clienteEncontrado.Text += cliente.ToString();
            this.DialogResult = DialogResult.OK;


        }
    }
}
