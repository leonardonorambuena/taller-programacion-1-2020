using System;

namespace Ejercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            float distancia = 0, km = 0;
            Console.Clear();
            while (km <= 0)
            {    
                try
                {
                    Console.WriteLine("Ingrese los km recorridos");
                    km = float.Parse(Console.ReadLine());
                }
                catch(Exception e)
                {
                    km = showMessage();
                }
            }
            while(distancia == 0)
            {
                try
                {
                    Console.WriteLine("Ingrese distancia en segundos");
                    distancia = float.Parse(Console.ReadLine());
                }
                catch(Exception e)
                {
                    distancia = showMessage();
                }
            }

            Console.WriteLine(getResult(km, distancia));

        }

        static float showMessage()
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Por favor ingrese solo números");
            Console.WriteLine("---------------------------------");
            Console.ReadKey();
            Console.Clear();
            return 0;
        }

        static string getResult(float distancia, float tiempo)
        {
            var velocidad = distancia / tiempo;
            var vel_km = (velocidad * 3600) / 100;
            var vel_m = (velocidad*1000) / 100;
            return $"La velocidad es {vel_km} km/h o {vel_m} m/s";
        }
    }
}
