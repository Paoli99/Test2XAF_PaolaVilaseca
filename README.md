# Test 2 - Paola Vilaseca

## Descripción del Proyecto
Este proyecto es una iteración sobre el Test 1, implementado utilizando el framework **eXpressApp Framework (XAF)** de DevExpress. 

## Requisitos
- **.NET Framework 6.0 o superior**
- **DevExpress XAF Framework**
- **SQL Server** o **Microsoft SQL Server Management Studio** para la gestión de la base de datos

## Características
1. **Gestión de Tareas**: Los usuarios pueden crear, eliminar, actualizar y ver la lista tareas.
2. **Exportación de Tareas**: Las tareas se pueden exportar a un archivo de texto.
3. **Autenticación y Roles**: Implementación de un sistema de autenticación de usuarios con roles.
4. **UI generada automáticamente**: Las vistas de la aplicación de escritorio y web fueron generadas automáticamente por XAF.
5. **Persistencia de Datos**: Utiliza SQL Server para la persistencia de datos, administrado automáticamente por XAF.

## Instrucciones para la Instalación

1. **Clona el repositorio:**
   ```bash
   git clone https://github.com/Paoli99/Test2XAF_PaolaVilaseca
    ```

2. **Descargar DevExpress**
    Debe tener DevExpress instalado en su entorno para que XAF funcione correctamente. 

3. **Configuración de la base de datos**
    Debe configurar una base de datos SQL Server. La cadena de conexión se encuentra en el archivo app.config o appsettings.json.
    Ejemplo
    ``` <connectionStrings>
            <add name="ConnectionString" connectionString="XpoProvider=MSSqlServer;Data Source=(LocalDb)\\MSSQLLocalDB;Initial Catalog=YourXAFDatabase;Integrated Security=True;" />
        </connectionStrings>
     ```
4. **Ejecutación de la aplicación** 
    Ejecutar el servidor SQL antes de iniciar la aplicación.
    Desde Visual Studio, seleccionar el proyecto .Win para la versión de escritorio o el proyecto .Blazor.Server para la versión web.


## Funcionalidades 

1. **Aplicación de escritorio**
    1. Crear tareas
    2. Eliminar tareas
    3. Marcar tareas como completadas
    4. Cambiar la descripción de las tareas
    5. Exportar tareas a un archivo txt. 

2. **Aplicación web**
    Las mismas funcionalidades que en la version de escritorio. 


