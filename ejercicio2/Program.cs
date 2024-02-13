using System;

namespace guia2_ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa para solicitar por teclado un número y luego devolver su valor elevado al cubo.

            int N,CUBO;
            Console.WriteLine("Ingrese un número:");
            N = int.Parse(Console.ReadLine ());
            CUBO = N*N*N;
            Console.WriteLine("El valor de " + N + " elevado al cubo es: " + CUBO);
        }
    }
}
