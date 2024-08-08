namespace Csharp_Basico_and_._NET.Calcular_2_numeros
{
    public class Calcular
    {
        /// <summary>
        /// Diseñar un programa que solicite al usuario dos números y, si el primer número es más grande, 
        /// calcule y muestre su suma y resta.
        /// De lo contrario, calculará y mostrará su producto y cociente.
        /// </summary>
        public void CalcularNumeros() 
        {
            decimal num1 = 0;
            decimal num2 = 0;
            decimal sum = 0;
            decimal rest = 0;
            decimal produc  = 0;
            decimal divi = 0;

            try
            {
                Console.WriteLine("Introduzca el valor del primer numero: ");
                num1 = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Introduzca el valor del segundo numero: ");
                num2 = Convert.ToDecimal(Console.ReadLine());

                if (num1 > num2)
                {
                    sum = num1 + num2;
                    rest = num1 - num2;
                    Console.WriteLine($"El valor del primer numero ({num1}) es mayor que el segundo ({num2}) por lo tanto" +
                        $" la sumas es {sum} y la resta es {rest}");
                }
                else
                {
                    produc = num1 * num2;
                    divi = num1 / num2;
                    Console.WriteLine($"El valor del primer numero ({num1}) es menor que el segundo ({num2}) por lo tanto" +
                        $" el producto es {produc} y la division es {divi}");

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error del usuario {ex.Message}");
            }
        }
    }
}
