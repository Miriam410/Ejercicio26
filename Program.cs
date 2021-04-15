using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio26
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 26. Solicite el ingreso de una fecha al usuario y le presente: el día,el número,
                    y nombre del mes y el nombre y número del día de la semana*/
            FECHAS();

            Console.WriteLine("------------------------------------------------------------------");
            /* 27. Solicite el ingreso de una fecha al usuario y presente las fechas 30. 60,90 y 180 días
             posteriores a la ingresada*/
            DiasDespuesDeLaFechaIngresada();
        }

        private static void FECHAS()
        {
            Console.WriteLine("Ingrese una fecha");
            DateTime fecha = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine($"La fecha ingresada es: {fecha}");
            Console.WriteLine($"El dìa es: {fecha.Day}");
            Console.WriteLine($"El año es: {fecha.Year}");
            Console.WriteLine($"El numero del mes es: {fecha.Month}");
            Console.WriteLine($"El nombre del mes es: {fecha.ToString("MMMM")}");
            Console.WriteLine($"El número de la semana: {fecha.Day}");
            Console.WriteLine($"El nombre de la semana es: {fecha.DayOfWeek.ToString()}");

            Console.WriteLine("Presione una tecla para salir");
            Console.ReadKey();
        }
        private static void DiasDespuesDeLaFechaIngresada()
        {
            Console.WriteLine("Ingrese una fecha");
            DateTime ingresoFecha = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine($"La fecha ingresada es: {ingresoFecha}");
            Console.WriteLine($"Luego de 30 dìas son: {ingresoFecha.AddDays(30)}"); ;
            Console.WriteLine($"Luego de 60 días son: { ingresoFecha.AddDays(60)}");
            Console.WriteLine($"Luego de 90 días son: {ingresoFecha.AddDays(90)}");
            Console.WriteLine($"Luego de 180 días son: {ingresoFecha.AddDays(180)}");
            Console.WriteLine("Presione una tecla para salir");
            Console.ReadKey();
        }

       
    }
}
