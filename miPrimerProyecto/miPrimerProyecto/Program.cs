using System;

namespace miPrimerProyecto {
    internal class Program {
        static void Main(string[] args) {
            //Ejercicio: determinar segun el numero de dia (1-7) el dia (Domingo a Sabado)
            Console.Write("Numero del dia: ");
            int ndia = int.Parse(Console.ReadLine());

            string msg = "";
            switch (ndia) {
                case 1:
                    msg = "el numero {0}, equivale a domingo";
                    break;
                case 2:
                    msg = "el numero {0}, equivale a lunes";
                    break;
                case 3:
                    msg = "el numero {0}, equivale a martes";
                    break;
                case 4:
                    msg = "el numero {0}, equivale a miercoles";
                    break;
                case 5:
                    msg = "el numero {0}, equivale a jueves";
                    break;
                case 6:
                    msg = "el numero {0}, equivale a viernes";
                    break;
                case 7:
                    msg = "el numero {0}, equivale a sabado";
                    break;
                default:
                    msg = "Por favor ingrese un numero comprendido entre 1 y 7.";
                    break;
            }
            Console.WriteLine(msg, ndia);

            //Pausa
            Console.ReadLine();
        }
    }
}
