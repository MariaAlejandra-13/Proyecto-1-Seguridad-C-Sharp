using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SeguridadCSharpDemo
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Inicializa los usuarios que utilizará el Escenario 3.
            GestorUsuarios.Inicializar();

            // FORMULARIO PRINCIPAL
            Application.Run(new Form1());
        }
    }
}