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
    public partial class FrmConsulta : Form
    {
        public FrmConsulta()
        {
            InitializeComponent();
        }

        private bool ValidarUsuario()
        {
            errorProvider1.Clear();

            string usuario =
                txtUsuarioBuscar.Text.Trim();

            if (string.IsNullOrWhiteSpace(usuario))
            {
                errorProvider1.SetError(
                    txtUsuarioBuscar,
                    "Debe escribir un usuario."
                );

                return false;
            }

            if (usuario.Length > 50)
            {
                errorProvider1.SetError(
                    txtUsuarioBuscar,
                    "El usuario no puede superar los 50 caracteres."
                );

                return false;
            }

            return true;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmConsulta_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (!ValidarUsuario())
                return;

            string usuario = txtUsuarioBuscar.Text.Trim();

            string consulta = @"
            SELECT IdUsuario, Usuario, Activo
            FROM Usuarios
            WHERE Usuario = @Usuario";

            try
            {
                using (Microsoft.Data.SqlClient.SqlConnection conexion = new Microsoft.Data.SqlClient.SqlConnection(DatabaseHelper.ConexionBD))
                {
                    using (Microsoft.Data.SqlClient.SqlCommand comando =
                        new Microsoft.Data.SqlClient.SqlCommand(
                            consulta,
                            conexion))
                    {
                        comando.Parameters.Add(
                            "@Usuario",
                            System.Data.SqlDbType.VarChar,
                            50
                        ).Value = usuario;

                        conexion.Open();

                        using (Microsoft.Data.SqlClient.SqlDataReader lector =
                            comando.ExecuteReader())
                        {
                            if (lector.Read())
                            {
                                int id =
                                    Convert.ToInt32(
                                        lector["IdUsuario"]
                                    );

                                string nombre =
                                    lector["Usuario"].ToString();

                                bool activo =
                                    Convert.ToBoolean(
                                        lector["Activo"]
                                    );

                                lblResultado.Text =
                                    "USUARIO ENCONTRADO\r\n\r\n" +
                                    "ID: " + id + "\r\n" +
                                    "Usuario: " + nombre + "\r\n" +
                                    "Activo: " + activo;
                            }
                            else
                            {
                                lblResultado.Text =
                                    "Usuario no encontrado.";
                            }
                        }
                    }
                }
            }
            catch (Microsoft.Data.SqlClient.SqlException ex)
            {
                MessageBox.Show(
                    "No fue posible realizar la consulta.\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Ocurrió un error:\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
             }
        }
    }
    
}
