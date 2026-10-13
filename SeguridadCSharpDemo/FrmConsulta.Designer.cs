namespace SeguridadCSharpDemo
{
    partial class FrmConsulta
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
            this.components = new System.ComponentModel.Container();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtUsuarioBuscar = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblTexto = new System.Windows.Forms.Label();
            this.lblNuevo = new System.Windows.Forms.Label();
            this.btnLimpiar2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(47, 79);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(72, 20);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuario: ";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(165, 363);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(93, 41);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtUsuarioBuscar
            // 
            this.txtUsuarioBuscar.Location = new System.Drawing.Point(187, 73);
            this.txtUsuarioBuscar.Name = "txtUsuarioBuscar";
            this.txtUsuarioBuscar.Size = new System.Drawing.Size(100, 26);
            this.txtUsuarioBuscar.TabIndex = 2;
            this.txtUsuarioBuscar.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(183, 162);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 20);
            this.lblResultado.TabIndex = 3;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lblTexto
            // 
            this.lblTexto.AutoSize = true;
            this.lblTexto.Location = new System.Drawing.Point(501, 41);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(258, 100);
            this.lblTexto.TabIndex = 4;
            this.lblTexto.Text = "Consulta utilizada:\n\nSELECT IdUsuario, Usuario, Activo\nFROM Usuarios\nWHERE Usuari" +
    "o = @Usuario";
            this.lblTexto.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblNuevo
            // 
            this.lblNuevo.AutoSize = true;
            this.lblNuevo.Location = new System.Drawing.Point(47, 162);
            this.lblNuevo.Name = "lblNuevo";
            this.lblNuevo.Size = new System.Drawing.Size(86, 20);
            this.lblNuevo.TabIndex = 5;
            this.lblNuevo.Text = "Resultado:";
            // 
            // btnLimpiar2
            // 
            this.btnLimpiar2.Location = new System.Drawing.Point(319, 363);
            this.btnLimpiar2.Name = "btnLimpiar2";
            this.btnLimpiar2.Size = new System.Drawing.Size(93, 41);
            this.btnLimpiar2.TabIndex = 6;
            this.btnLimpiar2.Text = "Limpiar";
            this.btnLimpiar2.UseVisualStyleBackColor = true;
            // 
            // FrmConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLimpiar2);
            this.Controls.Add(this.lblNuevo);
            this.Controls.Add(this.lblTexto);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.txtUsuarioBuscar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblUsuario);
            this.Name = "FrmConsulta";
            this.Text = "Escenario 2 - SQL Injection";
            this.Load += new System.EventHandler(this.FrmConsulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtUsuarioBuscar;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblTexto;
        private System.Windows.Forms.Label lblNuevo;
        private System.Windows.Forms.Button btnLimpiar2;
    }
}