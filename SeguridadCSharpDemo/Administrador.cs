using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeguridadCSharpDemo
{
    public class Administrador : Usuario
    {
        public Administrador(
            string nombre,
            string nombreUsuario,
            string password)
            : base(
                nombre,
                nombreUsuario,
                password,
                RolUsuario.Administrador)
        {
        }

        // El administrador sobrescribe el comportamiento protegido definido en Usuario.
        protected override bool PuedeGestionarUsuarios()
        {
            return true;
        }
    }
}