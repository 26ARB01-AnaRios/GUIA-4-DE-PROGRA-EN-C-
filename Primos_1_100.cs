internal class Program
{
    private static void Main(string[] args)
    {
        int contador = 0;
        int suma = 0;

        for (int i = 2; i <= 100; i++)
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
            {
                contador++;
                suma += i;
            }
        }

        Console.WriteLine("Cantidad de primos: " + contador);
        Console.WriteLine("Suma de primos: " + suma);
    }
}