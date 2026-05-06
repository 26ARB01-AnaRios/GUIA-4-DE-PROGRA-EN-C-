
internal class Program
{
    private static void Main(string[] args)
    {
        int num1, num2, menor, mayor, suma = 0;

        Console.Write("Ingrese el primer número: ");
        num1 = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el segundo número: ");
        num2 = int.Parse(Console.ReadLine());

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

        for (int i = menor; i <= mayor; i++)
        {
            suma += i;
        }

        Console.WriteLine("La suma es: " + suma);
    }
}