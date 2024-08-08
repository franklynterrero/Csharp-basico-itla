namespace Csharp_Basico_and_._NET.Calificaciones
{
    public class Calificaciones
    { 
        /// <summary>
        /// Esto ayuda a calcular el promedio de calificaciones de los estudiantes. Mayor o igual a 7 Aprobado!
        /// Menor que 7, no aprobado
        /// </summary>
        public void CalcularCalificaiones()
        {
            decimal nota1 = 0;
            decimal nota2 = 0;
            decimal nota3 = 0;
            decimal promedio = 0;

            try
            {
                // Capturar notas
                Console.WriteLine("inserte nota 1: ");
                nota1 = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("inserte nota 2: ");
                nota2 = Convert.ToDecimal(Console.ReadLine()); 
                Console.WriteLine("inserte nota 3: ");
                nota3 = Convert.ToDecimal(Console.ReadLine());

                // Calcular promedio
                promedio = (nota1 + nota2 + nota3) / 3;
                Console.WriteLine($"Su promedio de calificacion es: {promedio} ");


                // Evaluacion
                if (promedio >= 7)
                {
                    Console.WriteLine("Felcidades has aprobado!");
                } else
                {
                    Console.WriteLine("Debes seguir practicando");
                }
            }
            catch (Exception ex) {
                Console.WriteLine($"User erro: {ex.Message}");
            }
        
        }
    }
}
