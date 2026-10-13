# Universidad Tecnológica de Panamá
# Facultad de Ingeniería de Sistemas Computacionales

## Proyecto de Investigación - Seguridad y Validaciones en C#
### Herramientas de Programación Aplicada III

**Estudiantes:** Maria Townshend, Joseph Pineda, Romel Rodríguez
**Profesora:** Irina Fong 
**Grupo:** 1IL123 
**Fecha de presentación:** 13/10/2026

---

## Objetivos

### Objetivo general

Desarrollar una aplicación en C# utilizando Windows Forms que permita demostrar diferentes mecanismos de seguridad, validación de datos y control de acceso, mediante tres escenarios prácticos que integran los conceptos investigados.

### Objetivos específicos

- Implementar mecanismos de protección de contraseñas mediante hashing.
- Aplicar validaciones para controlar los datos ingresados por el usuario.
- Utilizar consultas parametrizadas para reducir el riesgo de inyección SQL.
- Implementar controles de acceso mediante roles de Administrador y Empleado.
- Aplicar los modificadores `public`, `private`, `protected` e `internal`.
- Relacionar las prácticas implementadas con la seguridad y calidad del software.

---

## Introducción

En el desarrollo de software, la seguridad es un aspecto fundamental para proteger la información, evitar operaciones no autorizadas y garantizar un funcionamiento adecuado de las aplicaciones.

Este proyecto consiste en una aplicación desarrollada en C# con Windows Forms, organizada en tres escenarios prácticos que permiten comprender diferentes conceptos relacionados con la seguridad.

El primer escenario trabaja con el registro de usuarios y la protección de contraseñas. El segundo se enfoca en la validación de entradas, el manejo de errores y las consultas parametrizadas. Finalmente, el tercer escenario demuestra el control de acceso mediante roles y la aplicación del principio de mínimo privilegio.

El objetivo es observar cómo estos mecanismos funcionan dentro de una aplicación real y comprender su importancia durante el desarrollo de software.

---

## Requisitos previos

### Tecnologías utilizadas

- Visual Studio Community.
- Lenguaje C#.
- Windows Forms.
- .NET.
- SQL Server.
- SQL Server Management Studio (SSMS).
- Microsoft.Data.SqlClient.
- NuGet: BCrypt.Net-Next.

### Sistema operativo

- Windows.

### Configuración

Para ejecutar correctamente el proyecto se necesita:

1. Tener instalado Visual Studio Community con las herramientas de desarrollo de escritorio con .NET.
2. Contar con SQL Server disponible para los escenarios que utilizan base de datos.
3. Verificar la configuración de conexión a SQL Server.
4. Restaurar los paquetes necesarios mediante NuGet.
5. Compilar y ejecutar el proyecto.

---

## Contenido del repositorio

El proyecto está organizado mediante un menú principal que permite acceder a tres escenarios independientes.

| Escenario | Tema principal |
|---|---|
| Escenario 1 | Registro de usuarios y protección de contraseñas |
| Escenario 2 | Validaciones, consultas parametrizadas y SQL Injection |
| Escenario 3 | Control de acceso por roles y mínimo privilegio |

### Menú principal

Al ejecutar la aplicación se presenta una ventana con tres botones. Cada botón permite abrir el escenario correspondiente.

Esto facilita realizar las demostraciones de forma independiente desde una misma aplicación.

**Captura del menú principal:**

<img width="396" height="239" alt="image" src="https://github.com/user-attachments/assets/31532fd7-ca39-4cce-84e7-e9d6df095df0" />


---

# Escenario #1 - Registro de Usuarios y Protección de Contraseñas

## Descripción

En este escenario se desarrolla un formulario de registro de usuarios que incorpora validaciones y protección de contraseñas mediante BCrypt.

La finalidad es demostrar que no basta con solicitar una contraseña y almacenarla directamente, sino que es necesario aplicar mecanismos que reduzcan la exposición de información sensible.

