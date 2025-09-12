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
            {

                Console.WriteLine("El número es par.");
            }
            else
            {

            }
            Console.WriteLine("El número es impar.");

            //5 commit 

            int manzanasJuan = 10;
            int manzanasDadas = 3;

            int resultado = manzanasJuan - manzanasDadas;

            Console.WriteLine("A Juan le quedan " + resultado + " manzanas.");

            //Sexto ejercicio 

            int pasajeros = 20;
            pasajeros += 5; // suben
            pasajeros -= 2; // bajan

            Console.WriteLine("En el autobús hay " + pasajeros + " pasajeros.");

            //7 commit

            int pastel = 8;
            int comido = 2;
            int repartido = 3;

            int restante = pastel - (comido + repartido);

            Console.WriteLine("Quedan " + restante + " porciones de pastel.");

            // 8 commit 

            int juan = 12;
            int pedro = 8;

            Console.WriteLine("Al inicio:");
            Console.WriteLine("Juan tiene " + juan + " manzanas.");
            Console.WriteLine("Pedro tiene " + pedro + " manzanas.\n");

            // Paso 1: Juan le da 3 manzanas a Pedro
            juan -= 3;
            pedro += 3;
            Console.WriteLine("Después de que Juan le da 3 manzanas a Pedro:");
            Console.WriteLine("Juan tiene " + juan + " manzanas.");
            Console.WriteLine("Pedro tiene " + pedro + " manzanas.\n");

            // 9 commit del mismo ejercicio

            // Paso 2: Pedro se come 2 manzanas
            pedro -= 2;
            Console.WriteLine("Después de que Pedro se come 2 manzanas:");
            Console.WriteLine("Juan tiene " + juan + " manzanas.");
            Console.WriteLine("Pedro tiene " + pedro + " manzanas.\n");

            // 10 commit del mismo ejercicio
            // Paso 3: Juan compra 5 manzanas más
            juan += 5;
            Console.WriteLine("Después de que Juan compra 5 manzanas más:");
            Console.WriteLine("Juan tiene " + juan + " manzanas.");
            Console.WriteLine("Pedro tiene " + pedro + " manzanas.\n");

            // Paso 4: Reparten las manzanas por igual
            int total = juan + pedro;
            juan = total / 2;
            pedro = total / 2;
            Console.WriteLine("Después de repartir las manzanas por igual:");
            Console.WriteLine("Juan tiene " + juan + " manzanas.");
            Console.WriteLine("Pedro tiene " + pedro + " manzanas.");
            //Fin del ejercicio

            // 11 commit
            Console.Write("¿Cuánto dinero tiene María al inicio? ");
            int dinero = int.Parse(Console.ReadLine());

            dinero -= 15; // compra dulces
            dinero += 20; // ahorra más

            Console.WriteLine("Ahora María tiene $" + dinero);

            //prueba d commit

            //12 commit

            Console.Write("¿Cuántos libros había en la biblioteca al inicio? ");
            int libros = int.Parse(Console.ReadLine());

            Console.Write("¿Cuántos libros se prestaron? ");
            libros -= int.Parse(Console.ReadLine());

            Console.Write("¿Cuántos libros se devolvieron? ");
            libros += int.Parse(Console.ReadLine());

            Console.WriteLine("\nEn la biblioteca quedan " + libros + " libros.");
            //13 commit

            Console.Write("¿Cuánto dinero tienes? ");
            int diner = int.Parse(Console.ReadLine());

            dinero -= (2 * 10); // refrescos
            dinero -= 15;       // pan
            dinero -= 20;       // fruta

            Console.WriteLine("\nTe queda $" + dinero + " después de las compras.");

            //14 commit 

            Console.Write("Ingresa la primera nota: ");
            double n1 = double.Parse(Console.ReadLine());

            Console.Write("Ingresa la segunda nota: ");
            double n2 = double.Parse(Console.ReadLine());

            Console.Write("Ingresa la tercera nota: ");
            double n3 = double.Parse(Console.ReadLine());

            double promedio = (n1 + n2 + n3) / 3;

            Console.WriteLine("\nEl promedio es: " + promedio);

            if (promedio >= 11)
                Console.WriteLine("Aprobaste.");
            else
                Console.WriteLine("Reprobaste.");

            //Pruebaaaaa
            //prueba de commit



        }
    }
}
