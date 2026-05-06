internal class Program
{
    private static void Main(string[] args)
    {
        int contBoletos = 0;
        int totalDinero = 0;
        int tipo;

        do
        {
            Console.Write("Ingrese tipo de boleto (1=Adulto, 2=Niño, 0=Salir): ");
            tipo = int.Parse(Console.ReadLine());

            if (tipo == 1)
            {
                contBoletos++;
                totalDinero += 15;
            }
            else if (tipo == 2)
            {
                contBoletos++;
                totalDinero += 10;
            }

        } while (tipo != 0);

        Console.WriteLine("Total de boletos vendidos: " + contBoletos);
        Console.WriteLine("Total de dinero: $" + totalDinero);
    }
}