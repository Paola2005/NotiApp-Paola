
# Proyecto de Notificaciones para un Lugar Educativo

Este proyecto es una aplicación en C# que permite gestionar notificaciones para un lugar educativo. Está diseñado siguiendo una arquitectura de tres capas, que consiste en una capa de API, una capa de Core y una capa de Infraestructura. Esto proporciona un diseño escalable y mantenible.

## Descripción

Este proyecto es una aplicación en C# que permite gestionar notificaciones para un lugar educativo. Sigue una arquitectura de tres capas que separa la interfaz de usuario, la lógica de negocio y el acceso a la base de datos.

## Tecnologías Utilizadas

- C# para la programación.
- ASP.NET Core para la capa de API.
- Entity Framework Core o Dapper para la comunicación con la base de datos.
- SQL Server (u otro sistema de gestión de bases de datos compatible) para el almacenamiento de datos.

## Configuración y Ejecución

Para configurar y ejecutar el proyecto de notificaciones para un lugar educativo, sigue estos pasos:

**Requisitos previos:**

- Visual Studio (o cualquier otro entorno de desarrollo de C#).
- SQL Server (u otro sistema de gestión de bases de datos compatible) instalado y configurado.

**Pasos:**

1. Clona el repositorio desde [URL del Repositorio] o descarga el proyecto como un archivo ZIP.

2. Abre el proyecto en Visual Studio.

3. Configuración de la Base de Datos:

   - Asegúrate de que tu sistema de gestión de bases de datos esté en funcionamiento.
   - Abre el archivo de configuración de la cadena de conexión en la capa de API y ajústalo según tu configuración de base de datos. Esto generalmente se encuentra en el archivo `appsettings.json` o `appsettings.Development.json`. Asegúrate de configurar el servidor, el nombre de la base de datos, las credenciales y cualquier otro parámetro necesario.


## Uso de Thunder o Swagger

Para interactuar con la API y realizar operaciones, puedes utilizar Thunder Request o Swagger. Sigue estos pasos para acceder a la API:

### Acceso a través de Thunder Request

**Paso 1: Asegurando la Ejecución del Proyecto**

Asegúrese de que el proyecto esté en ejecución utilizando el siguiente comando:

```bash
dotnet run --project ./API/
```

**Paso 2: Configuración de Thunder Request**

Abra Thunder Request y configure la URL base de la API. Por lo general, la URL base será http://localhost:puerto/api.

**Paso 3: Configuración de las Rutas de Controlador**

Para acceder a las rutas del controlador de auditorías y otros controladores, es necesario agregar el atributo [Route("api/[controller]")] a las clases de controlador correspondientes. Asegúrese de que esto se haya realizado en el código fuente.

**Paso 4: Envío de Solicitudes**

Utilice Thunder Request para enviar solicitudes HTTP a las rutas de la API según sus necesidades. Asegúrese de seguir las operaciones descritas en la documentación y proporcionar los datos requeridos.

## Acceso a través de Swagger

**Paso 1: Asegurando la Ejecución del Proyecto**

Asegúrese de que el proyecto esté en ejecución utilizando el siguiente comando:

```bash
dotnet run --project ./API/
```

**Paso 2: Acceso a la Interfaz de Swagger**

Abra un navegador web y navegue a la URL de Swagger. Por lo general, esta URL será http://localhost:puerto/swagger.

**Paso 3: Exploración de la Documentación**

Utilice Swagger para explorar la documentación de la API y realizar operaciones directamente desde la interfaz de usuario. Puede probar y enviar solicitudes a las rutas disponibles y obtener información detallada sobre cada operación.

## Requisitos Previos

Antes de realizar ciertas operaciones en la API, tenga en cuenta que algunas de ellas pueden requerir la existencia de elementos relacionados en la base de datos. Asegúrese de crear los siguientes elementos antes de llevar a cabo las operaciones correspondientes:

- **Tipo de Notificación (TipoNotificacion):** Algunas operaciones de notificación pueden requerir que se haya creado previamente un "Tipo de Notificación". Asegúrese de crear los tipos de notificación necesarios antes de enviar notificaciones.

- **Respuesta de Notificación (RespuestaNotificacion):** Si está trabajando con respuestas a notificaciones, es fundamental que haya creado las respuestas de notificación requeridas en la base de datos antes de asociarlas a notificaciones.

- **Auditoría (Auditoria):** Si está gestionando auditorías, tenga en cuenta que las operaciones de auditoría pueden requerir la existencia de registros de auditoría en la base de datos. Asegúrese de haber registrado auditorías antes de gestionarlas a través de la API.

Estos elementos son necesarios para asegurar el funcionamiento adecuado de ciertas operaciones de la API y mantener la integridad de los datos. Asegúrese de crearlos según sea necesario antes de interactuar con la API.
