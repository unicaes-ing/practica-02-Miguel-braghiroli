using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2
{
    class Ejercicio4
    {
        static void Main(string[] args)
        {
            DateTime FechInicio; 
            DateTime FechFinal; 
            double Pago = 0, Dia = 15;

            Console.WriteLine("Bienvenido a Miguel's Cars");
            Console.WriteLine("Favor ingrese la fecha en que incio el alquiler del vehiculo");
            FechInicio = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Favor ingrese la fecha de la devolucion del vehiculo");
            FechFinal = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("El precio diario sera de : {0}", Dia.ToString("C2"));
            Pago = Dia * FechFinal.Subtract(FechInicio).Days;
            Console.WriteLine("Inicio del alquiler del vehiculo: ");
            Console.WriteLine(FechInicio.ToString("dd/MM/yyyy"));
            Console.WriteLine("Devolucion del vehiculo: ");
            Console.WriteLine(FechFinal.ToString("dd/MM/yyyy"));
            Console.WriteLine(FechFinal.Subtract(FechInicio).Days + " Dias ");
            Console.WriteLine("El total a pagar por el alquiler es de : {0}", Pago.ToString("C2"));
            Console.ReadKey();
        }
    }
}
