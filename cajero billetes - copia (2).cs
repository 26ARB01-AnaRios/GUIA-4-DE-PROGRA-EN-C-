internal class Program
{
    private static void Main(string[] args)
    {
        int totalDinero = 0;
        int contador100 = 0;

        for (int i = 1; i <= 1000; i++)
        {
            Console.Write("Ingrese billete (20, 50, 100): ");
            int billete = int.Parse(Console.ReadLine());

            totalDinero += billete;

            if (billete == 100)
            {
                contador100++;
            }
        }

        Console.WriteLine("Cantidad de billetes de 100: " + contador100);
        Console.WriteLine("Dinero total: $" + totalDinero);
    }
}