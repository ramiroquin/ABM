# ABM
## Descripción
Esta API REST desarrollada con .NET permite realizar operaciones ABM (alta, baja, modificar) sobre recursos específicos. Esta creada con el enfoque Code First de Entity Framework por lo tanto no tenes que rediseñar la base de datos.

## Endpoints y Métodos
A continuación, se describen los endpoints disponibles junto con los métodos HTTP que se pueden utilizar:

### Obtener todos los usuarios
#### Método: GET
- URL: /api/Usuario/Listar
- Descripción: Obtiene todos los usuarios que existen en la base de datos.
### Obtener un usuario por su ID
#### Método: GET
- URL: /api/Usuario/Obtener/{id}
- Descripción: Obtiene un Usuario específico según su ID.
### Dar alta a un nuevo usuario
#### Método: POST
- URL: /api/Usuario/Guardar
- Descripción: Crea un nuevo Usuario. Los datos deben proporcionarse en el cuerpo de la solicitud en formato JSON.
### Modificar un usuario existente
#### Método: PUT
- URL: /api/Usuario/{Editar
- Descripción: Actualiza un usuario existente según su ID. Los nuevos datos deben proporcionarse en el cuerpo de la solicitud en formato JSON.
### Dar la baja a un usuario
#### Método: DELETE
- URL: /api/Usuario/Eliminar/{id}
- Descripción: Elimina un Usuario existente según su ID.
## Instalación y configuración
1. Clona este repositorio en tu máquina local.
```
git clone https://github.com/ramiroquin/PruebaEvoltis.git
```
3. Abre el proyecto con Visual Studio.
4. Asegúrate de tener instalado .NET, MySql y todas las dependencias necesarias.
5. Abre el archivo de conexión SQL (appsettings.json).
```
   "ConnectionStrings": {
    "ConexionSql": "Cambia_Aquí_Tu_Cadena_De_Conexión_SQL"
}
```
5. Cambia la cadena de conexión para que apunte a tu base de datos local.
6. Presiona el botón de "Iniciar depuración" (F5) o "Iniciar sin depuración" (Ctrl+F5) para ejecutar la aplicación.
