namespace Csharp_Basico_and_._NET.Conjuntos
{
    public class conjuntos
    {
        /// <summary>
        /// Crear un programa que cuente cuántos números, de un conjunto de 10,
        /// son divisibles por 3 o por 5.   
        /// </summary>
        public void CalcularConjuntos()
        {
            int conjuntos = 0;
            try
            {
                for (int i = 1; i <= 10; i++)
                {
                    if (i % 3 == 0 || i % 5 == 0 )
                    {
                        conjuntos = conjuntos + 1;
                        Console.WriteLine($"Este numero se puede dividr: {i}");
                    }  
                }
                Console.WriteLine($"Cantidad de numeros que se pueden dividir {conjuntos}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"User Error {ex.Message}");
            }
        }
    }
}
