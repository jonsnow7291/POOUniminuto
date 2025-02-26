using System;
namespace ejercicio3{
    class mascota{

        public string nombre{ get; private set;}
        public string raza{get; set;}
        public string tDeMascota{get; set;}

        public string estado {get; set;}

        public mascota (string Nomb, string rz, string tipo,  string status ){

            nombre = Nomb;
            raza = rz;
            tDeMascota = tipo;
            estado = status;

        }
        
        public void correr (string n string tipo){
            Console.WriteLine($"{n} el {tipo} esta corriendo");
        }
        public string ladrar(string n, string tipo){
            Console.WriteLine($"{n} el {tipo} empieza a ladrar");
                    
        }
    }
}