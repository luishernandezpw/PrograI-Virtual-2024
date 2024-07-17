using System;

namespace miPrimerProyecto {
    internal class Program {
        static void Main(string[] args) {
            //Ejercicio de pedir el nombre y la edad y dar un saludo
            Console.Write("Nombre: ");
            String nombre = Console.ReadLine();

            Console.Write("Edad: ");
            int edad = int.Parse(Console.ReadLine());

            Console.WriteLine("Hola, {0} bienvenido a Progra I, estas en la mejor epoca {1} de aprender a programar.",
                nombre, edad);

            Console.ReadLine();
        }
    }
}
