namespace Sistema_de_Nomina.Class
{
    public class EmpleadoBaseMasComision : EmpleadoPorComision
    {
        public decimal SalarioBase { get; set; }

        public override decimal Calcular()
        {
            return (this.TarifaComision * this.VentasBrutas) + this.SalarioBase;
        }
    }
}