### Controles utilizados

- `Label`: identifica los campos del formulario.
- `TextBox`: permite ingresar los datos.
- `Button`: ejecuta el proceso de registro.
- `ErrorProvider`: muestra errores de validación.
- `MessageBox`: presenta mensajes sobre el resultado de las operaciones.

### Elementos de C# utilizados

- Variables y cadenas de texto.
- Condicionales `if` y `else`.
- Métodos.
- Eventos de botones.
- Validación de entradas.
- Manejo de excepciones.
- BCrypt para hashing de contraseñas.
- Conexión con SQL Server.

## Funcionamiento

### 1. Ingreso de información

El usuario introduce los datos solicitados en el formulario, incluyendo el nombre de usuario y la contraseña.

### 2. Validación

Antes de registrar la información, el programa verifica que los datos cumplan las condiciones establecidas.

Cuando existe un error, se muestra un mensaje para indicar qué debe corregirse.

### 3. Protección de contraseña

Cuando la información es válida, se utiliza BCrypt para generar un hash de la contraseña.

El objetivo es evitar almacenar directamente la contraseña original.

### 4. Almacenamiento

La información del usuario se registra en SQL Server mediante las operaciones implementadas en el proyecto.

### 5. Resultado

El sistema informa si el registro se realizó correctamente o si ocurrió algún problema.

## Resultado - Escenario #1

Se logró implementar un formulario de registro que combina validación de datos, manejo de errores y protección de contraseñas.

Este escenario permitió comprender la diferencia entre ocultar visualmente una contraseña y proteger su almacenamiento mediante hashing.

### Evidencias

**Captura 1. Formulario de registro**

<img width="397" height="239" alt="image" src="https://github.com/user-attachments/assets/4f40b7de-3563-41a6-b702-a70c6178a371" />

**Captura 2. Validaciones**

<img width="399" height="236" alt="image" src="https://github.com/user-attachments/assets/cd5bac6d-0cf9-40ed-b461-32d21a55f03e" />
<img width="393" height="238" alt="image" src="https://github.com/user-attachments/assets/5d15b39e-bffb-43f9-86dc-a1ec6fed9968" />
<img width="398" height="238" alt="image" src="https://github.com/user-attachments/assets/5bb41c7d-76bc-4129-93b8-cd7677fa6d38" />
<img width="400" height="239" alt="image" src="https://github.com/user-attachments/assets/014e7723-895b-4271-8362-9a754ebb72b4" />

**Captura 3. Registro exitoso**

<img width="395" height="235" alt="image" src="https://github.com/user-attachments/assets/dd4662aa-74e4-4483-9c7e-87453028dd52" />


**Captura 4. Información almacenada**

<img width="388" height="171" alt="image" src="https://github.com/user-attachments/assets/27805c3b-25ca-450d-a4c2-2453d7b7c950" />

---

# Escenario #2 - Validación de Entradas y Consultas Parametrizadas

## Descripción

En este escenario se trabajan mecanismos de validación y consultas a una base de datos SQL Server.

El propósito es demostrar cómo se pueden controlar los datos proporcionados por el usuario y evitar que las entradas alteren las instrucciones SQL.

También se utiliza el manejo de errores para responder adecuadamente ante información incorrecta o situaciones inesperadas.

### Controles utilizados

- `Label`.
- `TextBox`.
- `Button`.
- `ErrorProvider`.
- `MessageBox`.

### Elementos de C# utilizados

- Condicionales.
- Métodos y eventos.
- Validación de cadenas.
- Manejo de excepciones.
- Conexión con SQL Server.
- `SqlConnection`.
- `SqlCommand`.
- Parámetros SQL.
- Consultas a la base de datos.

## Funcionamiento

### 1. Ingreso de datos

El usuario escribe la información solicitada para realizar una consulta.

### 2. Validación de entradas

Antes de procesar la consulta, el programa comprueba que los datos sean adecuados.

