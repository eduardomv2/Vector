using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vector
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Solicitar al usuario la dimensión del vector
            Console.Write("Ingrese la dimensión del vector: ");
            if (int.TryParse(Console.ReadLine(), out int dimension) && dimension > 0)
            {
                // Crear un arreglo para almacenar el vector
                double[] vector = new double[dimension];

                // Pedir al usuario que ingrese las componentes una por una
                for (int i = 0; i < dimension; i++)
                {
                    Console.Write($"Ingrese el componente {i + 1}: ");
                    if (double.TryParse(Console.ReadLine(), out double component))
                    {
                        vector[i] = component; // Almacenar la componente en el arreglo
                    }
                    else
                    {
                        Console.WriteLine("¡Valor inválido! Inténtelo de nuevo.");
                        i--; // Reintentar la misma posición
                    }
                }

                // Mostrar el vector generado
                Console.WriteLine("Vector generado:");
                PrintVector(vector);
            }
            else
            {
                Console.WriteLine("Dimensión inválida.");
            }
        }

        // Función para mostrar el vector en la consola
        static void PrintVector(double[] vector)
        {
            Console.Write("[");
            for (int i = 0; i < vector.Length; i++)
            {
                Console.Write(vector[i]);
                if (i < vector.Length - 1)
                {
                    Console.Write(", "); // Agregar coma y espacio entre componentes
                }
            }
            Console.WriteLine("]");
            Console.ReadKey();
        }
    }
}
    
