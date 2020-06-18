using System;

namespace Ejercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            int op = 0;
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Bienvenido! por favor seleccione una opción");
            Console.WriteLine("1- Ejercicio 01 | 2- Ejercicio 02 | 3- Ejercicio 03 | 4- Ejercicio 04 | 5- 100 primos");
            Console.WriteLine("----------------------------------------------");
            try 
            {
                op = int.Parse(Console.ReadLine());
            } catch(Exception e)
            {
                Console.WriteLine("Por favor ingrese solamente números");
                op = 0;
            }
            
            

            switch(op)
            {
                case 1: 
                    eje01();
                    break;
                case 2:
                    eje02();
                    break;
                case 3:
                    eje03();
                    break;
                case 4:
                    eje04();
                    break;
                case 5:
                    eje05();
                    break;
            }

        }

        static void eje05()
        {
            Console.Clear();
            int contador = 1;
            int contadorPrimo = 0;

            while (contadorPrimo <= 100)
            {
                contador++;
                if (primo(contador) == true) {
                    contadorPrimo++;
                    Console.WriteLine(contador);
                }
            }
        }

        static void eje04()
        {
            Console.Clear();
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Ejercicio 4");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Ingrese un número primo");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine(primo(numero));

        }

        static bool primo(int numero)
        {
            if (numero <= 1)
            {
                return false;
            }

            for(int i = 2; i < numero; i++)
            {
                if (numero % i == 0)
                {
                    return false;
                }
            }

            return true;
            
        }

        static void eje03()
        {
            Console.Clear();
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Ejercicio 3");
            Console.WriteLine("----------------------------------------------");

            try
            {
                Console.WriteLine("Ingrese un número");
                int numero = int.Parse(Console.ReadLine());
                if (numero % 2 == 0) {
                    Console.WriteLine(Math.Pow(numero, 3));
                } 
                else 
                {
                    Console.WriteLine(Math.Pow(numero, 2));
                }
            }
            catch(Exception e) 
            {
                Console.WriteLine("Por favor escriba solo números");
            }
        }

        static void eje02()
        {
            Console.Clear();
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Cálculo del IMC");
            Console.WriteLine("----------------------------------------------");

            Console.WriteLine("Ingrese su peso en KG");
            int masa = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese su estatura en MT");
            float estatura = float.Parse(Console.ReadLine());
            var imc = Math.Round((masa / (Math.Pow(estatura, 2))) * 10000, 2);
            Console.WriteLine($"Su IMC es {imc} %");
        }

        static void eje01()
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
