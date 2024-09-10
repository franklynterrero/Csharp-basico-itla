using Mod2_Itla.arreglo1;
using System;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.ConstrainedExecution;
using System.Runtime.ExceptionServices;

namespace Mod2_Itla
{
    internal class Program
    {
        private static int[] matrix;
        
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //Arreglo1();
            //Imprimir();
            //Arreglo2();
            Arreglo3();
        }
        static void Arreglo1()
        {
            //Escribe un programa que cree una matriz de 20 elementos de tipo entero e inicialice cada uno 
            //de los elementos con un valor igual al índice del elemento multiplicado por 5. 
            //Imprime los elementos en la consola.
            matrix = new int[20];
            try
            {
                for (int i = 1; i < matrix.Length; i++)
                {
                    Console.WriteLine($"Ingreses sus numeros: {i}");
                    matrix[i] = i * 5;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"User error: {ex.Message}");
            }

        }
        static void Imprimir()
        {
            for (int i = 0; i < matrix.Length; i++)
            {
                Console.WriteLine("{0}{1,8}", "indice", "Matrix", "Incremento x 5");
                Console.WriteLine("{0}{1,8}", i, matrix[i]);
            }
        }
        static void Arreglo2()
        {
            //Escriba un programa que lea dos matrices desde la consola 
            //y verifique si son iguales(dos matrices son iguales cuando tienen la misma longitud
            //y todos sus elementos, que tienen el mismo índice, son iguales).
            int limite1 = 0;
            int limite2 = 0;
            try
            {
                Console.WriteLine("Elija la longitud de su 1er array: ");
                limite1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Elija la longitud de su 2do array");
                limite2 = Convert.ToInt32(Console.ReadLine());
                int[] matrix1 = new int[limite1];
                int[] matrix2 = new int[limite2];
                if (limite1 == limite2)
                {
                    for (int i = 0; i < limite1; i++) //capturar 1era matrix
                    {
                        Console.WriteLine("Primera matrix");
                        matrix1[i] = Convert.ToInt32(Console.ReadLine());
                    }
                    for (int j = 0; j < limite2; j++) // caputrar 2da matrix
                    {
                        Console.WriteLine("Segunda matrix");
                        matrix2[j] = Convert.ToInt32(Console.ReadLine());
                    }
                    for (int i = 0; i < limite1; i++)//mostrar la primera matriz
                    {
                        Console.WriteLine($"Matrix 1: ({i},{matrix1[i]})");
                    }
                    for (int j = 0; j < limite2; j++)//mostrar la segunda matriz
                    {
                        Console.WriteLine($"Matrix 2: ({j}, {matrix2[j]})");
                    }
                    for (int i = 0; i < limite1; i++)
                    {
                        if (matrix1[i] == matrix2[i])
                        {
                            Console.WriteLine($"Son iguales");
                        } else
                        {
                            Console.WriteLine($"No son iguales. Matrix1: ({matrix1[i]}), Matrix2: ({matrix2[i]})");
                        }
                    }
                }   else
                {
                    Console.WriteLine("Los indices no son iguales");
                }
            } catch (Exception ex)
            {
                Console.WriteLine($"User errro {ex.Message}");
            }
        }
        static void Arreglo3()
        {
            //Crear un programa que solicite al usuario "N" números, 
            //almacenarlos en una estructura de datos lineal y determinar lo siguiente:
            //El menor valor.
            //Indicar si algún valor se repite al menos una vez
            int n = 0;
            Console.WriteLine("Ingrese la cantidad de numeros que desea.");
            n = Convert.ToInt32(Console.ReadLine());
            int[] almacen1 = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Introduzca sus valores:  indice: {i} ");
                almacen1[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"({i}, {almacen1[i]})"); 
            }
            int valorMinimo = almacen1.Min();
            Console.WriteLine($"El valor minimo es: {valorMinimo}");
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++) // Comparar cada número con los demás
                {
                    if (almacen1[i] == almacen1[j])
                    {
                        Console.WriteLine($"El número {almacen1[i]} se repite.");
                        break;
                    }
                }
            }
        }
    }
}

