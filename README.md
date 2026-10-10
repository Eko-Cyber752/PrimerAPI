Web API .NET - Gestión de Empleados

Proyecto de Web API desarrollado en .NET utilizando Entity Framework Core y MySQL (`db_empresa`) para la administración de empleados y puestos.

Endpoints Principales

- Listar Empleados (`GET`): `/Empleados/ListarEmpleados` - Retorna la lista completa de empleados.
- Obtener Empleado (`GET`): `/Empleados/ObtenerEmpleado/{id}` - Busca un empleado específico por su ID.
- Crear Empleado (`POST`): `/Empleados/CrearEmpleado` - Inserta un nuevo registro enviando un JSON limpio.
- Actualizar Empleado (`PUT`): `/Empleados/ActualizarEmpleado/{id}` - Modifica los datos de un empleado existente.

 Tecnologías Utilizadas

- .NET Web API
- Entity Framework Core (`Especificamente:Pomelo.EntityFrameworkCore.MySql`)
- MySQL Workbench
- Swagger / OpenAPI

Video de Demostración

Puedes ver la explicación completa y la demostración de las operaciones CRUD (GET, POST, PUT) junto con la verificación en la base de datos en el siguiente enlace:

[![Ver Video de Demostración en YouTube](https://img.youtube.com/vi/olmk4yVgqw4/0.jpg)](https://youtu.be/olmk4yVgqw4)
