using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3384___LUIS_ADRIAN_VILLEGAS_GUEVARA__
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Primer ejercicio de la tarea 
            
            //Solicitar e imprimir el nombre, la edad y la estatura de un alumno

            //ADEMAS MOSTRAR EN QUE AÑO NACIO

            //Entrada (Declarar variables)
            string nombre;
            int edad;
            float estatura;
            int anionacimiento;

            //Proceso (Lògica)
            Console.WriteLine("Bienvenido");
            Console.WriteLine("Ingrese su nombre: ");
            nombre = Console.ReadLine();
            Console.Beep(400, 500);
            Console.WriteLine("Ingrese su edad: ");
            edad = int.Parse(Console.ReadLine());
            Console.Beep(1000, 800);
            Console.WriteLine("Ingrese su estatura: ");
            estatura = float.Parse(Console.ReadLine());
            Console.Beep(1300, 1000);
            anionacimiento = 2024 - edad;



            //Salida (Mostrar resultados)
            Console.WriteLine("Su nombre es: " + nombre);
            Console.WriteLine("Su edad es: " + edad);
            Console.WriteLine("Su estatura es: " + estatura);
            Console.WriteLine(nombre + " Tu edad es " + edad + " años, y naciste en el año " + anionacimiento);


            //Segundo ejercicio 

            Console.Write("Ingresa un número: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0)
                Console.WriteLine("El número es par.");
            else
                Console.WriteLine("El número es impar.");


        }
    }
}
