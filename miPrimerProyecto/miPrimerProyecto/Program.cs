using System;
using System.Linq;

namespace miPrimerProyecto {
    internal class Program {
        static void Main(string[] args) {
            int[] numeros = new int[] { 5, 8, 7, 9, 1, 4, 3, 2, 6 };

            var numPares = 
                from num in numeros
                where num % 2 == 0
                select num;
            Console.WriteLine("Listado de numeros pares: ");
            foreach(int num in numPares) {
                Console.Write("{0}, ", num);
            }
            Console.WriteLine("\n");

            var numImpares = 
                from num in numeros
                where num % 2 != 0
                select num;
            Console.WriteLine("Listado de numeros impares: ");
            foreach (int num in numImpares) {
                Console.Write("{0}, ", num);
            }

            Console.WriteLine("\n");
            Console.WriteLine("El primero numero de la serie es: {0}, otra es: {1}", numeros.First(), numeros[0]);
            Console.WriteLine("El ultimo numero de la serie es: {0}, otra es: {1}", 
                numeros.Last(), numeros[ numeros.Length -1 ]);
            Console.WriteLine("La longitud de la serie es: {0}", numeros.Length);
            Console.WriteLine("Un unico valor: {0}", numeros.Single(num => num == 1));

            var pares = numeros.Where(num => num % 2 == 0);
            foreach (int num in pares) {
                Console.Write("{0}, ", num);
            }
            //Pausa.
            Console.ReadLine();
        }
    }
}
