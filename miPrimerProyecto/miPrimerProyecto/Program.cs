using System;

namespace miPrimerProyecto {
    internal class Program {
        static void Main(string[] args) {
            string continuar = "s";
            while (continuar == "s") {
                Console.WriteLine("** MENU **");
                Console.WriteLine("1. Par o impar");
                Console.WriteLine("2. Dia de la semana.");
                Console.WriteLine("3. Tabla de multiplicar");
                Console.WriteLine("4. Salir");

                Console.Write("Opcion: ");
                int opcion = int.Parse(Console.ReadLine());
                switch (opcion) {
                    case 1:
                        parImpar();
                        break;

                    case 2:
                        diaSemana();
                        break;

                    case 3:
                        tablaMultiplicar();
                        break;

                    case 4:
                        continuar = "a";
                        break;
                }
            }
        }
        static void tablaMultiplicar() {
            Console.Write("Dime la tabla: ");
            int ntabla = int.Parse(Console.ReadLine());
            for(int i = 1; i<=10;  i++) {
                Console.WriteLine("{0}X{1}={2}", ntabla, i, ntabla*i);
            }
        }
        static void parImpar() {
            Console.Write("Numero: ");
            int num = int.Parse(Console.ReadLine());

            // % es modulo y obtiene el residuo, num%2==2 la expresion a evaluar de la condicion, ? es el entonces (verdad), : es la sino (false)
            String determinar = num % 2 == 0 ? "Par" : "Impar";

            Console.WriteLine("El numero {0}, es {1}", num, determinar);
        }
        static void diaSemana() {
            //Ejercicio: determinar segun el numero de dia (1-7) el dia (Domingo a Sabado)
            Console.Write("Numero del dia: ");
            int ndia = int.Parse(Console.ReadLine());
            string[] semana = new String[] { "", "domingo", "lunes", "martes", "miercoles", "jueves", "viernes", "sabado" };

            string msg = "el numero {0}, equivale a {1}"; ;
            Console.WriteLine(msg, ndia, semana[ndia]);
        }
    }
}
