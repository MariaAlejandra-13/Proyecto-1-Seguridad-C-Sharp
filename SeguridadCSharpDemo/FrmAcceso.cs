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
    public partial class FrmAcceso : Form
    {
        public FrmAcceso()
        {
            InitializeComponent();
            GestorUsuarios.Inicializar();

            txtUsuario.Clear();
            txtPassword.Clear();
            txtUsuario.Focus();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string nombreUsuario = txtUsuario.Text.Trim();
            string password = txtPassword.Text;

            // Validación del usuario
            if (string.IsNullOrWhiteSpace(nombreUsuario))
            {
                MessageBox.Show(
                    "Debe ingresar un nombre de usuario.",
                    "Dato requerido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtUsuario.Focus();
                return;
            }

            // Validación de contraseña
            if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show(
                    "Debe ingresar una contraseña.",
                    "Dato requerido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtPassword.Focus();
                return;
            }

            // Buscar usuario
            Usuario usuario =
                GestorUsuarios.BuscarUsuario(nombreUsuario);

            if (usuario == null)
            {
                MessageBox.Show(
                    "El usuario ingresado no existe.",
                    "Acceso denegado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                txtUsuario.SelectAll();
                txtUsuario.Focus();
                return;
            }

            // Verificar contraseña
            if (!usuario.ValidarPassword(password))
            {
                MessageBox.Show(
                    "La contraseña es incorrecta.",
                    "Acceso denegado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                txtPassword.Clear();
                txtPassword.Focus();
                return;
            }

            // Crear sesión
            SesionActual.Iniciar(usuario);

            MessageBox.Show(
                "Inicio de sesión correcto.\n\n" +
                "Bienvenido, " + usuario.Nombre + ".",
                "Acceso permitido",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            // Oculta el login
            this.Hide();

            using (FrmPrincipal principal = new FrmPrincipal())
            {
                principal.ShowDialog();
            }

            // Cuando se cierre el panel principal, se finaliza la sesión.
            SesionActual.Cerrar();

            txtUsuario.Clear();
            txtPassword.Clear();

            // Mostrar nuevamente la pantalla de acceso.
            this.Show();

            txtUsuario.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Cerrando ventana...",
                "Salir",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            this.Close();
        }
    }
}