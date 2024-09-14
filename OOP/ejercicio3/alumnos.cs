using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.ejercicio3
{
    public class Alumnos
    {
        /// <summary>
        /// Crea una clase Alumno con las propiedades Nombre, Matricula, Carrera y Calificaciones(una lista de enteros).
        /// Implementa un método CalcularPromedio que devuelva el promedio de las calificaciones.
        /// Implementa un método MostrarInformacion que imprima el nombre, la matrícula, la carrera y el 
        /// promedio del alumno
        /// Crea instancias de la clase Alumno, asigna valores a las propiedades y muestra la información.
        /// </summary>  
        /// 
        #region atributos
        private string _nombre;
        private int _matricula;
        private string _carrera;
        private int[] _calificaciones = new int[3];
        #endregion

        #region "propiedades"
        
        public string Nombre 
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        public int Matricula 
        {
            get { return _matricula; }
            set { _matricula = value; }
        }
        public string Carrera 
        {
            get { return _carrera; }
            set { _carrera = value; }
        }
        public int[] Calificaciones 
        {
            get { return _calificaciones; }
            set { _calificaciones = value; }
        }

        #endregion
        
        #region "metodos" 
        public void calcularPromedio()
        {
            int promedio = 0;
            int sumatoria = 0;
            for (int i = 0; i < _calificaciones.Length; i++)
            {
                sumatoria = sumatoria + _calificaciones[i];
            }
            promedio = sumatoria / _calificaciones.Length;
            Console.WriteLine($"El promedio es: {promedio}");
        }
        public void MostrarInformacion()
        {
            Console.WriteLine($"Nombre: {_nombre}");
            Console.WriteLine($"Matricula: {_matricula}");
            Console.WriteLine($"Carrera: {_carrera}");
        }
        #endregion 


    }
}
