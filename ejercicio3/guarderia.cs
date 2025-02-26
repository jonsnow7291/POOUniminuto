using System;
namespace ejercicio3
{
    class guarderia
    {


        public list<mascota> mascotas { get; set; }
        public list<comida> porcionesDeComida { get; set; }

        public mascotas()
        {
            mascotas = new list<mascotas>();
            porcionesDeComida = new list<porcionesDeComida>();
        }


        public void alimentarMascotas(mascotas m, porcionesDeComida prociones)
        {
            Console.WriteLine($"se ha alimentado a {mascotas.nombre} de raza {prociones.nombre}")
            int porcionMenos =  prociones.porciones - 1;
            Console.WriteLine($"ya que antes habia {prociones} ahora ahi {porcionMenos}")
        }
    }

}