using System;

namespace Guia_2_ej_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa para solicitar dos números y luego calcule y emita la suma en pantalla.
            
            int N1,N2,R;
            Console.WriteLine("Ingrese dos numeros por favor:");
            N1 = int.Parse(Console.ReadLine());
            N2 = int.Parse(Console.ReadLine());
            R = N1 + N2;
            Console.WriteLine("El resultado de la suma es " + R);
        }
    }
}
