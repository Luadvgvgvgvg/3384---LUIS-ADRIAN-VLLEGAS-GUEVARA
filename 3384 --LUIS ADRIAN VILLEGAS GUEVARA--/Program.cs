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
            //Datos de alumno.
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("3384 - LUIS ADRIAN VILLEGAS GUEVARA");
            Console.WriteLine("INGENIERÍA EN SISTEMAS COMPUTACIONALES");
            Console.WriteLine("Trabajo en CLASE - Guardando commits");
            Console.WriteLine("---------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.White;



            // ------------------ 1 EJERCICIO ------------------
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("-----------------------------------");
            Console.WriteLine(" 1 EJERCICIO - DATOS DEL ALUMNO");
            Console.WriteLine("-----------------------------------");
            Console.ForegroundColor = ConsoleColor.White;

            string nombre;
            int edad;
            float estatura;
            int anionacimiento;

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

            Console.WriteLine("Su nombre es: " + nombre);
            Console.WriteLine("Su edad es: " + edad);
            Console.WriteLine("Su estatura es: " + estatura);
            Console.WriteLine(nombre + " Tu edad es " + edad + " años, y naciste en el año " + anionacimiento);


            // ------------------ 2 EJERCICIO ------------------
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("-----------------------------------");
            Console.WriteLine(" 2 EJERCICIO - PAR O IMPAR");
            Console.WriteLine("-----------------------------------");
            Console.ForegroundColor = ConsoleColor.White;

            Console.Write("Ingresa un número: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine("El número es par.");
            }
            else
            {
                Console.WriteLine("El número es impar.");
            }


            // ------------------ 3 EJERCICIO ------------------
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("-----------------------------------");
            Console.WriteLine(" 3 EJERCICIO - MANZANAS JUAN");
            Console.WriteLine("-----------------------------------");
            Console.ForegroundColor = ConsoleColor.White;

            int manzanasJuan = 10;
            int manzanasDadas = 3;
            int resultado = manzanasJuan - manzanasDadas;

            Console.WriteLine("A Juan le quedan " + resultado + " manzanas.");


            // ------------------ 4 EJERCICIO ------------------
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("-----------------------------------");
            Console.WriteLine(" 4 EJERCICIO - PASAJEROS");
            Console.WriteLine("-----------------------------------");
            Console.ForegroundColor = ConsoleColor.White;

            int pasajeros = 20;
            pasajeros += 5; // suben
            pasajeros -= 2; // bajan
            Console.WriteLine("En el autobús hay " + pasajeros + " pasajeros.");


            // ------------------ 5 EJERCICIO ------------------
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("-----------------------------------");
            Console.WriteLine(" 5 EJERCICIO - PASTEL");
            Console.WriteLine("-----------------------------------");
            Console.ForegroundColor = ConsoleColor.White;

            int pastel = 8;
            int comido = 2;
            int repartido = 3;
            int restante = pastel - (comido + repartido);

            Console.WriteLine("Quedan " + restante + " porciones de pastel.");


            // ------------------ 6 EJERCICIO ------------------
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("-----------------------------------");
            Console.WriteLine(" 6 EJERCICIO - MANZANAS JUAN Y PEDRO");
            Console.WriteLine("-----------------------------------");
            Console.ForegroundColor = ConsoleColor.White;

            int juan = 12;
            int pedro = 8;

            Console.WriteLine("Al inicio:");
            Console.WriteLine("Juan tiene " + juan + " manzanas.");
            Console.WriteLine("Pedro tiene " + pedro + " manzanas.\n");

            juan -= 3;
            pedro += 3;
            Console.WriteLine("Después de que Juan le da 3 manzanas a Pedro:");
            Console.WriteLine("Juan tiene " + juan + " manzanas.");
            Console.WriteLine("Pedro tiene " + pedro + " manzanas.\n");

            pedro -= 2;
            Console.WriteLine("Después de que Pedro se come 2 manzanas:");
            Console.WriteLine("Juan tiene " + juan + " manzanas.");
            Console.WriteLine("Pedro tiene " + pedro + " manzanas.\n");

            juan += 5;
            Console.WriteLine("Después de que Juan compra 5 manzanas más:");
            Console.WriteLine("Juan tiene " + juan + " manzanas.");
            Console.WriteLine("Pedro tiene " + pedro + " manzanas.\n");

            int total = juan + pedro;
            juan = total / 2;
            pedro = total / 2;
            Console.WriteLine("Después de repartir las manzanas por igual:");
            Console.WriteLine("Juan tiene " + juan + " manzanas.");
            Console.WriteLine("Pedro tiene " + pedro + " manzanas.");


            // ------------------ 7 EJERCICIO ------------------
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("-----------------------------------");
            Console.WriteLine(" 7 EJERCICIO - DINERO MARÍA");
            Console.WriteLine("-----------------------------------");
            Console.ForegroundColor = ConsoleColor.White;

            Console.Write("¿Cuánto dinero tiene María al inicio? ");
            int dinero = int.Parse(Console.ReadLine());

            dinero -= 15; // compra dulces
            dinero += 20; // ahorra más
            Console.WriteLine("Ahora María tiene $" + dinero);


            // ------------------ 8 EJERCICIO ------------------
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("-----------------------------------");
            Console.WriteLine(" 8 EJERCICIO - BIBLIOTECA");
            Console.WriteLine("-----------------------------------");
            Console.ForegroundColor = ConsoleColor.White;

            Console.Write("¿Cuántos libros había en la biblioteca al inicio? ");
            int libros = int.Parse(Console.ReadLine());

            Console.Write("¿Cuántos libros se prestaron? ");
            libros -= int.Parse(Console.ReadLine());

            Console.Write("¿Cuántos libros se devolvieron? ");
            libros += int.Parse(Console.ReadLine());

            Console.WriteLine("\nEn la biblioteca quedan " + libros + " libros.");


            // ------------------ 9 EJERCICIO ------------------
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("-----------------------------------");
            Console.WriteLine(" 9 EJERCICIO - COMPRAS");
            Console.WriteLine("-----------------------------------");
            Console.ForegroundColor = ConsoleColor.White;

            Console.Write("¿Cuánto dinero tienes? ");
            int diner = int.Parse(Console.ReadLine());

            dinero -= (2 * 10); // refrescos
            dinero -= 15;       // pan
            dinero -= 20;       // fruta
            Console.WriteLine("Te queda " + dinero + " dinero después de las compras.");


            // ------------------ 10 EJERCICIO ------------------
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("-----------------------------------");
            Console.WriteLine(" 10 EJERCICIO - PROMEDIO NOTAS");
            Console.WriteLine("-----------------------------------");
            Console.ForegroundColor = ConsoleColor.White;

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


            // ------------------ 11 EJERCICIO ------------------
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("-----------------------------------");
            Console.WriteLine(" 11 EJERCICIO - EDAD FUTURA");
            Console.WriteLine("-----------------------------------");
            Console.ForegroundColor = ConsoleColor.White;

            Console.Write("Ingresa tu nombre: ");
            string nombr = Console.ReadLine();
            Console.Write("Ingresa tu edad: ");
            int eda = int.Parse(Console.ReadLine());

            Console.WriteLine($"Hola {nombr}, en 10 años tendrás {eda + 10} años.");


            // ------------------ 12 EJERCICIO ------------------
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("-----------------------------------");
            Console.WriteLine(" 12 EJERCICIO - ÁREA RECTÁNGULO");
            Console.WriteLine("-----------------------------------");
            Console.ForegroundColor = ConsoleColor.White;

            Console.Write("Ingresa la base del rectángulo: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Ingresa la altura del rectángulo: ");
            double h = double.Parse(Console.ReadLine());

            double area = b * h;
            Console.WriteLine($"El área del rectángulo es: {area}");


            // ------------------ 13 EJERCICIO ------------------
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("-----------------------------------");
            Console.WriteLine(" 13 EJERCICIO - SWITCH DÍAS");
            Console.WriteLine("-----------------------------------");
            Console.ForegroundColor = ConsoleColor.White;

            Console.Write("Ingresa un número del 1 al 7: ");
            int dia = int.Parse(Console.ReadLine());
            Console.Beep(800, 500);

            switch (dia)
            {
                case 1: Console.WriteLine("Lunes"); break;
                case 2: Console.WriteLine("Martes"); break;
                case 3: Console.WriteLine("Miércoles"); break;
                case 4: Console.WriteLine("Jueves"); break;
                case 5: Console.WriteLine("Viernes"); break;
                case 6: Console.WriteLine("Sábado"); break;
                case 7: Console.WriteLine("Domingo"); break;
                default: Console.WriteLine("Número inválido"); break;

            }
            // ------------------ 14 EJERCICIO ------------------
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("-----------------------------------");
            Console.WriteLine(" 14 EJERCICIO - SWITCH DÍAS");
            Console.WriteLine("-----------------------------------");
            Console.ForegroundColor = ConsoleColor.White;


            // Pedir datos al usuario
            Console.WriteLine("Ingrese el precio del producto:");
            double precio = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el porcentaje de descuento (ejemplo: 15 para 15%):");
            double descuento = double.Parse(Console.ReadLine());

            // Calcular el monto de descuento
            double montoDescuento = (precio * descuento) / 100;

            // Calcular precio final
            double precioFinal = precio - montoDescuento;

            // Mostrar resultados
            Console.WriteLine("\n-------------------------------");
            Console.WriteLine("Precio original: " + precio);
            Console.WriteLine("Descuento aplicado: " + descuento + "%");
            Console.WriteLine("Monto descontado: " + montoDescuento);
            Console.WriteLine("Precio final a pagar: " + precioFinal);



        }
    }
}
