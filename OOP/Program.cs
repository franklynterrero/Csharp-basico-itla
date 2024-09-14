//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


using OOP.ejercicio1;
using OOP.ejercicio2;
using OOP.ejercicio3;

try
{
    Cuadrante cuadrante = new Cuadrante();
    Console.WriteLine("Digite su valor para X: ");
    cuadrante.X = Convert.ToDecimal(Console.ReadLine());
    Console.WriteLine("Digite su valor para Y: ");
    cuadrante.Y = Convert.ToDecimal(Console.ReadLine());
    cuadrante.verificacionCuadrantes();
}
catch (Exception ex) 
{ 
    Console.WriteLine ($"User error: {ex.Message}");
}
//Libros libros = new Libros();
//try
//{
//    Console.WriteLine("Titulo del libro");
//    libros.Titulos = Console.ReadLine();
//    Console.WriteLine("Autor del libro");
//    libros.Autores = Console.ReadLine();
//    Console.WriteLine("Cantidad de paginas");
//    libros.Paginas = Convert.ToInt32(Console.ReadLine());
//    libros.MostrarInformacion();
//    libros.EsLargo();
//}
//catch (Exception ex)
//{
//    Console.WriteLine($"User error: {ex.Message}");
//}

//try
//{
//    Alumnos alumnos = new Alumnos();
//    Console.WriteLine("Ingrese el nombre del alumno:");
//    alumnos.Nombre = Console.ReadLine();
//    Console.WriteLine("Ingrese la matrícula del alumno:");
//    alumnos.Matricula = int.Parse(Console.ReadLine());
//    Console.WriteLine("Ingrese la carrera del alumno:");
//    alumnos.Carrera = Console.ReadLine();
//    Console.WriteLine("Ingrese sus calificaciones");
//    for (int i = 0; i < alumnos.Calificaciones.Length; i++)
//    {
//        Console.WriteLine($"Ingrese las notas del estudiante: {i}");
//        alumnos.Calificaciones[i] = Convert.ToInt32(Console.ReadLine());
//    }
//    alumnos.MostrarInformacion();
//    alumnos.calcularPromedio();
//}
//catch (Exception ex) 
//{
//    Console.WriteLine($"User error:{ex.Message}");
//}
