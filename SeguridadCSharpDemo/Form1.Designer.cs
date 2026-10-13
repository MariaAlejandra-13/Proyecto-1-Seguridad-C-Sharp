namespace SeguridadCSharpDemo
{
    partial class Form1
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnEscenario2 = new System.Windows.Forms.Button();
            this.btnEscenario3 = new System.Windows.Forms.Button();
            this.btnEscenario1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblTitulo.Location = new System.Drawing.Point(230, 29);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(363, 20);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Principios de seguridad en C# y validaciones";
            // 
            // btnEscenario2
            // 
            this.btnEscenario2.BackColor = System.Drawing.SystemColors.Info;
            this.btnEscenario2.Location = new System.Drawing.Point(332, 201);
            this.btnEscenario2.Name = "btnEscenario2";
            this.btnEscenario2.Size = new System.Drawing.Size(122, 81);
            this.btnEscenario2.TabIndex = 1;
            this.btnEscenario2.Text = "Escenario 2 SQL Injection y Validación";
            this.btnEscenario2.UseVisualStyleBackColor = false;
            this.btnEscenario2.Click += new System.EventHandler(this.btnEscenario2_Click);
            // 
            // btnEscenario3
            // 
            this.btnEscenario3.BackColor = System.Drawing.SystemColors.Info;
            this.btnEscenario3.Location = new System.Drawing.Point(328, 335);
            this.btnEscenario3.Name = "btnEscenario3";
            this.btnEscenario3.Size = new System.Drawing.Size(126, 81);
            this.btnEscenario3.TabIndex = 2;
            this.btnEscenario3.Text = "Escenario 3 Mínimo Privilegio";
            this.btnEscenario3.UseVisualStyleBackColor = false;
            this.btnEscenario3.Click += new System.EventHandler(this.btnEscenario3_Click);
            // 
            // btnEscenario1
            // 
            this.btnEscenario1.BackColor = System.Drawing.SystemColors.Info;
            this.btnEscenario1.Location = new System.Drawing.Point(330, 74);
            this.btnEscenario1.Name = "btnEscenario1";
            this.btnEscenario1.Size = new System.Drawing.Size(124, 81);
            this.btnEscenario1.TabIndex = 3;
            this.btnEscenario1.Text = "Escenario 1 Contraseñas seguras";
            this.btnEscenario1.UseVisualStyleBackColor = false;
            this.btnEscenario1.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEscenario1);
            this.Controls.Add(this.btnEscenario3);
            this.Controls.Add(this.btnEscenario2);
            this.Controls.Add(this.lblTitulo);
            this.Name = "Form1";
            this.Text = "Seguridad en C# y Validaciones";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnEscenario2;
        private System.Windows.Forms.Button btnEscenario3;
        private System.Windows.Forms.Button btnEscenario1;
    }
}

