namespace Csharp_Basico_and_._NET.Suma_Conjunto
{
    public class SumaConjuntos
    {
        /// <summary>
        /// 3) Desarrollar un programa que permita ingresar 10 números y
        /// luego muestre la suma de los últimos 5 números ingresados.
        /// </summary>
        public void SumaFinalesConjuntos()
        {
            int conjuntos = 0;
            int suma = 0;
            try
            {
                for (int i = 1; i <= 10; i++)
                { 
                    Console.WriteLine($"Introduzca sus numeros {i}");
                    conjuntos = Convert.ToInt32(Console.ReadLine()); 
                    if (i > 5)
                    {
                        suma = suma + conjuntos;
                        Console.WriteLine($"Sumatoria: {suma}");
      
                    }
                }
                Console.WriteLine($"La suma total es: {suma}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"User Error {ex.Message}");
            }
        }
    }
}