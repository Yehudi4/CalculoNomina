public class NominaMensual : Nomina
{
    public override void CalcularDeducciones(Empleado empleado)
    {
        decimal INSSLaboral = 0.07m;
        
    }

    public override void CalcularTotalIngreso(Empleado empleado)
    {
        TotalIngresos = empleado.calcularSalarioBruto() + empleado.CalculoAntiguedad();
    }
}

