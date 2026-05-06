internal class Program
{
    private static void Main(string[] args)
    {
        int suma = 0;
        int contPares = 0;

        for (int i = 1; i <= 20; i++)
        {
            int num = i * 7;
            suma += num;

            if (num % 2 == 0)
                contPares++;
        }

        Console.WriteLine("Suma: " + suma);
        Console.WriteLine("Cantidad de pares: " + contPares);
    }
}