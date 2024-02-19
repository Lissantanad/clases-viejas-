using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese el pago por hora:");
        double pagoPorHora = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese las horas trabajadas:");
        int horasTrabajadas = Convert.ToInt32(Console.ReadLine());

        double sueldoBruto = pagoPorHora * horasTrabajadas;
        double descuentoAFP = sueldoBruto * 0.0285;
        double descuentoSFS = sueldoBruto * 0.0304;
        double totalDescuento = descuentoAFP + descuentoSFS;
        double sueldoNeto = sueldoBruto - totalDescuento;

        Console.WriteLine("Sueldo Bruto: " + sueldoBruto);
        Console.WriteLine("Descuento de AFP: " + descuentoAFP);
        Console.WriteLine("Total Descuento: " + totalDescuento);
        Console.WriteLine("Sueldo Neto: " + sueldoNeto);
    }
}
