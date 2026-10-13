using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeguridadCSharpDemo
{
    public class Usuario
    {
        // Se pueden consultar desde otras clases, pero solo esta clase o sus derivadas pueden modificarlas.
        public string Nombre { get; private set; }

        public string NombreUsuario { get; private set; }

        public RolUsuario Rol { get; protected set; }

        // PRIVATE: ninguna clase externa puede acceder directamente a la contraseña.
        private string _password;

        public Usuario(
            string nombre,
            string nombreUsuario,
            string password,
            RolUsuario rol)
        {
            Nombre = nombre;
            NombreUsuario = nombreUsuario;
            _password = password;
            Rol = rol;
        }

        // La contraseña no se entrega al exterior. Solamente exponemos la operación necesaria.
        public bool ValidarPassword(string password)
        {
            return _password == password;
        }

        // PROTECTED: Puede utilizarlo esta clase y sus clases derivadas.
        protected virtual bool PuedeGestionarUsuarios()
        {
            return false;
        }

        // Método público controlado para consultar el permiso.
        public bool TienePermisoGestionUsuarios()
        {
            return PuedeGestionarUsuarios();
        }
        public override string ToString()
        {
            return Nombre + " | " +
                   NombreUsuario + " | " +
                   Rol.ToString();
        }
    }
}
