using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2
{
    class Ejercicio6
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fecha y hora actual.");
            DateTime fecha = DateTime.Now;
            DateTime hora = DateTime.Now;
            Console.WriteLine("Hoy es {0}{1} de {2} de {3} y son las {4}",fecha.ToString("dddd"), fecha.Day, fecha.ToString("MMM"), fecha.Year, hora.ToString("hh:mm"));
        }
    }
}
