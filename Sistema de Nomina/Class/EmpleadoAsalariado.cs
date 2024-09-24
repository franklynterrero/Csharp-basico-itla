namespace Sistema_de_Nomina.Class
{
    public class EmpleadoAsalariado : Empleado
    {
        public decimal SalarioSemanal {  get; set; }

        public override decimal Calcular()
        {
            return this.SalarioSemanal;
        }
    }
}
