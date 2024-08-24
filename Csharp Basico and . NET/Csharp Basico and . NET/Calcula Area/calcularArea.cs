namespace Csharp_Basico_and_._NET.Calcula_Area
{
    /// <summary>
    /// Solicite al usuario ingresar un número entero "n" que represente la cantidad de triángulos a procesar.
    /// Para cada triángulo, capture los valores de la base y la altura.
    /// Calcule el área de cada triángulo utilizando la fórmula correspondiente.
    /// Muestre en pantalla los datos de cada triángulo (base, altura y área).
    /// Determine y reporte la cantidad de triángulos con un área superior a 12 unidades cuadradas.
    /// </summary>
    public class calcularArea
    {
        public void CalcularAreaTriangulos()
        {
            int area = 0;
            int n = 0;
            int trianguloBase = 0;
            int trianguloAltura = 0;
            int superior = 0;
            try
            {
                Console.WriteLine("Cuantos triangulos desea revisar: ");
                n = Convert.ToInt32(Console.ReadLine());
                for (int i = 1; i <= n; i++)
                {
                    Console.WriteLine($"Altura del triangulo: ({i})");
                    trianguloAltura = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Base del triangulo: ({i})");
                    trianguloBase = Convert.ToInt32(Console.ReadLine());
                    area = (trianguloAltura * trianguloBase) / 2;
                    Console.WriteLine($"Area = {area} del triangulo: ({i})");
                    if (area > 12) { 
                        superior = superior + 1;
                    }
                }
                Console.WriteLine($"{superior} triangulos con area mayor a 12");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"User error: {ex.Message}");
            }
        }
        
    }
}
