using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2
{
    class Ejercicio2
    {
        static void Main(string[] args)
        {
            double hamburguesa = 2.50, tacos = 1.75, quesadillas = 1.50;
            double IVA = 0.13, producto = 0, cant = 0, subtotal = 0;

            Console.Write("Buen dia, ¿que desea ordenar?");
            Console.WriteLine("[1] - Hamburguesa");
            Console.WriteLine("[2] - Tacos");
            Console.WriteLine("[3] - Quesadillas");
            producto = Convert.ToInt32(Console.ReadLine());

            if (producto == 1)
            {
                Console.WriteLine("¿Cuantas hamburguesas desea? ");
                cant = Convert.ToDouble(Console.ReadLine());
                subtotal = cant * hamburguesa;
                Console.WriteLine("El subtotal a pagar es de: {0}", subtotal.ToString("C2"));
                Console.ReadLine();
                Console.WriteLine("Las hamburguesas tienen un IVA del 13%");
                IVA = subtotal * IVA;
                subtotal = subtotal + IVA;
                Console.WriteLine("Su IVA es de: " + IVA.ToString("C2"));
                Console.ReadLine();
                Console.WriteLine("El total a pagar es de : " + subtotal.ToString("C2"));
                Console.ReadLine();
            }
            if (producto == 2)
            {
                Console.WriteLine("¿Cuantos tacos desea ? ");
                cant = Convert.ToDouble(Console.ReadLine());
                subtotal = cant * tacos;
                Console.WriteLine("El subtotal a pagar es de: {0}", subtotal.ToString("C2"));
                Console.ReadLine();
                Console.WriteLine("Los tacos tienen un IVA del 13%");
                IVA = subtotal * IVA;
                subtotal = subtotal + IVA;
                Console.WriteLine("Su IVA es de: " + IVA.ToString("C2"));
                Console.ReadLine();
                Console.WriteLine("El total a pagar es de : " + subtotal.ToString("C2"));
                Console.ReadLine();
            }
            if (producto == 3)
            {
                Console.WriteLine("¿Cuantas quesadillas desea ? ");
                cant = Convert.ToDouble(Console.ReadLine());
                subtotal = cant * quesadillas;
                Console.WriteLine("El subtotal a pagar es de: {0}", subtotal.ToString("C2"));
                Console.ReadLine();
                Console.WriteLine("Las quesadillas tienen un IVA del 13%");
                IVA = subtotal * IVA;
                subtotal = subtotal + IVA;
                Console.WriteLine("Su IVA es de: " + IVA.ToString("C2"));
                Console.ReadLine();
                Console.WriteLine("El total a pagar es de : " + subtotal.ToString("C2"));
                Console.ReadLine();
            }
        }
    }
}
