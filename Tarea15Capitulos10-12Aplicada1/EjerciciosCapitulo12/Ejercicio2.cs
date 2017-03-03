using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace Tarea15Capitulos10_12Aplicada1.EjerciciosCapitulo12
{
    //Utilizar el método WriteLine() de la clase Debug para que las funciones nos indiquen cuando entramos y salimos de ellas.

    public class Ejercicio2
    {

        public static void Factorial()
        {
            // Variables necesarias
            int n = 0; // Variable de control
            int numero = 5; // Número al que sacamos factorial
            int factorial = 1; // Factorial calculado
            string valor = "";
            // Pedimos el numero
            Console.WriteLine("Dame el número al que se le saca el factorial:");
            valor = Console.ReadLine();
            numero = Convert.ToInt32(valor);
            // Calculamos el factorial en el ciclo
            for (n = numero; n >= 1; n--)
                factorial *= n;
            // Mostramos el resultado
            Console.WriteLine("El factorial de {0} es {1}", numero, factorial);
        }


    }
}
