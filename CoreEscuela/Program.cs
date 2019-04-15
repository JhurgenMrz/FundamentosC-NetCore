using System;

namespace CoreEscuela
{
    class Escuela
    {
        //Atributos
        public string nombre;
        public string direccion;
        public int añofundacion;
        public string director;

        //Métodos
        //Void es una función que se ejecuta pero no devolvera ningun valor
        public void Timbrar()
        {
            Console.Beep(987, 1000); //Si
            Console.Beep(1174, 500); //Re'
            Console.Beep(880, 1500); //La

            Console.Beep(783, 250); //Sol
            Console.Beep(880, 250); //La
            Console.Beep(987, 1000); //Si

            Console.Beep(1174, 500); //Re'
            Console.Beep(880, 1500); //La

            Console.Beep(987, 1000); //Si
            Console.Beep(1174, 500); //Re'
            Console.Beep(1760, 1000); //La'
            Console.Beep(1567, 500); //Sol'
            Console.Beep(1174, 1000); //Re'

            Console.Beep(1046, 250); //Do
            Console.Beep(987, 250); //Si
            Console.Beep(880, 1000); //La

            //Console.Beep(523, 500); //Do

        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            var miEscuela = new Escuela();
            miEscuela.nombre = "Republica del Libano";
            miEscuela.direccion = "Montes de Oca 121 ";
            miEscuela.Timbrar();
            // Console.WriteLine("Hello World!");
        }
    }
}
