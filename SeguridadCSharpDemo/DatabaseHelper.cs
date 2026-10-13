using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace SeguridadCSharpDemo
{
    public static class DatabaseHelper
    {
        private const string NombreBD = "SeguridadCSharpDemoDB";

        private const string ConexionMaster =
            @"Server=DESKTOP-V6IHOS5\SQLEXPRESS;
              Database=master;
              Integrated Security=True;
              TrustServerCertificate=True;";

        public static string ConexionBD =
            @"Server=DESKTOP-V6IHOS5\SQLEXPRESS;
              Database=SeguridadCSharpDemoDB;
              Integrated Security=True;
              TrustServerCertificate=True;";

        public static void InicializarBaseDatos()
        {
            CrearBaseDatos();
            CrearTablaUsuarios();
        }

        private static void CrearBaseDatos()
        {
            using (SqlConnection conexion =
                new SqlConnection(ConexionMaster))
            {
                conexion.Open();

                string sql = $@"
                    IF DB_ID(N'{NombreBD}') IS NULL
                    BEGIN
                        CREATE DATABASE [{NombreBD}]
                    END";

                using (SqlCommand comando =
                    new SqlCommand(sql, conexion))
                {
                    comando.ExecuteNonQuery();
                }
            }
        }

        private static void CrearTablaUsuarios()
        {
            using (SqlConnection conexion =
                new SqlConnection(ConexionBD))
            {
                conexion.Open();

                string sql = @"
                    IF OBJECT_ID('Usuarios', 'U') IS NULL
                    BEGIN
                        CREATE TABLE Usuarios
                        (
                            IdUsuario INT IDENTITY(1,1) PRIMARY KEY,
                            Usuario VARCHAR(50) NOT NULL UNIQUE,
                            PasswordHash VARCHAR(255) NOT NULL,
                            Activo BIT NOT NULL DEFAULT 1
                        )
                    END";

                using (SqlCommand comando =
                    new SqlCommand(sql, conexion))
                {
                    comando.ExecuteNonQuery();
                }
            }
        }
    }
}