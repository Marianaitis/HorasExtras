{

    {
        Console.WriteLine("--- Horas Extras ---\n");
        
        TestarCalculo(12, 300, 0);
        TestarCalculo(12, 300, 20);
        TestarCalculo(24, 300, 0);
        TestarCalculo(24, 300, 20);
    }

    static void TestarCalculo(double salarioHora, double horasTotais, double horasExtras)
    {
        Console.WriteLine($"Salário-hora {salarioHora:C}, {horasTotais} horas, " +
                         $"{horasExtras} horas-extra, salário = {CalcularSalario(salarioHora, horasTotais, horasExtras):C}");
    }

    static double CalcularSalario(double salarioHora, double horasTotais, double horasExtras)
    {
        return (salarioHora * (horasTotais - horasExtras)) + (salarioHora * horasExtras * 1.4);
    }
}
 
