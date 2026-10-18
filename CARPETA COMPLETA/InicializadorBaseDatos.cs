using Microsoft.Data.Sqlite;

namespace PrestamosBiblioteca.Persistencia;

internal static class InicializadorBaseDatos
{
    public static void Crear(string cadenaConexion)
    {
        using var conexion = new SqliteConnection(cadenaConexion);
        conexion.Open();
        using var comando = conexion.CreateCommand();
        comando.CommandText = @"
            CREATE TABLE IF NOT EXISTS Lectores (
                Id       INTEGER PRIMARY KEY AUTOINCREMENT,
                Codigo   TEXT NOT NULL UNIQUE,
                Nombre   TEXT NOT NULL,
                Correo   TEXT NOT NULL,
                Telefono TEXT NOT NULL
            );
            CREATE TABLE IF NOT EXISTS Autores (
                Id           INTEGER PRIMARY KEY AUTOINCREMENT,
                Codigo       TEXT NOT NULL UNIQUE,
                Nombre       TEXT NOT NULL,
                Nacionalidad TEXT NOT NULL
            );
            CREATE TABLE IF NOT EXISTS Libros (
                Id         INTEGER PRIMARY KEY AUTOINCREMENT,
                Codigo     TEXT NOT NULL UNIQUE,
                Titulo     TEXT NOT NULL,
                AutorId    INTEGER NOT NULL REFERENCES Autores(Id) ON DELETE RESTRICT,
                Ejemplares INTEGER NOT NULL CHECK (Ejemplares >= 1)
            );
            CREATE TABLE IF NOT EXISTS Prestamos (
                Id              INTEGER PRIMARY KEY AUTOINCREMENT,
                LectorId        INTEGER NOT NULL REFERENCES Lectores(Id) ON DELETE CASCADE,
                LibroId         INTEGER NOT NULL REFERENCES Libros(Id)   ON DELETE CASCADE,
                FechaPrestamo   TEXT NOT NULL,
                FechaLimite     TEXT NOT NULL,
                FechaDevolucion TEXT NULL
            );";
        comando.ExecuteNonQuery();
    }
}
