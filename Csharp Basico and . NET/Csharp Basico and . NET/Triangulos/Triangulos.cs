namespace Csharp_Basico_and_._NET.Triangulos
{
    public class Triangulos
    {
        /// <summary>
        ///  1) Dado un conjunto de datos representando las dimensiones de triángulos, 
        ///  calcular y contar aquellos cuya área excede un valor límite.
        /// </summary>
        public void CalcularDimensiones()
        {
            int limite = 0;
            int triangulos = 0;
            int cantidad = 0;
            int superior = 0;
            int inferior = 0;
            try
            {
                Console.WriteLine("Cual es su limite? ");
                limite = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Cuantos triangulos desea registrar?");
                cantidad = Convert.ToInt32(Console.ReadLine());
                for (int i = 1; i <= cantidad; i++)
                {
                    Console.WriteLine($"Digite el valor del area del triangulo {i}");
                    triangulos = Convert.ToInt32(Console.ReadLine());
                    if (triangulos > limite)
                    {
                        superior++;
                    }
                    else
                    {
                        inferior++;
                    }
                }
                Console.WriteLine($"Cantidad de triangulos superiores al limite: {superior}, Cantidad de triangulos menores al limite {inferior}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error revisar: {ex.Message}");
            }
        }
    }
}