Cuando se detecta un problema, se muestra una advertencia y se evita continuar con una entrada inválida.

### 3. Preparación de la consulta

La aplicación utiliza instrucciones SQL para buscar información almacenada.

En lugar de incorporar directamente los valores ingresados dentro del texto de la consulta, se utilizan parámetros.

### 4. Prevención de SQL Injection

Las consultas parametrizadas permiten separar las instrucciones SQL de los datos proporcionados por el usuario.

Esto reduce el riesgo de que una entrada maliciosa pueda modificar la estructura de la consulta.

### 5. Presentación de resultados

El programa muestra la información obtenida o comunica cuando no se encuentran resultados.

También contempla el manejo de errores durante la operación.

## Resultado - Escenario #2

Se implementó un escenario que permite demostrar la importancia de validar los datos antes de procesarlos y utilizar consultas parametrizadas para interactuar con SQL Server.

Este ejercicio permitió comprender cómo la validación y el manejo adecuado de consultas contribuyen a la seguridad y confiabilidad de una aplicación.

### Evidencias

**Captura 1. Formulario de consulta**

<img width="399" height="239" alt="image" src="https://github.com/user-attachments/assets/5cde1410-2662-4905-bec9-95526e79c7e2" />

**Captura 2. Validación de entradas**

<img width="398" height="237" alt="image" src="https://github.com/user-attachments/assets/3dd57e09-2a6d-4a7c-b038-2f61e7c04e66" />

**Captura 3. Consulta realizada**

<img width="398" height="239" alt="image" src="https://github.com/user-attachments/assets/c66ee720-4ca3-4abe-bfd1-f3c2aad37305" />

**Captura 4. Consulta sin resultados**

<img width="397" height="241" alt="image" src="https://github.com/user-attachments/assets/b15af4aa-5061-4681-a559-5ebbec8d0dce" />


---

# Escenario #3 - Control de Acceso por Roles y Principio de Mínimo Privilegio

## Descripción

En este escenario se implementa un sistema de inicio de sesión que diferencia los permisos de dos tipos de usuarios: Administrador y Empleado.

El objetivo es demostrar que los usuarios no necesariamente deben tener acceso a todas las funciones de una aplicación.

También se aplican conceptos de programación orientada a objetos, como herencia, encapsulamiento y modificadores de acceso.

### Controles utilizados

- `Label`.
- `TextBox`.
- `Button`.
- `ComboBox`.
- Controles de lista.
- `MessageBox`.

### Elementos de C# utilizados

- Clases y objetos.
- Herencia.
- Métodos.
- Condicionales.
- Modificadores `public`, `private`, `protected` e `internal`.
- `virtual` y `override`.
- Listas de usuarios.
- Manejo de sesiones.
- Validación de credenciales.
- Autorización mediante roles.

## Funcionamiento

### 1. Inicio de sesión

El sistema presenta un formulario donde se solicita el nombre de usuario y la contraseña.

Para realizar las pruebas se utilizan las siguientes cuentas:

| Rol | Usuario | Contraseña |
|---|---|---|
| Administrador | `admin` | `Admin123` |
| Empleado | `empleado` | `Empleado123` |

Estas credenciales corresponden a las cuentas de demostración del escenario.

### 2. Autenticación

El programa comprueba si el usuario existe y si la contraseña proporcionada coincide con la almacenada.

Cuando las credenciales son correctas, se inicia una sesión.

### 3. Identificación del rol

Una vez autenticado, el programa determina los permisos correspondientes a la cuenta.

El Administrador y el Empleado utilizan el mismo sistema, pero disponen de funciones diferentes.

### 4. Permisos del Empleado

El Empleado puede:

- Iniciar sesión.
- Consultar los usuarios registrados.
- Cerrar sesión.

No tiene autorización para crear ni eliminar usuarios.

### 5. Permisos del Administrador

El Administrador puede:

