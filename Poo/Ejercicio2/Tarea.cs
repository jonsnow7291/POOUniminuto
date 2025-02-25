public class Tarea
{
    public string Descripcion { get; private set; }
    public string Requerimiento { get; private set; }

    public Tarea(string descripcion, string requerimiento)
    {
        Descripcion = descripcion;
        Requerimiento = requerimiento;
    }
}
