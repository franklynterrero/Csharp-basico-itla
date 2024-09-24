namespace Sistema_de_Nomina.Class
{
    public class EmpleadoPorHoras : Empleado
    {
        public decimal Sueldo { get; set; }
        public int Horas { get; set; }

        public override decimal Calcular()
        {
            decimal valorPagar = 0;
            int horasMinimas = 40;
            decimal aumento = 0;    
            if (this.Horas <= horasMinimas) 
            {
                valorPagar = this.Sueldo * this.Horas;
            }
            else if (this.Horas > horasMinimas)
            {
                valorPagar = horasMinimas * this.Sueldo + (this.Horas - horasMinimas) * this.Sueldo * aumento;
            }

            return valorPagar;
        }
    }
}