- Iniciar sesión.
- Consultar usuarios.
- Acceder a la gestión de usuarios.
- Crear nuevas cuentas.
- Asignar roles.
- Eliminar usuarios según las restricciones implementadas.
- Cerrar sesión.

### 6. Comprobación de permisos

El programa controla las opciones disponibles según el rol.

Sin embargo, no depende únicamente de ocultar botones.

Antes de permitir operaciones administrativas, vuelve a comprobar que la sesión tenga autorización.

Esto evita que la seguridad dependa solamente de la apariencia de la interfaz.

### 7. Modificadores de acceso

En este escenario se utilizan los siguientes modificadores:

**`public`:** permite que otras clases consulten propiedades o utilicen métodos que necesitan.

**`private`:** protege datos internos, como la contraseña y la colección original de usuarios.

**`protected`:** permite que una clase derivada adapte determinados comportamientos heredados.

**`internal`:** permite compartir componentes dentro del mismo ensamblado.

### 8. Principio de mínimo privilegio

El sistema aplica el principio de mínimo privilegio porque cada rol dispone solamente de las funciones necesarias.

El Empleado puede consultar información, mientras que las operaciones administrativas están reservadas al Administrador.

## Resultado - Escenario #3

Se desarrolló un sistema de autenticación y autorización basado en roles que permite observar cómo cambian las funciones disponibles según el usuario que inicia sesión.

También se aplicaron modificadores de acceso para controlar la interacción entre las clases.

**Limitación importante:** este escenario utiliza una lista de usuarios en memoria y compara las contraseñas directamente. Es una demostración académica del control de acceso y no un sistema de autenticación preparado para producción.

### Evidencias

**Captura 1. Inicio de sesión**

<img width="305" height="216" alt="image" src="https://github.com/user-attachments/assets/c5b2ce9b-da76-4ebe-a0da-d4d15f0255e1" />

**Captura 2. Panel del Empleado**

<img width="308" height="270" alt="image" src="https://github.com/user-attachments/assets/e1ab7f9a-b5a3-4fe0-ad1d-3f179e9e9e06" />

**Captura 3. Consulta de usuarios**

<img width="377" height="301" alt="image" src="https://github.com/user-attachments/assets/6ed31273-a3ac-4c08-99a1-bdc28b86fcf1" />

**Captura 4. Panel del Administrador**

<img width="308" height="271" alt="image" src="https://github.com/user-attachments/assets/d985275b-dfb8-4581-bb1f-5a27b5a3111b" />

**Captura 5. Gestión de usuarios**

<img width="435" height="364" alt="image" src="https://github.com/user-attachments/assets/7476a74a-fdce-4526-876a-42be039d929a" />

**Captura 6. Creación de usuario**

<img width="434" height="365" alt="image" src="https://github.com/user-attachments/assets/55121331-82d2-41d0-a1a9-4969dd960f6b" />
<img width="433" height="362" alt="image" src="https://github.com/user-attachments/assets/d0c3ea1f-f131-428f-b0fb-88d2e36aa26d" />
<img width="431" height="361" alt="image" src="https://github.com/user-attachments/assets/355c223b-754c-4020-a829-4e189100c635" />

**Captura 7. Eliminación de usuario**

<img width="431" height="360" alt="image" src="https://github.com/user-attachments/assets/5913a961-b933-4241-abde-1376f9902357" />
<img width="431" height="361" alt="image" src="https://github.com/user-attachments/assets/08e25084-90f6-4f41-902a-0902bd1d3552" />
<img width="431" height="362" alt="image" src="https://github.com/user-attachments/assets/a55fa166-12b1-4659-8fd1-bc9c0dacad40" />

---

## Comparación de los tres escenarios

