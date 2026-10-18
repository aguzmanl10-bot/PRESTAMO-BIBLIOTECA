# Sistema de Préstamos de Biblioteca (C# + SQLite)

## Ejecutar
    dotnet restore
    dotnet run

La base de datos `biblioteca.db` se crea sola junto al ejecutable.

## Estructura
- Dominio/        Persona (abstracta), Lector, Libro, Prestamo
- Persistencia/   InicializadorBaseDatos (esquema) y RepositorioBiblioteca (CRUD con ADO.NET)
- Aplicacion/     MenuBiblioteca (consola)
- Program.cs      Punto de entrada
