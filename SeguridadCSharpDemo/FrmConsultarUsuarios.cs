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
    public partial class FrmConsultarUsuarios : Form
    {
        public FrmConsultarUsuarios()
        {
            InitializeComponent();
            CargarUsuarios();
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

        private void btnActualizar_Click(
            object sender,
            EventArgs e)
        {
            CargarUsuarios();
        }

        private void btnCerrar_Click(
            object sender,
            EventArgs e)
        {
            Close();
        }
    }
}
