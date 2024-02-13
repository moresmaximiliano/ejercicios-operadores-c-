using System;

namespace guia2_ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Una casa de computación paga a sus empleados un sueldo fijo de ARS15000 más una comisión del 5% sobre el total facturado por cada empleado. 
            // Hacer un programa para ingresar el total facturado por un empleado y que luego calcule y emita por pantalla el sueldo total a cobrar por el mismo.

            float TF,COMISION,SUELDO;
            Console.WriteLine("Ingrese el total facturado por el empleado:");
            TF = float.Parse(Console.ReadLine());
            COMISION = TF * 0.05F;
            SUELDO = COMISION + 15000;
            Console.WriteLine("El sueldo total a cobrar por el empleado es de " + SUELDO + " pesos");

            // Si quisieramos hacerlo con variables actualizables de manera sencilla podemos hacer:
            // float TF,COMISION,SUELDO;
            // float sueldoFijo = 15000;
            // float porcentajeComision = 0.05F;
            // Console.WriteLine("Ingrese el total facturado por el empleado:");
            // TF = float.Parse(Console.ReadLine());
            // COMISION = TF * porcentajeComision;
            // SUELDO = COMISION + sueldoFijo;
            // Console.WriteLine("El sueldo total a cobrar por el empleado es de " + SUELDO + " pesos");

        }
    }
}
