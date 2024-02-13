using System;

namespace guia2_ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
           // Hacer un programa que permita ingresar los kilómetros existentes entre dos ciudades y la velocidad promedio de un vehículo. 
           // Calcular y emitir por pantalla el tiempo aproximado que demandará llegar de un punto a otro teniendo en cuenta los datos ingresados.
           
           float Distancia, Velocidad, Tiempo;
           Console.WriteLine("Ingrese los kilometros existentes entre 2 ciudades:");
           Distancia = float.Parse(Console.ReadLine());
           Console.WriteLine("Ingrese la velocidad promedio de un vehiculo (en km/h):");
           Velocidad = float.Parse(Console.ReadLine());
           Tiempo = Distancia/Velocidad;
           Console.WriteLine("El tiempo aproximado que demandará llegar de un punto a otro será de " + Tiempo.ToString("0.00") + " horas");

        }
    }
}
