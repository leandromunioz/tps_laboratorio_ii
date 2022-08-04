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
        public delegate void ClienteAgregado();
        public event ClienteAgregado ClienteAgregadoExitosamente;

        private Gestor_Profes()
        {
            InitializeComponent();
            sistemaClientes = new Sistema<Clientes>();
            ClienteAgregadoExitosamente += InformarAltaCliente;
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
            Task tarea = new Task(() => formAgregarClientes.ShowDialog());
            tarea.Start();
            Task.WaitAll(tarea);

            if (formAgregarClientes.DialogResult == DialogResult.OK)
            {
                sistemaClientes.AgregarElemento(formAgregarClientes.Cliente);
                ClienteAgregadoExitosamente.Invoke();
            }
        }

        private void img_modificar_Click(object sender, EventArgs e)
        {
            Buscar_cliente buscarCliente = new Buscar_cliente(sistemaClientes);
            Task tarea = new Task(() => buscarCliente.ShowDialog());
            tarea.Start();
            Task.WaitAll(tarea);

            Refrescar();
            
        }

        //private void img_eliminar_Click(object sender, EventArgs e)
        //{
        //    Buscar_cliente buscarCliente = new Buscar_cliente(sistemaClientes);
        //    Task tarea = new Task(() => buscarCliente.ShowDialog());
        //    tarea.Start();
        //    Task.WaitAll(tarea);
    
        //    Refrescar();
                
            
            
        //}



        private void Gestor_Profes_Load(object sender, EventArgs e)
        {
            lbl_bienvenido.Text += " " + usuario + " !";

            Clientes cliente = new Clientes("pepe", "guerrero", "39487913", new DateTime(1996, 12, 21), "Mendoza 555", System.DateTime.Today);
            Clientes cliente2 = new Clientes("papa", "garcia", "44361856", new DateTime(2002, 11, 23), "Calzada 25", System.DateTime.Today);
            sistemaClientes.AgregarElemento(cliente);
            sistemaClientes.AgregarElemento(cliente2);
            rtb_Listado.Text += sistemaClientes.ToString();

            sistemaClientes = ClientesDB.Leer();
            Refrescar();
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

     

        private void rtb_Listado_TextChanged(object sender, EventArgs e)
        {
            Refrescar();
        }


        private void btn_DeserializarJSON_Click(object sender, EventArgs e)
        {
            try
            {
                SerializadoraJSON<Sistema<Clientes>> serializadoraJSONClientes = new SerializadoraJSON<Sistema<Clientes>>();
                sistemaClientes = serializadoraJSONClientes.Deserializar("Listado-Clientes");
                MessageBox.Show("Deserialización exitosa.");
                Refrescar();

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
                MessageBox.Show("Serialización exitosa.");

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
                MessageBox.Show("Deserialización exitosa.");
                Refrescar();


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
                MessageBox.Show("Serialización exitosa.");

            }
            else
            {
                MessageBox.Show("Por favor, registre al menos un cliente en el sistema.", "¡Atención!");
            }
        }


        private void Refrescar()
        {
            rtb_Listado.Clear();

            rtb_Listado.Text += sistemaClientes.ToString();

        }

    

        private void InformarAltaCliente()
        {
            MessageBox.Show("Alta de cliente exitosa.", "¡Operación exitosa!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            Refrescar();
        }
    }
}
