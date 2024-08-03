namespace CalcularSueldo.Promedio
{
    public class PromedioNumeros
    {
        /// <summary>
        /// Realizar un programa que lea cuatro valores numéricos e informar su suma y promedio.
        /// </summary>
        public void PromediodeNumeros()
        {
            decimal num1 = 0;
            decimal num2 = 0;
            decimal num3 = 0;
            decimal num4 = 0;
            decimal suma = 0;
            decimal promedio = 0;

            try
            {
                Console.WriteLine("Ingrese el primer valor: ");
                num1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ingrese el segundo valor: ");
                num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ingrese el tercero valor: ");
                num3 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ingrese el cuarto valor: ");
                num4 = Convert.ToInt32(Console.ReadLine());

                suma = num1 + num2 + num3 + num4;
                Console.WriteLine($"La suma es {suma}");

                promedio = (num1 + num2 + num3 + num4) / 4;

                Console.WriteLine($"Este es su promedio {promedio}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Este ocurrior: {ex.Message}");
            }
        }
    }
}
