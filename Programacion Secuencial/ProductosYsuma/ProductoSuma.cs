namespace CalcularSueldo.ProductosYsuma
{
    /// <summary>
    /// Realizar la carga de dos números enteros por teclado e imprimir su suma y su producto.
    /// </summary>
    public class ProductoSuma
    {
        public void productoSumanumeros()
        {
            int num1 = 0;
            int num2 = 0;
            int producto = 0;
            int suma = 0;

            try
            {
                Console.WriteLine("Ingrese el valor de su primer numero: ");
                num1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ingrese el valor del segundo numero: ");
                num2 = Convert.ToInt32(Console.ReadLine());

                producto = num1 * num2;
                Console.WriteLine($"Valor del producto: {producto}");

                suma = num2 + num1;
                Console.WriteLine($"Valor de la suma {suma}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"User error: {ex.Message}");
            }
        }
    }
}
