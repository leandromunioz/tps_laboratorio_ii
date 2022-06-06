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
    public partial class Gestor_Profes : Form
    {

        string usuario;
        Sistema<Clientes> sistemaClientes;

        private Gestor_Profes()
        {
            InitializeComponent();
            sistemaClientes = new Sistema<Clientes>();
        }

        public Gestor_Profes(string nombreUsuario) : this()
        {
            this.usuario = nombreUsuario;
        }

        private void Gestor_Profes_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void img_agregar_Click(object sender, EventArgs e)
        {

            AgregarClientes formAgregarClientes = new AgregarClientes();
            if (formAgregarClientes.ShowDialog() == DialogResult.OK)
            {

                sistemaClientes.AgregarElemento(formAgregarClientes.Cliente);
                MessageBox.Show("Alta de cliente exitosa.", "¡Operación exitosa!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                rtb_Listado.Text += formAgregarClientes.Cliente.ToString();

            }


        }

        private void img_modificar_Click(object sender, EventArgs e)
        {
            Buscar_cliente buscarCliente = new Buscar_cliente(sistemaClientes);

            buscarCliente.ShowDialog();
            rtb_Listado.Clear();

            foreach (Clientes clientes in sistemaClientes.Lista)
            {
                rtb_Listado.Text += clientes.ToString();
            }

        }

        private void img_eliminar_Click(object sender, EventArgs e)
        {
            Buscar_cliente buscarCliente = new Buscar_cliente(sistemaClientes);

            buscarCliente.ShowDialog();
            rtb_Listado.Clear();

            foreach (Clientes clientes in sistemaClientes.Lista)
            {
                rtb_Listado.Text += clientes.ToString();
            }

        }



        private void Gestor_Profes_Load(object sender, EventArgs e)
        {
            lbl_bienvenido.Text += " " + usuario + " !";
        }

        private void img_salir_Click(object sender, EventArgs e)
        {
            string message = "¿ Desea finalizar el programa ?";
            string title = "Cerrar programa";
            DialogResult result = MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clientes cliente = new Clientes("pepe", "guerrero", "39487913", new DateTime(1996, 12, 21), "Mendoza 555", System.DateTime.Today);
            Clientes cliente2 = new Clientes("papa", "garcia", "44361856", new DateTime(1996, 11, 23), "Calzada 25", System.DateTime.Today);
            sistemaClientes.AgregarElemento(cliente);
            sistemaClientes.AgregarElemento(cliente2);
            rtb_Listado.Text += sistemaClientes.ToString();
        }

        private void rtb_Listado_TextChanged(object sender, EventArgs e)
        {

        }


        private void btn_DeserializarJSON_Click(object sender, EventArgs e)
        {
            try
            {
                SerializadoraJSON<Sistema<Clientes>> serializadoraJSONClientes = new SerializadoraJSON<Sistema<Clientes>>();
                sistemaClientes = serializadoraJSONClientes.Deserializar("Listado-Clientes");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ha ocurrido un error inesperado al intentar deserializar los archivos: {ex.Message}", "¡Atención!");
            }
        }

        private void btn_SerializarJSON_Click(object sender, EventArgs e)
        {

            if (sistemaClientes.Lista.Count > 0 && sistemaClientes.Lista.Count > 0)
            {
                SerializadoraJSON<Sistema<Clientes>> serializadoraJSONClientes = new SerializadoraJSON<Sistema<Clientes>>();
                serializadoraJSONClientes.Serializar(sistemaClientes, "Listado-Clientes");
            }
            else
            {
                MessageBox.Show("Por favor, registre al menos un cliente en el sistema.", "Error");
            }
        }

        private void btn_DeserializarXML_Click(object sender, EventArgs e)
        {

            try
            {
                SerializadoraXML<Sistema<Clientes>> serializadoraXMLClientes = new SerializadoraXML<Sistema<Clientes>>();
                sistemaClientes = serializadoraXMLClientes.Deserializar("Listado-Clientes");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ha ocurrido un error inesperado al intentar deserializar los archivos: {ex.Message}", "¡Atención!");
            }

        }

        private void btn_SerializarXML_Click(object sender, EventArgs e)
        {

            if (sistemaClientes.Lista.Count > 0 && sistemaClientes.Lista.Count > 0)
            {
                SerializadoraXML<Sistema<Clientes>> serializadoraXMLClientes = new SerializadoraXML<Sistema<Clientes>>();
                serializadoraXMLClientes.Serializar(sistemaClientes, "Listado-Clientes");
            }
            else
            {
                MessageBox.Show("Por favor, registre al menos un cliente en el sistema.", "¡Atención!");
            }
        }

    }
}
