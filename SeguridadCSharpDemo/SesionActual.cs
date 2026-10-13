using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeguridadCSharpDemo
{
    internal static class SesionActual
    {
        public static Usuario Usuario { get; private set; }

        public static bool HaySesion
        {
            get
            {
                return Usuario != null;
            }
        }

        public static void Iniciar(Usuario usuario)
        {
            Usuario = usuario;
        }

        public static void Cerrar()
        {
            Usuario = null;
        }

        public static bool PuedeGestionarUsuarios()
        {
            if (Usuario == null)
            {
                return false;
            }

            return Usuario.TienePermisoGestionUsuarios();
        }
    }
}