internal class Program
{
    private static void Main(string[] args)
    {
        int num, suma = 0;

        do
        {
            Console.Write("Ingrese un número (9 para terminar): ");
            num = int.Parse(Console.ReadLine());
            suma += num;
        }
        while (num != 9);

        Console.WriteLine("La suma total es: " + suma);
    }
}