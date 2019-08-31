using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2
{
    class Ejercicio5
    {
        static void Main(string[] args)
        {
            DateTime Inicio, Final;
            double precioF, costo = 0.15; 
            Console.WriteLine("Favor ingrese la hora en la que inicio la llamada");
            Inicio = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Favor ingrese la hora en la que finalizo la llamada");
            Final = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Precio a pagar por minuto de llamada: {0}", costo.ToString("C2"));
            precioF = costo * Final.Subtract(Inicio).TotalMinutes;
            Console.WriteLine("Esta es la hora en la que inicio la llamada : {0}", Inicio.ToString("HH:mm"));
            Console.WriteLine("Esta es la hora en la que finalizo la llamada : {0}", Final.ToString("HH:mm"));
            Console.WriteLine("Tiempo transcurrido de la llamada : {0} minutos", Final.Subtract(Inicio).TotalMinutes);
            Console.WriteLine("El total a pagar por su llamada es de: {0}", precioF.ToString("C2"));
            Console.ReadKey();
        }
    }
}
