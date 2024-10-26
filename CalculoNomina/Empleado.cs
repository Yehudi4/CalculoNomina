public class Empleado
{
    public string Nombre { get; set; }
    public int ID { get; set; }
    public string Departamento { get; set; }
    public decimal SalarioMensual { get; set; }
    public int HorasExtras { get; set; }
    public int Antiguedad { get; set; }

    public Empleado(string nombre, int id, string departamento, decimal salarioMensual, int horasExtras, int antiguedad)
    {
        Nombre = nombre;
        ID = id;
        Departamento = departamento;
        SalarioMensual = salarioMensual;
        HorasExtras = horasExtras;
        Antiguedad = antiguedad;
    }
    public decimal CalculoAntiguedad()
    {
        decimal antiguedad = SalarioMensual * 0.02m * Antiguedad;
        return antiguedad;
    }
    public decimal calcularSalarioBruto()
    {
        decimal horasExtras = ((SalarioMensual / 30) / 8 * HorasExtras * 2);
        decimal salarioBruto = SalarioMensual + horasExtras;
        return salarioBruto;
    }

}



