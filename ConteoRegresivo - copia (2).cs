internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Ingrese un número: ");
        int num = int.Parse(Console.ReadLine());

        int suma = 0;

        while (num >= 1)
        {
            Console.WriteLine(num);
            suma += num;
            num--;
        }

        Console.WriteLine("La suma es: " + suma);
    }
}