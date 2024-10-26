public abstract class Nomina
{
    public enum TipoNomina { Mensual, Semanal, Quincenal }
    public TipoNomina Tipo {  get; set; }
    protected decimal TotalIngresos {  get; set; }
    protected decimal Deducciones { get; set; }
    public decimal SalarioNeto {  get; set; }

    public abstract void CalcularTotalIngreso(Empleado empleado);
    public abstract void CalcularDeducciones(Empleado empleado);
    public void CalcularSalarioNeto()
    {
        SalarioNeto = TotalIngresos - Deducciones;
    }

}



