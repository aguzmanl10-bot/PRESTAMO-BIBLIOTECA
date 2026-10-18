using PrestamosBiblioteca.Aplicacion;
using PrestamosBiblioteca.Persistencia;

Console.OutputEncoding = System.Text.Encoding.UTF8;

var rutaBd = Path.Combine(AppContext.BaseDirectory, "biblioteca.db");
// "Foreign Keys=True" activa las llaves foraneas (y ON DELETE CASCADE) en cada conexion.
var cadenaConexion = $"Data Source={rutaBd};Foreign Keys=True";

InicializadorBaseDatos.Crear(cadenaConexion);

var menu = new MenuBiblioteca(new RepositorioBiblioteca(cadenaConexion));
menu.Ejecutar();
