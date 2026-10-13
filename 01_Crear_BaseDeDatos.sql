-- SCRIPT DE CREACION DE BASE DE DATOS


-- PASO 1: Seleccionar la base de datos principal
USE master;
GO

-- PASO 2: Crear la base de datos si no existe
IF DB_ID('SeguridadCSharpDemoDB') IS NULL
BEGIN
    CREATE DATABASE SeguridadCSharpDemoDB;
END;
GO

-- PASO 3: Seleccionar la base de datos del proyecto
USE SeguridadCSharpDemoDB;
GO

-- PASO 4: Crear la tabla Usuarios si no existe
IF OBJECT_ID('dbo.Usuarios', 'U') IS NULL
BEGIN
    CREATE TABLE dbo.Usuarios
    (
        IdUsuario INT IDENTITY(1,1) PRIMARY KEY,

        Usuario VARCHAR(50) NOT NULL UNIQUE,

        PasswordHash VARCHAR(255) NOT NULL,

        Activo BIT NOT NULL DEFAULT 1
    );
END;
GO

-- PASO 5: Verificar que la tabla fue creada
SELECT
    TABLE_NAME
FROM INFORMATION_SCHEMA.TABLES
WHERE TABLE_NAME = 'Usuarios';
GO

-- FIN DEL SCRIPT
