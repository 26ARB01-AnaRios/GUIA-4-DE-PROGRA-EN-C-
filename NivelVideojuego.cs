internal class Program
{
    private static void Main(string[] args)
    {
        int monedas = 0;

        while (monedas < 350)
        {
            Console.WriteLine("Ingresa la cantidad de monedas:");
            monedas = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("¡Nivel desbloqueado!");
    }
}