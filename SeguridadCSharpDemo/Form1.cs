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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            FrmRegistro formulario = new FrmRegistro();
            formulario.ShowDialog();
        }

        private void btnEscenario2_Click(object sender, EventArgs e)
        {
            
            FrmConsulta formulario = new FrmConsulta();
            formulario.ShowDialog();
        }

        private void btnEscenario3_Click(object sender, EventArgs e)
        {
            FrmAcceso formulario = new FrmAcceso();
            formulario.ShowDialog();
        }
    }
    
}
