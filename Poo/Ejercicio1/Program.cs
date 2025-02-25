using System;
using System.Collections.Generic;

namespace MundoMagico
{
    class Program
    {
        static void Main(string[] args)
        {
            Juego juego = new Juego();
            juego.Iniciar();
        }
    }

    public class Juego
    {
        private List<Mago> magos;
        private List<Criatura> criaturas;

        public Juego()
        {
            magos = new List<Mago>();
            criaturas = new List<Criatura>();
        }

        public void Iniciar()
        {
            Console.WriteLine("Bienvenido al mundo mágico!");
            CrearMago();
            CrearCriatura();
            // Aquí puedes agregar más funcionalidades como combate y exploración
        }

        private void CrearMago()
        {
            Console.Write("Introduce el nombre de tu mago: ");
            string nombre = Console.ReadLine();
            Mago mago = new Mago(nombre);
            magos.Add(mago);
            Console.WriteLine($"Mago {nombre} creado con éxito!");
        }

        private void CrearCriatura()
        {
            Console.Write("Introduce el nombre de la criatura: ");
            string nombre = Console.ReadLine();
            Criatura criatura = new Criatura(nombre);
            criaturas.Add(criatura);
            Console.WriteLine($"Criatura {nombre} creada con éxito!");
        }
    }

    public class Mago
    {
        public string Nombre { get; private set; }
        public List<Hechizo> Hechizos { get; private set; }

        public Mago(string nombre)
        {
            Nombre = nombre;
            Hechizos = new List<Hechizo>();
        }

        public void AprenderHechizo(Hechizo hechizo)
        {
            Hechizos.Add(hechizo);
            Console.WriteLine($"{Nombre} ha aprendido el hechizo {hechizo.Nombre}!");
        }
    }

    public class Criatura
    {
        public string Nombre { get; private set; }

        public Criatura(string nombre)
        {
            Nombre = nombre;
        }
    }

    public class Hechizo
    {
        public string Nombre { get; private set; }
        public int Poder { get; private set; }

        public Hechizo(string nombre, int poder)
        {
            Nombre = nombre;
            Poder = poder;
        }
    }
}
