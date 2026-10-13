using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeguridadCSharpDemo
{
    public partial class FrmRegistro : Form
    {
      
        private bool ValidarRegistro()
        {
            bool valido = true;

            errorProvider1.Clear();

            string usuario = txtUsuario.Text.Trim();
            string password = txtPassword.Text;
            string confirmar = txtConfirmarPassword.Text;

            if (string.IsNullOrWhiteSpace(usuario))
            {
                errorProvider1.SetError(
                    txtUsuario,
                    "Debe ingresar un nombre de usuario."
                );

                valido = false;
            }

            if (usuario.Length < 3)
            {
                errorProvider1.SetError(
                    txtUsuario,
                    "El usuario debe tener al menos 3 caracteres."
                );

                valido = false;
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                errorProvider1.SetError(
                    txtPassword,
                    "Debe ingresar una contraseña."
                );

                valido = false;
            }
            else if (password.Length < 8)
            {
                errorProvider1.SetError(
                    txtPassword,
                    "La contraseña debe tener al menos 8 caracteres."
                );

                valido = false;
            }

            if (password != confirmar)
            {
                errorProvider1.SetError(
                    txtConfirmarPassword,
                    "Las contraseñas no coinciden."
                );

                valido = false;
            }

            return valido;
        }
        public FrmRegistro()
        {
            InitializeComponent();
        }

        private void btnRegistrarUsuario_Click(object sender, EventArgs e)
        {
            if (!ValidarRegistro())
                return;

            string usuario = txtUsuario.Text.Trim();
            string password = txtPassword.Text;

            try
            {
                string passwordHash =
                    BCrypt.Net.BCrypt.HashPassword(password); //Aqui es donde se crea el Hash y se guarda directamente en la BD

                using (Microsoft.Data.SqlClient.SqlConnection conexion =
                    new Microsoft.Data.SqlClient.SqlConnection(
                        DatabaseHelper.ConexionBD))
                {
                    conexion.Open();

                    string sql = @"
                INSERT INTO Usuarios
                (Usuario, PasswordHash, Activo) 
                VALUES
                (@Usuario, @PasswordHash, 1)"; //Aqui se agrega en la base de datos los datos del usuario

                    using (Microsoft.Data.SqlClient.SqlCommand comando =
                        new Microsoft.Data.SqlClient.SqlCommand(
                            sql,
                            conexion))
                    {
                        comando.Parameters.Add(
                            "@Usuario",
                            System.Data.SqlDbType.VarChar,
                            50
                        ).Value = usuario;

                        comando.Parameters.Add(
                            "@PasswordHash",
                            System.Data.SqlDbType.VarChar,
                            255
                        ).Value = passwordHash;

                        comando.ExecuteNonQuery();
                    }
                }

                //Parte donde nos dice que ya se registro el usuario
                MessageBox.Show(
                    "Usuario registrado correctamente.\n\n" +
                    "La contraseña NO fue almacenada en texto plano.\n" +
                    "Se almacenó únicamente su hash BCrypt.",
                    "Registro seguro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                txtUsuario.Clear();
                txtPassword.Clear();
                txtConfirmarPassword.Clear();

                errorProvider1.Clear();

                txtUsuario.Focus();
            }
            catch (Microsoft.Data.SqlClient.SqlException ex)
            {
                if (ex.Number == 2601 || ex.Number == 2627)
                {
                    MessageBox.Show(
                        "Ese nombre de usuario ya está registrado.",
                        "Usuario duplicado",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                }
                else
                {
                    MessageBox.Show(
                        "Error de base de datos:\n" + ex.Message,
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Ocurrió un error:\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
          
            txtUsuario.Clear();
            txtPassword.Clear();
            txtConfirmarPassword.Clear();

            errorProvider1.Clear();

            txtUsuario.Focus();
        
        }
    }
}
    
   
