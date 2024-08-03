

namespace CalcularSueldo.Calcular
{   
    /// <summary>
    /// Este objeto es para calcular los sueldos de los operadores
    /// </summary>
    public class CalcularSueldoOperario
    {
        /// <summary>
        /// Calcular el sueldo de los operadores 
        /// </summary>
        public void Calcula()
        {
            //Declaracion de variables //
            int horasTrabajadas = 0;
            int costoHora = 0;
            int sueldo = 0;

            try
            {

                Console.WriteLine("Ingrese las horas trabajadas: ");
                horasTrabajadas = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Costo por horas: ");
                costoHora = Convert.ToInt32(Console.ReadLine());

                sueldo = horasTrabajadas * costoHora;
                Console.WriteLine($"Su sueldo es {sueldo}");
            }
            catch (Exception ex) 
            {
                Console.WriteLine($"User error: { ex.Message }");
            }
        }
    }
}
