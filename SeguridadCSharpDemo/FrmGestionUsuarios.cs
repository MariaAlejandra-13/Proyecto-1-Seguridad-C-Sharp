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
    public partial class FrmGestionUsuarios : Form
    {
        public FrmGestionUsuarios()
        {
            InitializeComponent();

            cboRol.Items.Add(
                RolUsuario.Administrador
            );

            cboRol.Items.Add(
                RolUsuario.Empleado
            );

            cboRol.SelectedIndex = 1;

            CargarUsuarios();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            // Protección adicional: el propio formulario verifica la autorización.
            if (!SesionActual.PuedeGestionarUsuarios())
            {
                MessageBox.Show(
                    "No tiene permisos para acceder a esta ventana.",
                    "Acceso denegado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                Close();
            }
        }

        private void CargarUsuarios()
        {
            lstUsuarios.Items.Clear();

            List<Usuario> usuarios =
                GestorUsuarios.ObtenerUsuarios();

            foreach (Usuario usuario in usuarios)
            {
                lstUsuarios.Items.Add(usuario);
            }
        }

        private void btnAgregar_Click(
            object sender,
            EventArgs e)
        {
            if (!SesionActual.PuedeGestionarUsuarios())
            {
                MessageBox.Show(
                    "No tiene permisos para realizar esta operación.",
                    "Acceso denegado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            string nombre =
                txtNombre.Text.Trim();

            string nombreUsuario =
                txtUsuario.Text.Trim();

            string password =
                txtPassword.Text;

            if (string.IsNullOrWhiteSpace(nombre) ||
                string.IsNullOrWhiteSpace(nombreUsuario) ||
                string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show(
                    "Debe completar todos los campos.",
                    "Datos incompletos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            if (password.Length < 6)
            {
                MessageBox.Show(
                    "La contraseña debe tener al menos 6 caracteres.",
                    "Contraseña inválida",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtPassword.Focus();
                return;
            }

            if (GestorUsuarios.ExisteUsuario(nombreUsuario))
            {
                MessageBox.Show(
                    "Ese nombre de usuario ya existe.",
                    "Usuario duplicado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtUsuario.Focus();
                return;
            }

            if (cboRol.SelectedItem == null)
            {
                MessageBox.Show(
                    "Debe seleccionar un rol.",
                    "Rol requerido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            RolUsuario rol =
                (RolUsuario)cboRol.SelectedItem;

            Usuario nuevoUsuario;

            if (rol == RolUsuario.Administrador)
            {
                nuevoUsuario =
                    new Administrador(
                        nombre,
                        nombreUsuario,
                        password
                    );
            }
            else
            {
                nuevoUsuario =
                    new Empleado(
                        nombre,
                        nombreUsuario,
                        password
                    );
            }

            GestorUsuarios.AgregarUsuario(
                nuevoUsuario
            );

            MessageBox.Show(
                "Usuario agregado correctamente.",
                "Operación completada",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            LimpiarCampos();
            CargarUsuarios();
        }

        private void btnEliminar_Click(
            object sender,
            EventArgs e)
        {
            if (!SesionActual.PuedeGestionarUsuarios())
            {
                MessageBox.Show(
                    "No tiene permisos para realizar esta operación.",
                    "Acceso denegado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            if (lstUsuarios.SelectedItem == null)
            {
                MessageBox.Show(
                    "Seleccione un usuario de la lista.",
                    "Selección requerida",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            Usuario usuarioSeleccionado =
                (Usuario)lstUsuarios.SelectedItem;

            if (usuarioSeleccionado ==
                SesionActual.Usuario)
            {
                MessageBox.Show(
                    "No puede eliminar el usuario con el que inició sesión.",
                    "Operación no permitida",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            DialogResult respuesta =
                MessageBox.Show(
                    "¿Desea eliminar a " +
                    usuarioSeleccionado.Nombre +
                    "?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

            if (respuesta != DialogResult.Yes)
            {
                return;
            }

            bool eliminado =
                GestorUsuarios.EliminarUsuario(
                    usuarioSeleccionado
                );

            if (eliminado)
            {
                MessageBox.Show(
                    "Usuario eliminado correctamente.",
                    "Operación completada",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                CargarUsuarios();
            }
        }

        private void btnLimpiar_Click(
            object sender,
            EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtUsuario.Clear();
            txtPassword.Clear();

            cboRol.SelectedIndex = 1;

            txtNombre.Focus();
        }

        private void btnCerrar_Click(
            object sender,
            EventArgs e)
        {
            Close();
        }
    }
}