| Característica | Escenario 1 | Escenario 2 | Escenario 3 |
|---|---|---|---|
| Validación de entradas | Sí | Sí | Sí |
| SQL Server | Sí | Sí | No |
| Hashing con BCrypt | Sí | No | No |
| Consultas parametrizadas | Según las operaciones de registro | Sí | No |
| Control de acceso por roles | No | No | Sí |
| Encapsulamiento | Sí | Sí | Sí |
| Principio de mínimo privilegio | Aplicable al diseño | Aplicable al diseño | Demostración principal |

---

## Repercusiones en la calidad del software

Las prácticas implementadas en los tres escenarios permiten relacionar la seguridad con diferentes atributos de calidad del software.

### Seguridad

El hashing, las consultas parametrizadas, el encapsulamiento y el control de acceso contribuyen a reducir riesgos relacionados con la información y las operaciones no autorizadas.

### Confiabilidad

La validación de entradas y el manejo de errores ayudan a evitar fallos inesperados y favorecen un funcionamiento más estable.

### Mantenibilidad

La separación de responsabilidades entre formularios, clases y métodos facilita comprender y modificar el programa.

### Usabilidad

Las validaciones y los mensajes de error permiten que el usuario identifique problemas y comprenda cómo corregirlos.

---

## Dificultades encontradas

Durante el desarrollo del proyecto, algunos de los aspectos que requirieron mayor atención fueron:

- Comprender cómo conectar los formularios de Windows Forms con la lógica del programa.
- Organizar las validaciones para evitar procesar información incorrecta.
- Configurar correctamente la conexión con SQL Server.
- Comprender el funcionamiento de las consultas parametrizadas.
- Diferenciar autenticación y autorización.
- Implementar los permisos correspondientes a cada rol.
- Comprender cómo se relacionan los modificadores de acceso con el encapsulamiento y la herencia.

Estas actividades permitieron reforzar conocimientos de programación orientada a objetos, bases de datos, validación y seguridad.

---

## Instrucciones de ejecución

1. Descargar o clonar el repositorio.
2. Abrir el archivo `SeguridadCSharpDemo.slnx` en Visual Studio Community.
3. Restaurar los paquetes NuGet necesarios.
4. Verificar la conexión con SQL Server para los escenarios que utilizan base de datos.
5. Compilar el proyecto.
6. Ejecutar la aplicación.
7. Seleccionar uno de los tres escenarios desde el menú principal.

**Nota:** La configuración de SQL Server debe ajustarse al ejecutar en una computadora diferente, específicamente la parte de conexión. Reemplazar el server por la computadora que se está utilizando.

---

## Conclusión

Este proyecto permitió aplicar de manera práctica diferentes conceptos relacionados con la seguridad en el desarrollo de aplicaciones utilizando C# y Windows Forms.

Mediante los tres escenarios se reforzó la importancia de validar la información, proteger las contraseñas, utilizar consultas parametrizadas y establecer controles de acceso según los permisos de cada usuario.

También permitió comprender mejor el funcionamiento de las clases, métodos, modificadores de acceso y eventos de Windows Forms.

Una de las principales enseñanzas fue que la seguridad no depende de una sola herramienta, sino de diferentes decisiones de programación que trabajan en conjunto para reducir errores y controlar el comportamiento de la aplicación.

En general, el desarrollo de este proyecto contribuyó a fortalecer los conocimientos adquiridos en la asignatura y a comprender cómo aplicar estos conceptos en situaciones prácticas.

---

## Referencias

- Microsoft Learn. Documentación de C#. https://learn.microsoft.com/es-es/dotnet/csharp/
- Microsoft Learn. Windows Forms. https://learn.microsoft.com/es-es/dotnet/desktop/winforms/
- Microsoft Learn. SQL Server. https://learn.microsoft.com/es-es/sql/
- OWASP. Password Storage Cheat Sheet. https://cheatsheetseries.owasp.org/cheatsheets/Password_Storage_Cheat_Sheet.html
- OWASP. SQL Injection Prevention Cheat Sheet. https://cheatsheetseries.owasp.org/cheatsheets/SQL_Injection_Prevention_Cheat_Sheet.html
