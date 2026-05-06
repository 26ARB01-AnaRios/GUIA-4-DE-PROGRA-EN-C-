internal class Program
{
    private static void Main(string[] args)
    {
        int suma = 0;

        for (int num = 2; num <= 22; num++)
        {
            bool esPrimo = true;

            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    esPrimo = false;
                    break;
                }
            }

            if (esPrimo)
            {
                suma += num;
            }
        }

        Console.WriteLine("La suma es: " + suma);
    }
}