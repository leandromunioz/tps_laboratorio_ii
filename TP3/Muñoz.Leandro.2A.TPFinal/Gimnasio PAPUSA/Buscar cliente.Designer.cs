
namespace Gimnasio_PAPUSA
{
    partial class Buscar_cliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Buscar_cliente));
            this.lbl_buscar_dni = new System.Windows.Forms.Label();
            this.txt_buscar_dni = new System.Windows.Forms.TextBox();
            this.btn_buscar_dni = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_buscar_dni
            // 
            this.lbl_buscar_dni.AutoSize = true;
            this.lbl_buscar_dni.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.lbl_buscar_dni.Location = new System.Drawing.Point(26, 35);
            this.lbl_buscar_dni.Name = "lbl_buscar_dni";
            this.lbl_buscar_dni.Size = new System.Drawing.Size(170, 15);
            this.lbl_buscar_dni.TabIndex = 0;
            this.lbl_buscar_dni.Text = "Ingrese el Dni del cliente ";
            // 
            // txt_buscar_dni
            // 
            this.txt_buscar_dni.BackColor = System.Drawing.Color.Silver;
            this.txt_buscar_dni.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_buscar_dni.Location = new System.Drawing.Point(26, 62);
            this.txt_buscar_dni.MaxLength = 8;
            this.txt_buscar_dni.Name = "txt_buscar_dni";
            this.txt_buscar_dni.PlaceholderText = "Ingrese Dni";
            this.txt_buscar_dni.Size = new System.Drawing.Size(234, 21);
            this.txt_buscar_dni.TabIndex = 1;
            this.txt_buscar_dni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_buscar_dni_KeyPress);
            // 
            // btn_buscar_dni
            // 
            this.btn_buscar_dni.BackColor = System.Drawing.Color.Silver;
            this.btn_buscar_dni.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_buscar_dni.Location = new System.Drawing.Point(266, 56);
            this.btn_buscar_dni.Name = "btn_buscar_dni";
            this.btn_buscar_dni.Size = new System.Drawing.Size(87, 30);
            this.btn_buscar_dni.TabIndex = 2;
            this.btn_buscar_dni.Text = "Buscar";
            this.btn_buscar_dni.UseVisualStyleBackColor = false;
            this.btn_buscar_dni.Click += new System.EventHandler(this.btn_buscar_dni_Click);
            // 
            // Buscar_cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(376, 120);
            this.Controls.Add(this.btn_buscar_dni);
            this.Controls.Add(this.txt_buscar_dni);
            this.Controls.Add(this.lbl_buscar_dni);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Buscar_cliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar cliente";
            this.Load += new System.EventHandler(this.Buscar_cliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_buscar_dni;
        private System.Windows.Forms.TextBox txt_buscar_dni;
        private System.Windows.Forms.Button btn_buscar_dni;
    }
}