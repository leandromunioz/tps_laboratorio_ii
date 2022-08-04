
namespace Gimnasio_PAPUSA
{
    partial class Gestor_Profes
    {

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
       
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gestor_Profes));
            this.img_modificar = new System.Windows.Forms.PictureBox();
            this.img_eliminar = new System.Windows.Forms.PictureBox();
            this.img_agregar = new System.Windows.Forms.PictureBox();
            this.lbl_agregar = new System.Windows.Forms.Label();
            this.lbl_modificar = new System.Windows.Forms.Label();
            this.lbl_cerrarSesion = new System.Windows.Forms.Label();
            this.rtb_Listado = new System.Windows.Forms.RichTextBox();
            this.lbl_nombreYApellido = new System.Windows.Forms.Label();
            this.lbl_fechaNacimiento = new System.Windows.Forms.Label();
            this.lbl_direccion = new System.Windows.Forms.Label();
            this.lbl_dni = new System.Windows.Forms.Label();
            this.lbl_cuotaAbonada = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_bienvenido = new System.Windows.Forms.Label();
            this.img_salir = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_SerializarJSON = new System.Windows.Forms.Button();
            this.btn_DeserializarJSON = new System.Windows.Forms.Button();
            this.btn_SerializarXML = new System.Windows.Forms.Button();
            this.btn_DeserializarXML = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.img_modificar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_eliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_agregar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_salir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // img_modificar
            // 
            this.img_modificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.img_modificar.Image = ((System.Drawing.Image)(resources.GetObject("img_modificar.Image")));
            this.img_modificar.Location = new System.Drawing.Point(676, 0);
            this.img_modificar.Name = "img_modificar";
            this.img_modificar.Size = new System.Drawing.Size(79, 40);
            this.img_modificar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_modificar.TabIndex = 0;
            this.img_modificar.TabStop = false;
            this.img_modificar.Click += new System.EventHandler(this.img_modificar_Click);
            // 
            // img_eliminar
            // 
            this.img_eliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.img_eliminar.Image = ((System.Drawing.Image)(resources.GetObject("img_eliminar.Image")));
            this.img_eliminar.Location = new System.Drawing.Point(671, 123);
            this.img_eliminar.Name = "img_eliminar";
            this.img_eliminar.Size = new System.Drawing.Size(84, 40);
            this.img_eliminar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_eliminar.TabIndex = 1;
            this.img_eliminar.TabStop = false;
            // 
            // img_agregar
            // 
            this.img_agregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.img_agregar.Image = ((System.Drawing.Image)(resources.GetObject("img_agregar.Image")));
            this.img_agregar.Location = new System.Drawing.Point(581, 1);
            this.img_agregar.Name = "img_agregar";
            this.img_agregar.Size = new System.Drawing.Size(78, 42);
            this.img_agregar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_agregar.TabIndex = 2;
            this.img_agregar.TabStop = false;
            this.img_agregar.Click += new System.EventHandler(this.img_agregar_Click);
            // 
            // lbl_agregar
            // 
            this.lbl_agregar.AutoSize = true;
            this.lbl_agregar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_agregar.Location = new System.Drawing.Point(593, 42);
            this.lbl_agregar.Name = "lbl_agregar";
            this.lbl_agregar.Size = new System.Drawing.Size(56, 14);
            this.lbl_agregar.TabIndex = 4;
            this.lbl_agregar.Text = "Agregar";
            // 
            // lbl_modificar
            // 
            this.lbl_modificar.AutoSize = true;
            this.lbl_modificar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_modificar.Location = new System.Drawing.Point(671, 41);
            this.lbl_modificar.Name = "lbl_modificar";
            this.lbl_modificar.Size = new System.Drawing.Size(90, 14);
            this.lbl_modificar.TabIndex = 5;
            this.lbl_modificar.Text = "Buscar cliente";
            // 
            // lbl_cerrarSesion
            // 
            this.lbl_cerrarSesion.AutoSize = true;
            this.lbl_cerrarSesion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_cerrarSesion.Location = new System.Drawing.Point(767, 42);
            this.lbl_cerrarSesion.Name = "lbl_cerrarSesion";
            this.lbl_cerrarSesion.Size = new System.Drawing.Size(86, 14);
            this.lbl_cerrarSesion.TabIndex = 7;
            this.lbl_cerrarSesion.Text = "Cerrar sesión";
            // 
            // rtb_Listado
            // 
            this.rtb_Listado.BackColor = System.Drawing.Color.Gainsboro;
            this.rtb_Listado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rtb_Listado.Location = new System.Drawing.Point(2, 60);
            this.rtb_Listado.Name = "rtb_Listado";
            this.rtb_Listado.Size = new System.Drawing.Size(585, 424);
            this.rtb_Listado.TabIndex = 8;
            this.rtb_Listado.Text = "";
            this.rtb_Listado.TextChanged += new System.EventHandler(this.rtb_Listado_TextChanged);
            // 
            // lbl_nombreYApellido
            // 
            this.lbl_nombreYApellido.AutoSize = true;
            this.lbl_nombreYApellido.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_nombreYApellido.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.lbl_nombreYApellido.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lbl_nombreYApellido.Location = new System.Drawing.Point(2, 41);
            this.lbl_nombreYApellido.Name = "lbl_nombreYApellido";
            this.lbl_nombreYApellido.Size = new System.Drawing.Size(124, 15);
            this.lbl_nombreYApellido.TabIndex = 10;
            this.lbl_nombreYApellido.Text = "Nombre y apellido";
            // 
            // lbl_fechaNacimiento
            // 
            this.lbl_fechaNacimiento.AutoSize = true;
            this.lbl_fechaNacimiento.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.lbl_fechaNacimiento.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lbl_fechaNacimiento.Location = new System.Drawing.Point(225, 41);
            this.lbl_fechaNacimiento.Name = "lbl_fechaNacimiento";
            this.lbl_fechaNacimiento.Size = new System.Drawing.Size(123, 15);
            this.lbl_fechaNacimiento.TabIndex = 11;
            this.lbl_fechaNacimiento.Text = "Fecha nacimiento";
            // 
            // lbl_direccion
            // 
            this.lbl_direccion.AutoSize = true;
            this.lbl_direccion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.lbl_direccion.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lbl_direccion.Location = new System.Drawing.Point(367, 41);
            this.lbl_direccion.Name = "lbl_direccion";
            this.lbl_direccion.Size = new System.Drawing.Size(71, 15);
            this.lbl_direccion.TabIndex = 12;
            this.lbl_direccion.Text = "Dirección";
            // 
            // lbl_dni
            // 
            this.lbl_dni.AutoSize = true;
            this.lbl_dni.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_dni.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.lbl_dni.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lbl_dni.Location = new System.Drawing.Point(166, 41);
            this.lbl_dni.Name = "lbl_dni";
            this.lbl_dni.Size = new System.Drawing.Size(31, 15);
            this.lbl_dni.TabIndex = 13;
            this.lbl_dni.Text = "DNI";
            // 
            // lbl_cuotaAbonada
            // 
            this.lbl_cuotaAbonada.AutoSize = true;
            this.lbl_cuotaAbonada.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.lbl_cuotaAbonada.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lbl_cuotaAbonada.Location = new System.Drawing.Point(458, 41);
            this.lbl_cuotaAbonada.Name = "lbl_cuotaAbonada";
            this.lbl_cuotaAbonada.Size = new System.Drawing.Size(105, 15);
            this.lbl_cuotaAbonada.TabIndex = 14;
            this.lbl_cuotaAbonada.Text = "Cuota abonada";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(723, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 14);
            this.label6.TabIndex = 15;
            // 
            // lbl_bienvenido
            // 
            this.lbl_bienvenido.AutoSize = true;
            this.lbl_bienvenido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl_bienvenido.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lbl_bienvenido.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_bienvenido.Location = new System.Drawing.Point(2, 9);
            this.lbl_bienvenido.Name = "lbl_bienvenido";
            this.lbl_bienvenido.Size = new System.Drawing.Size(82, 15);
            this.lbl_bienvenido.TabIndex = 16;
            this.lbl_bienvenido.Text = "Bienvenido ";
            // 
            // img_salir
            // 
            this.img_salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.img_salir.Image = ((System.Drawing.Image)(resources.GetObject("img_salir.Image")));
            this.img_salir.Location = new System.Drawing.Point(767, 1);
            this.img_salir.Name = "img_salir";
            this.img_salir.Size = new System.Drawing.Size(86, 40);
            this.img_salir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_salir.TabIndex = 17;
            this.img_salir.TabStop = false;
            this.img_salir.Click += new System.EventHandler(this.img_salir_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(593, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(252, 424);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // btn_SerializarJSON
            // 
            this.btn_SerializarJSON.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_SerializarJSON.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_SerializarJSON.Location = new System.Drawing.Point(593, 514);
            this.btn_SerializarJSON.Name = "btn_SerializarJSON";
            this.btn_SerializarJSON.Size = new System.Drawing.Size(124, 31);
            this.btn_SerializarJSON.TabIndex = 20;
            this.btn_SerializarJSON.Text = "Serializar JSON";
            this.btn_SerializarJSON.UseVisualStyleBackColor = false;
            this.btn_SerializarJSON.Click += new System.EventHandler(this.btn_SerializarJSON_Click);
            // 
            // btn_DeserializarJSON
            // 
            this.btn_DeserializarJSON.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_DeserializarJSON.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_DeserializarJSON.Location = new System.Drawing.Point(723, 514);
            this.btn_DeserializarJSON.Name = "btn_DeserializarJSON";
            this.btn_DeserializarJSON.Size = new System.Drawing.Size(124, 31);
            this.btn_DeserializarJSON.TabIndex = 21;
            this.btn_DeserializarJSON.Text = "Deserializar JSON";
            this.btn_DeserializarJSON.UseVisualStyleBackColor = false;
            this.btn_DeserializarJSON.Click += new System.EventHandler(this.btn_DeserializarJSON_Click);
            // 
            // btn_SerializarXML
            // 
            this.btn_SerializarXML.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_SerializarXML.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_SerializarXML.Location = new System.Drawing.Point(12, 514);
            this.btn_SerializarXML.Name = "btn_SerializarXML";
            this.btn_SerializarXML.Size = new System.Drawing.Size(124, 31);
            this.btn_SerializarXML.TabIndex = 22;
            this.btn_SerializarXML.Text = "Serializar XML";
            this.btn_SerializarXML.UseVisualStyleBackColor = false;
            this.btn_SerializarXML.Click += new System.EventHandler(this.btn_SerializarXML_Click);
            // 
            // btn_DeserializarXML
            // 
            this.btn_DeserializarXML.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_DeserializarXML.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_DeserializarXML.Location = new System.Drawing.Point(142, 514);
            this.btn_DeserializarXML.Name = "btn_DeserializarXML";
            this.btn_DeserializarXML.Size = new System.Drawing.Size(124, 31);
            this.btn_DeserializarXML.TabIndex = 23;
            this.btn_DeserializarXML.Text = "Deserializar XML";
            this.btn_DeserializarXML.UseVisualStyleBackColor = false;
            this.btn_DeserializarXML.Click += new System.EventHandler(this.btn_DeserializarXML_Click);
            // 
            // Gestor_Profes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(857, 557);
            this.Controls.Add(this.btn_DeserializarXML);
            this.Controls.Add(this.btn_SerializarXML);
            this.Controls.Add(this.btn_DeserializarJSON);
            this.Controls.Add(this.btn_SerializarJSON);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.img_salir);
            this.Controls.Add(this.lbl_bienvenido);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbl_cuotaAbonada);
            this.Controls.Add(this.lbl_dni);
            this.Controls.Add(this.lbl_direccion);
            this.Controls.Add(this.lbl_fechaNacimiento);
            this.Controls.Add(this.lbl_nombreYApellido);
            this.Controls.Add(this.rtb_Listado);
            this.Controls.Add(this.lbl_cerrarSesion);
            this.Controls.Add(this.lbl_modificar);
            this.Controls.Add(this.lbl_agregar);
            this.Controls.Add(this.img_agregar);
            this.Controls.Add(this.img_eliminar);
            this.Controls.Add(this.img_modificar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Gestor_Profes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestor de clientes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Gestor_Profes_FormClosing);
            this.Load += new System.EventHandler(this.Gestor_Profes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.img_modificar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_eliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_agregar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_salir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox img_modificar;
        private System.Windows.Forms.PictureBox img_eliminar;
        private System.Windows.Forms.PictureBox img_agregar;
        private System.Windows.Forms.Label lbl_agregar;
        private System.Windows.Forms.Label lbl_modificar;
        private System.Windows.Forms.Label lbl_cerrarSesion;
        private System.Windows.Forms.RichTextBox rtb_Listado;
        private System.Windows.Forms.Label lbl_nombreYApellido;
        private System.Windows.Forms.Label lbl_fechaNacimiento;
        private System.Windows.Forms.Label lbl_direccion;
        private System.Windows.Forms.Label lbl_dni;
        private System.Windows.Forms.Label lbl_cuotaAbonada;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_bienvenido;
        private System.Windows.Forms.PictureBox img_salir;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_SerializarJSON;
        private System.Windows.Forms.Button btn_DeserializarJSON;
        private System.Windows.Forms.Button btn_SerializarXML;
        private System.Windows.Forms.Button btn_DeserializarXML;
    }
}