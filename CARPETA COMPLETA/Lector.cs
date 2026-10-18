namespace PrestamosBiblioteca.Dominio;

public sealed class Lector : Persona
{
    public Lector(string codigo, string nombre, string correo, string telefono)
        : base(codigo, nombre, correo, telefono) { }

    // Sobrescritura: mismo metodo, comportamiento propio de Lector.
    public override string ObtenerInformacion() =>
        $"Lector [{Codigo}] {Nombre} - Correo: {Correo} - Tel: {Telefono}";
}
