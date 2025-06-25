using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numerosvector = new int[100];
            int contador = 0;

            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Ingrese un numero entero, cuando desee dejar de ingresar numeros escriba -1");
                int numero = Convert.ToInt32(Console.ReadLine());

                if (numero == -1)
                {
                    break;
                }
                else
                {
                    numerosvector[contador] = numero;
                    contador++;
                }
            }

            Console.WriteLine("Listado de números ingresados:");
            for (int i = 0; i < contador; i++)
            {
                Console.WriteLine(i + ": " + numerosvector[i]);
            }

            int suma = 0;
            for (int i = 0; i < contador; i++)
            {
                suma += numerosvector[i];
            }
                double promedio = (double)suma / contador;

                Console.WriteLine($"El promedio es: {promedio}");

            int maximo = numerosvector[0];
            int indiceMaximo = 0;

            for (int i = 1; i < contador; i++)
            {
                if (numerosvector[i] > maximo)
                {
                    maximo = numerosvector[i];
                    indiceMaximo = i;
                }
            }

            Console.WriteLine("\nEl valor máximo es: " + maximo + " y se encuentra en la posición: " + indiceMaximo);

        }
    }
}