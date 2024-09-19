
public abstract class Empleado
{
    public string Nombre { get; set; }
    public string Tipo { get; set; }

    public Empleado(string nombre, string tipo)
    {
        Nombre = nombre;
        Tipo = tipo;
    }

    public abstract decimal CalcularSalario();
}