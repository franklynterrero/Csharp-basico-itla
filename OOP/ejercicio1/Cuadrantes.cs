namespace OOP.ejercicio1
{
    public class Cuadrante
    {
        /// <summary>
        /// Desarrollar una clase que represente un punto en el plano y tenga los siguientes métodos: 
        /// cargar los valores de x e y, 
        /// imprimir en que cuadrante se encuentra dicho punto (concepto matemático, primer cuadrante 
        /// si x e y son positivas, si x<0 e y>0 segundo cuadrante, etc.
        /// </summary>

        #region Atributos
        private decimal _x = 0;
        private decimal _y = 0;
        #endregion
        #region Propiedades

        public decimal X 
        {
            get { return _x; }
            set { _x = value; }
        }
        public decimal Y 
        {
            get { return _y; }
            set { _y = value; }
        }
        #endregion
        #region Metodos
        public void verificacionCuadrantes()
        {
            if (_x > 0 && _y > 0)
            {
                Console.WriteLine("Primer cuadrante");
            }
            else if (_x < 0 && _y > 0)
            {
                Console.WriteLine("Segundo cuadrante");
            }
            else if (_x < 0 && _y < 0)
            {
                Console.WriteLine("Tercer cuadrante");
            }
            else if (_x > 0 && _y < 0)
            {
                Console.WriteLine("Cuarto cuadrante");
            }
            else
            {
                Console.WriteLine("El punto se encuentra en el origen");
            }
            #endregion
        }
    }
}
