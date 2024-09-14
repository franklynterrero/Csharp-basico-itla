namespace OOP.ejercicio2
{
    public class Libros
    {
        /// <summary>
        ///  Crea una clase Libro con las propiedades Titulo, Autor y Paginas.
        ///  Implementa un método MostrarInformacion que imprima la información del libro.
        ///  Implementa un método EsLargo que devuelva true si el libro tiene más de 500 páginas, 
        ///  o false en caso contrario.
        /// </summary>
        #region Atributos
        private string _titulos = string.Empty;
        private string _autores = string.Empty;
        private int _paginas = 0;
        #endregion

        #region Propiedades

        public string Titulos 
        { 
            get { return _titulos; }
            set { _titulos = value; }   
        }
        public string Autores 
        {
            get { return _autores; }
            set { _autores = value; }
        }
        public int Paginas
        {
            get { return _paginas; }
            set { _paginas = value; }
        }

        #endregion
        #region Metodos
        public void MostrarInformacion() 
        { 
            Console.WriteLine($"Titulo: {_titulos}");
            Console.WriteLine($"Autor: {_autores}");
            Console.WriteLine($"Paginas: {_paginas}");
        }
        public void EsLargo() 
        {
            bool eslargo = _paginas > 500;
            Console.WriteLine(eslargo);
        }
        #endregion
    }
}
