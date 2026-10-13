
-- CONSULTAS DE PRUEBA Y VERIFICACION


-- Seleccionar la base de datos
USE SeguridadCSharpDemoDB;
GO

-- CONSULTA 1:
-- Verificar que existe la tabla Usuarios

SELECT
    TABLE_SCHEMA,
    TABLE_NAME
FROM INFORMATION_SCHEMA.TABLES
WHERE TABLE_SCHEMA = 'dbo'
AND TABLE_NAME = 'Usuarios';
GO


-- CONSULTA 2: Mostrar todos los usuarios registrados Sin mostrar los hashes de contraseñas

SELECT
    IdUsuario,
    Usuario,
    Activo
FROM dbo.Usuarios
ORDER BY IdUsuario;
GO


-- CONSULTA 3: Contar cuántos usuarios existen

SELECT
    COUNT(*) AS TotalUsuarios
FROM dbo.Usuarios;
GO

