
namespace Gimnasio_PAPUSA
{
    partial class AgregarClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarClientes));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_reg_nombre = new System.Windows.Forms.TextBox();
            this.txt_reg_apellido = new System.Windows.Forms.TextBox();
            this.txt_reg_dni = new System.Windows.Forms.TextBox();
            this.txt_reg_direccion = new System.Windows.Forms.TextBox();
            this.fechaNac = new System.Windows.Forms.DateTimePicker();
            this.fechaPago = new System.Windows.Forms.DateTimePicker();
            this.btn_registrar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(114, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(114, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(126, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dni";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(72, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha de nacimiento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(102, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Dirección";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(90, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Fecha de pago";
            // 
            // txt_reg_nombre
            // 
            this.txt_reg_nombre.Location = new System.Drawing.Point(13, 44);
            this.txt_reg_nombre.MaxLength = 30;
            this.txt_reg_nombre.Name = "txt_reg_nombre";
            this.txt_reg_nombre.PlaceholderText = "Ingrese nombre";
            this.txt_reg_nombre.ShortcutsEnabled = false;
            this.txt_reg_nombre.Size = new System.Drawing.Size(258, 23);
            this.txt_reg_nombre.TabIndex = 6;
            this.txt_reg_nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_reg_nombre_KeyPress);
            // 
            // txt_reg_apellido
            // 
            this.txt_reg_apellido.Location = new System.Drawing.Point(13, 88);
            this.txt_reg_apellido.MaxLength = 30;
            this.txt_reg_apellido.Name = "txt_reg_apellido";
            this.txt_reg_apellido.PlaceholderText = "Ingrese apellido";
            this.txt_reg_apellido.ShortcutsEnabled = false;
            this.txt_reg_apellido.Size = new System.Drawing.Size(258, 23);
            this.txt_reg_apellido.TabIndex = 7;
            this.txt_reg_apellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_reg_apellido_KeyPress);
            // 
            // txt_reg_dni
            // 
            this.txt_reg_dni.Location = new System.Drawing.Point(13, 132);
            this.txt_reg_dni.MaxLength = 30;
            this.txt_reg_dni.Name = "txt_reg_dni";
            this.txt_reg_dni.PlaceholderText = "Ingrese Dni";
            this.txt_reg_dni.ShortcutsEnabled = false;
            this.txt_reg_dni.Size = new System.Drawing.Size(258, 23);
            this.txt_reg_dni.TabIndex = 8;
            this.txt_reg_dni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_reg_dni_KeyPress);
            // 
            // txt_reg_direccion
            // 
            this.txt_reg_direccion.Location = new System.Drawing.Point(13, 220);
            this.txt_reg_direccion.MaxLength = 50;
            this.txt_reg_direccion.Name = "txt_reg_direccion";
            this.txt_reg_direccion.PlaceholderText = "Ingrese dirección";
            this.txt_reg_direccion.Size = new System.Drawing.Size(258, 23);
            this.txt_reg_direccion.TabIndex = 10;
            // 
            // fechaNac
            // 
            this.fechaNac.Location = new System.Drawing.Point(13, 176);
            this.fechaNac.Name = "fechaNac";
            this.fechaNac.Size = new System.Drawing.Size(258, 23);
            this.fechaNac.TabIndex = 12;
            // 
            // fechaPago
            // 
            this.fechaPago.Location = new System.Drawing.Point(13, 264);
            this.fechaPago.Name = "fechaPago";
            this.fechaPago.Size = new System.Drawing.Size(258, 23);
            this.fechaPago.TabIndex = 13;
            // 
            // btn_registrar
            // 
            this.btn_registrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_registrar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_registrar.Location = new System.Drawing.Point(13, 308);
            this.btn_registrar.Name = "btn_registrar";
            this.btn_registrar.Size = new System.Drawing.Size(108, 23);
            this.btn_registrar.TabIndex = 14;
            this.btn_registrar.Text = "Registrar cliente";
            this.btn_registrar.UseVisualStyleBackColor = false;
            this.btn_registrar.Click += new System.EventHandler(this.btn_registrar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_cancelar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_cancelar.Location = new System.Drawing.Point(163, 308);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(108, 23);
            this.btn_cancelar.TabIndex = 15;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // AgregarClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = global::Gimnasio_PAPUSA.Properties.Resources.brunch__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(285, 349);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_registrar);
            this.Controls.Add(this.fechaPago);
            this.Controls.Add(this.fechaNac);
            this.Controls.Add(this.txt_reg_direccion);
            this.Controls.Add(this.txt_reg_dni);
            this.Controls.Add(this.txt_reg_apellido);
            this.Controls.Add(this.txt_reg_nombre);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AgregarClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_reg_nombre;
        private System.Windows.Forms.TextBox txt_reg_apellido;
        private System.Windows.Forms.TextBox txt_reg_dni;
        private System.Windows.Forms.TextBox txt_reg_direccion;
        private System.Windows.Forms.DateTimePicker fechaNac;
        private System.Windows.Forms.DateTimePicker fechaPago;
        private System.Windows.Forms.Button btn_registrar;
        private System.Windows.Forms.Button btn_cancelar;
    }
}