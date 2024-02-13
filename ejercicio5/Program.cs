using System;

namespace guia2_ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hacer un programa para ingresar por teclado las tres notas de exámenes de un alumno y luego calcule y emita por pantalla el promedio final.

            int n1,n2,n3;
            float promedio;
            Console.WriteLine("Ingrese las 3 notas del alumno por favor:");
            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());
            n3 = int.Parse(Console.ReadLine());
            promedio = (n1 + n2 + n3)/ 3F;
            Console.WriteLine("El promedio del alumno es de: " + promedio.ToString("0.00"));

            //tambien en vez de la F puedo poner n1,n2 y n3 como datos float, hacer la correccion parse con float y eliminar la f

        }
    }
}
