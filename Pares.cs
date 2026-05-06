internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Ingrese un número: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 2; i <= n; i += 2)
        {
            Console.WriteLine(i);
        }
    }
}