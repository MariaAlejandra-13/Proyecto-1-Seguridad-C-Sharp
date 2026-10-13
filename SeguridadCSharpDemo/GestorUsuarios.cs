using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeguridadCSharpDemo
{
    internal static class GestorUsuarios
    {
        private static readonly List<Usuario> _usuarios =
            new List<Usuario>();

        public static void Inicializar()
        {
            // Evita crear los usuarios varias veces
            if (_usuarios.Count > 0)
            {
                return;
            }

            // ADMINISTRADOR
            _usuarios.Add(
                new Administrador(
                    "Administrador Principal",
                    "admin",
                    "Admin123"
                )
            );

            // EMPLEADO
            _usuarios.Add(
                new Empleado(
                    "Empleado de Prueba",
                    "empleado",
                    "Empleado123"
                )
            );
        }

        public static Usuario BuscarUsuario(string nombreUsuario)
        {
            if (string.IsNullOrWhiteSpace(nombreUsuario))
            {
                return null;
            }

            foreach (Usuario usuario in _usuarios)
            {
                if (string.Equals(
                    usuario.NombreUsuario,
                    nombreUsuario.Trim(),
                    StringComparison.OrdinalIgnoreCase))
                {
                    return usuario;
                }
            }

            return null;
        }

        public static bool ExisteUsuario(string nombreUsuario)
        {
            return BuscarUsuario(nombreUsuario) != null;
        }

        public static List<Usuario> ObtenerUsuarios()
        {
            // Entregamos una copia de la lista, no la lista interna original.
            return new List<Usuario>(_usuarios);
        }

        public static void AgregarUsuario(Usuario usuario)
        {
            if (usuario != null)
            {
                _usuarios.Add(usuario);
            }
        }

        public static bool EliminarUsuario(Usuario usuario)
        {
            if (usuario == null)
            {
                return false;
            }

            return _usuarios.Remove(usuario);
        }
    }
}