internal class Program
{
    private static void Main(string[] args)
    {
        int cont100 = 0;
        int total = 0;

        for (int i = 1; i <= 1000; i++)
        {
            Console.Write("Ingrese billete (20, 50, 100): ");
            int billete = int.Parse(Console.ReadLine());

            total += billete;

            if (billete == 100)
                cont100++;
        }

        Console.WriteLine("Cantidad de billetes de 100: " + cont100);
        Console.WriteLine("Total de dinero: " + total);
    }
}