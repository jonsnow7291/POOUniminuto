public class Robot
{
    public string Nombre { get; set; }
    public string Capacidad { get; set; }

    public Robot(string nombre, string capacidad)
    {
        Nombre = nombre;
        Capacidad = capacidad;
    }

    public void RealizarTarea(Tarea tarea)
    {
        if (tarea.Requerimiento == Capacidad)
        {
            Console.WriteLine($"El robot{Nombre} está realizando la tarea: {tarea.Descripcion}");
        }
        else
        {
            Console.WriteLine($"El robot {Nombre} no puede realizar la tarea: {tarea.Descripcion}");
        }
    }
}
