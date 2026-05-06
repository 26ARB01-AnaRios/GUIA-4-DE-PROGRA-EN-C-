internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Ingrese primer número: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Ingrese segundo número: ");
        int num2 = int.Parse(Console.ReadLine());

        int menor = Math.Min(num1, num2);
        int mayor = Math.Max(num1, num2);

        for (int i = menor; i <= mayor; i++)
        {
            if (i % 4 == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}