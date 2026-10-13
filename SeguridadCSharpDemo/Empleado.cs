using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeguridadCSharpDemo
{
    public class Empleado : Usuario
    {
        public Empleado(
            string nombre,
            string nombreUsuario,
            string password)
            : base(
                nombre,
                nombreUsuario,
                password,
                RolUsuario.Empleado)
        {
        }
    }
}
