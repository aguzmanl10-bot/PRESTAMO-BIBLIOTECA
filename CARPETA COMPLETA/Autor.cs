namespace PrestamosBiblioteca.Dominio;

public sealed class Autor
{
    public string Codigo { get; }
    public string Nombre { get; }
    public string Nacionalidad { get; }

    public Autor(string codigo, string nombre, string nacionalidad)
    {
        if (string.IsNullOrWhiteSpace(codigo)) throw new ArgumentException("El codigo es obligatorio.");
        if (string.IsNullOrWhiteSpace(nombre)) throw new ArgumentException("El nombre es obligatorio.");
        if (string.IsNullOrWhiteSpace(nacionalidad)) throw new ArgumentException("La nacionalidad es obligatoria.");
        Codigo = codigo.Trim();
        Nombre = nombre.Trim();
        Nacionalidad = nacionalidad.Trim();
    }

    public string ObtenerInformacion() => $"Autor [{Codigo}] {Nombre} - {Nacionalidad}";
}
