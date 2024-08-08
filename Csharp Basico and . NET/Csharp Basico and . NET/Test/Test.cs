using System.Runtime.CompilerServices;
namespace Csharp_Basico_and_._NET.Test
{
    public class Test
    {
        /// <summary>
        /// Desarrollar un programa que calcule el nivel de un postulante a partir de los resultados de un test. 
        /// El programa recibirá como entrada el número total de preguntas y las respuestas correctas, y 
        /// devolverá un nivel según el porcentaje de aciertos.
        /// Nivel máximo: Porcentaje>=90%.
        /// Nivel medio: Porcentaje>=75% y <90%.
        /// Nivel regular: Porcentaje>=50% y <75%.
        /// Fuera de nivel: Porcentaje<50%.
        /// </summary>
        public void TestPreguntas()
        {
            decimal preguntas = 0;
            decimal aciertos = 0;
            decimal porcentaje = 0;

            try
            {
                Console.WriteLine("Cuantas preguntas son?");
                preguntas = Convert.ToDecimal(Console.ReadLine());

                if (preguntas <= 0)
                {
                    Console.WriteLine("no puede ser <= 0");
                } else { 
                    Console.WriteLine("Preguntas que acerto");
                    aciertos = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine($"Usted acerto {aciertos} preguntas de {preguntas}");
                    porcentaje = (aciertos / preguntas) * 100;
                    Console.WriteLine($"{porcentaje}%");
                    if (porcentaje >= 90)
                    {
                        Console.WriteLine("Nivel maximo");
                    }
                    else if (porcentaje <= 89 && porcentaje >= 75)
                    {
                        Console.WriteLine("Nivel Medio");
                    }
                    else if (porcentaje <= 74 && porcentaje >= 50)
                    {
                        Console.WriteLine("Nivel regula");
                    }
                    else
                    {
                        Console.WriteLine("Fuera de nivel");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"User error {ex.Message}");
            }
        }
    }
}
