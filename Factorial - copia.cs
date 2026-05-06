internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Ingrese un número: ");
        int n = int.Parse(Console.ReadLine());

        int factorial = 1;

        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
        }

        Console.WriteLine("Factorial: " + factorial);

    }
}