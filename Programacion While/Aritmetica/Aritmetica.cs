namespace Csharp_Basico_and_._NET.Aritmetica
{
    public class Aritmetica
    {
        /// <summary>
        /// Confeccionar un programa que, 
        /// a partir de una secuencia de 10 números enteros, calcule y 
        /// muestre la suma y el promedio aritmético de dichos números.
        /// </summary>
        public void CalcularAritmetica()
        {
            int suma = 0;
            int promedio = 0;
            int index = 0;
            try
            {
                while (index < 10 ) {
                    index++;
                    Console.WriteLine($"Contando en {index}");
                    suma = suma + index;
                    Console.WriteLine($"Acumulado = {suma}" );
                }
                Console.WriteLine($"Total: {suma}");
                

                promedio = suma / 10;
                Console.WriteLine($"Promedio: { promedio}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"User error {ex.Message}");
            }
        }
    }
}
