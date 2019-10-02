using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PorcentajeHyM
{
    class Program
    {
        static void Main(string[] args)
        {
            double Hombre = 0, Mujer = 0, total= 0, PorcentajeH = 0, porcentajeM = 0;

            Console.WriteLine("Escriba cantidad de hombres");
            Hombre = int.Parse(Console.ReadLine());

            Console.WriteLine("Escriba cantidad de mujeres");
            Mujer = int.Parse(Console.ReadLine());

            total = Hombre + Mujer;
            PorcentajeH = (Hombre / total) * 100;
            porcentajeM = (Mujer / total) * 100;

            Console.WriteLine("{0}% Son Hombres y {1}% Son Mujeres",PorcentajeH,porcentajeM);
            Console.ReadKey();
        }

    }
}
