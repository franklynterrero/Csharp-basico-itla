namespace Csharp_Basico_and_._NET.Piezas
{
    public class piezas
    {
        /// <summary>
        ///  Crear un programa que cuente cuántas piezas de hierro de un lote, 
        ///  dentro de un rango específico de longitud, son aptas para fabricar perfiles
        /// </summary>
        public void CalcularPiezas()
        {
            int piezas = 0;
            int longitud = 0;
            int cantidad = 0;
            int limiteMax = 0;
            int limiteMin = 0;
            int aprobada = 0;
            int desapobrada = 0;
            int i = 1;
            
            try
            {
                Console.WriteLine("Cuantas piezas desea revisar");
                cantidad = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Cual es el limite Minimo para aprobar");
                limiteMin = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Cual es el limite Maximo para aprobar");
                limiteMax = Convert.ToInt32(Console.ReadLine());
                while (i <= cantidad)
                {
                    Console.WriteLine($"Digite la longitud de su pieza {i} en cm");
                    longitud = Convert.ToInt32(Console.ReadLine());
                    i++;

                    if (longitud >= limiteMin && longitud <= limiteMax)
                    {
                        Console.WriteLine("Aprobada");
                        aprobada++;
                    } else
                    {
                        Console.WriteLine("desaprobada");
                        desapobrada++;
                    }        
                }
                Console.WriteLine($"Aprobadas: {aprobada} , desaprobadas: {desapobrada}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"User error {ex.Message}");
            }

        }
    }
}
