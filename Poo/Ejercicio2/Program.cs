using System;

class Program
{
    static void Main(string[] args)
    {
        Taller taller = new Taller();

        Robot robot1 = new Robot("Robot1", "Limpieza");
        Robot robot2 = new Robot("Robot2", "Montaje");

        taller.AgregarRobot(robot1);
        taller.AgregarRobot(robot2);

        Tarea tarea1 = new Tarea("Limpiar el taller", "Limpieza");
        Tarea tarea2 = new Tarea("Montar una pieza", "Montaje");

        taller.AgregarTarea(tarea1);
        taller.AgregarTarea(tarea2);

        taller.AsignarTareas();
    }
}
