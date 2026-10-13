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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            CargarSesion();
        }

        private void CargarSesion()
        {
            if (!SesionActual.HaySesion)
            {
                MessageBox.Show(
                    "No existe una sesión activa.",
                    "Acceso denegado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                Close();
                return;
            }

            lblBienvenida.Text =
                "Bienvenido: " +
                SesionActual.Usuario.Nombre;

            lblRol.Text =
                "Rol: " +
                SesionActual.Usuario.Rol.ToString();

            // Primera capa del principio de mínimo privilegio: un empleado ni siquiera ve la opción administrativa.
            btnGestionar.Visible =
                SesionActual.PuedeGestionarUsuarios();
        }

        private void btnConsultar_Click(
            object sender,
            EventArgs e)
        {
            using (FrmConsultarUsuarios formulario =
                new FrmConsultarUsuarios())
            {
                formulario.ShowDialog();
            }
        }

        private void btnGestionar_Click(
            object sender,
            EventArgs e)
        {
            
            if (!SesionActual.PuedeGestionarUsuarios())
            {
                MessageBox.Show(
                    "No tiene permisos para acceder a esta función.",
                    "Acceso denegado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            using (FrmGestionUsuarios formulario =
                new FrmGestionUsuarios())
            {
                formulario.ShowDialog();
            }
        }

        private void btnCerrarSesion_Click(
            object sender,
            EventArgs e)
        {
            DialogResult respuesta =
                MessageBox.Show(
                    "¿Desea cerrar la sesión actual?",
                    "Cerrar sesión",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

            if (respuesta == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btnSalir_Click(
            object sender,
            EventArgs e)
        {
            MessageBox.Show(
                "Cerrando aplicación...",
                "Salir",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            Application.Exit();
        }
    }
}