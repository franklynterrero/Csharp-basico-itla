using System.ComponentModel;

namespace Csharp_Basico_and_._NET.Sueldos
{
    public class SueldosEmpresa
    {
        /// <summary>
        /// En una empresa trabajan n empleados cuyos sueldos oscilan entre $100 y $500, realizar un programa 
        /// que lea los sueldos que cobra cada empleado e informe cuántos empleados cobran entre $100 y $300 y 
        /// cuántos cobran más de $300. 
        /// Además el programa deberá informar el importe que gasta la empresa en sueldos al personal.
        /// </summary>
        public void CalcularSueldoEmpres()
        {
            int n = 0;
            int index = 0;
            int sueldo = 0;
            int superior = 0;
            int sueldoPromedio = 0;
            int sueldoBajo = 0;
            int nomina = 0;
            try
            {
                Console.WriteLine("Cantidad de empleados: ");
                n = Convert.ToInt32(Console.ReadLine());
                while (index < n)
                {
                    index = index + 1;
                    Console.WriteLine($"Sueldo del trabajador: ({index})");
                    sueldo = Convert.ToInt32(Console.ReadLine());
                    nomina = sueldo + nomina;
                    if (sueldo > 300)
                    {
                        superior = superior + 1;   
                    } else if ( sueldo <= 300 && sueldo > 100)
                    {
                        sueldoPromedio = sueldoPromedio + 1;
                    }else
                    {
                        sueldoBajo = sueldoBajo + 1;
                    }
                }
                Console.WriteLine($"Mayores de 300: ({superior}), sueldo entre 100 y 300: {sueldoPromedio} y " +
                    $"emplados con el sueldo bajo: {sueldoBajo}");
                Console.WriteLine($"Total de gastos en nomina: {nomina}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"User Error: {ex.Message}"); 
            }
        }
    }
}
