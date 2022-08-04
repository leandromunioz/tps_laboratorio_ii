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
    public partial class Login : Form
    {



        public Login()
        {
            InitializeComponent();
        }


        private void Login_Load(object sender, EventArgs e)
        {
        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txt_usuario.Text.Trim()) && string.IsNullOrEmpty(txt_pass.Text.Trim()))
            {
                errorProvider1.SetError(txt_usuario, "El campo usuario no puede estar vacío.");
                errorProvider1.SetError(txt_pass, "El campo contraseña no puede estar vacío.");

            }


            if (txt_pass.Text.ToLower() != "gimnasio22")
            {
                MessageBox.Show("Contraseña incorrecta, acceso al sistema denegado.");

            }
            else if (string.IsNullOrEmpty(txt_usuario.Text.Trim()))
            {

                MessageBox.Show("El campo usuario no puede estar vacío.");

                errorProvider1.SetError(txt_usuario, "El campo usuario no puede estar vacío.");

            }
            else
            {

                this.Hide();
                Gestor_Profes formProfes = new Gestor_Profes(txt_usuario.Text);
                formProfes.ShowDialog();


            }

        }

        private void btn_ingresar_MouseHover(object sender, EventArgs e)
        {

        }

        private void txt_pass_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (string.IsNullOrEmpty(txt_usuario.Text.Trim()) && string.IsNullOrEmpty(txt_pass.Text.Trim()))
                {
                    errorProvider1.SetError(txt_usuario, "El campo usuario no puede estar vacío.");
                    errorProvider1.SetError(txt_pass, "El campo contraseña no puede estar vacío.");
                }


                if (txt_pass.Text.ToLower() != "gimnasio22")
                {
                    MessageBox.Show("Contraseña incorrecta, acceso al sistema denegado.");
                }
                else if (string.IsNullOrEmpty(txt_usuario.Text.Trim()))
                {

                    MessageBox.Show("El campo usuario no puede estar vacío.");

                    errorProvider1.SetError(txt_usuario, "El campo usuario no puede estar vacío.");

                }
                else
                {
                    this.Hide();
                    Gestor_Profes formProfes = new Gestor_Profes(txt_usuario.Text);
                    formProfes.ShowDialog();

                }

            }




        }


    }
}
