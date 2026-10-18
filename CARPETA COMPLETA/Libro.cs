namespace PrestamosBiblioteca.Dominio;

public sealed class Libro
{
    public string Codigo { get; }
    public string Titulo { get; }
    public int AutorId { get; }
    public int Ejemplares { get; }

    public Libro(string codigo, string titulo, int autorId, int ejemplares)
    {
        if (string.IsNullOrWhiteSpace(codigo)) throw new ArgumentException("El codigo es obligatorio.");
        if (string.IsNullOrWhiteSpace(titulo)) throw new ArgumentException("El titulo es obligatorio.");
        if (autorId < 1) throw new ArgumentException("Debe indicar un Id de autor valido.");
        if (ejemplares < 1) throw new ArgumentException("Debe haber al menos 1 ejemplar.");
        Codigo = codigo.Trim();
        Titulo = titulo.Trim();
        AutorId = autorId;
        Ejemplares = ejemplares;
    }
}
