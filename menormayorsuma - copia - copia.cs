internal class Program
{
    private static void Main(string[] args)
    {
        int num1, num2, suma, menor, mayor;

        Console.Write("Ingrese el primer número: ");
        num1 = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el segundo número: ");
        num2 = int.Parse(Console.ReadLine());

        suma = num1 + num2;

        if (num1 < num2)
        {
            menor = num1;
            mayor = num2;
        }
        else
        {
            menor = num2;
            mayor = num1;
        }

        Console.WriteLine("Suma: " + suma);
        Console.WriteLine("Menor: " + menor);
        Console.WriteLine("Mayor: " + mayor);
    }
}