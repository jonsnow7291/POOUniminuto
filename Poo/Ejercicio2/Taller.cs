using System.Collections.Generic;

public class Taller
{
    private List<Robot> robots = new List<Robot>();
    private List<Tarea> tareas = new List<Tarea>();

    public void AgregarRobot(Robot robot)
    {
        robots.Add(robot);
    }

    public void AgregarTarea(Tarea tarea)
    {
        tareas.Add(tarea);
    }

    public void AsignarTareas()
    {
        foreach (var tarea in tareas)
        {
            foreach (var robot in robots)
            {
                robot.RealizarTarea(tarea);
            }
        }
    }
}
