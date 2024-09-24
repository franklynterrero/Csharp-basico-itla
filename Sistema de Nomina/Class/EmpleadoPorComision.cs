namespace Sistema_de_Nomina.Class
{
    public class EmpleadoPorComision : Empleado
    {
        public decimal VentasBrutas { get; set; }
        public decimal TarifaComision { get; set; }

        public override decimal Calcular()
        {
            return this.VentasBrutas * this.TarifaComision;
        }
    }
}
