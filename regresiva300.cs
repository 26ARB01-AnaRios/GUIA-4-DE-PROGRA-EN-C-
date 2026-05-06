internal class Program
{
    private static void Main(string[] args)
    {
        int sumaPares = 0;
        int contPrimos = 0;

        for (int i = 300; i >= 1; i--)
        {
            if (i % 2 == 0)
                sumaPares += i;

            if (i > 1)
            {
                bool esPrimo = true;

                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        esPrimo = false;
                        break;
                    }
                }

                if (esPrimo)
                    contPrimos++;
            }
        }

        Console.WriteLine("Cantidad de primos: " + contPrimos);
        Console.WriteLine("Suma de pares: " + sumaPares);
    }
}