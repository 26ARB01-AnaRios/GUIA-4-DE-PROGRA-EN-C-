internal class Program
{
    private static void Main(string[] args)
    {
        double peso = 0;

        while (peso < 1)
        {
            Console.WriteLine("Coloca una manzana en la báscula (peso actual en kg): ");
            peso = Convert.ToDouble(Console.ReadLine());
        }

        Console.WriteLine("Ya tienes 1 kilo o más de manzanas.");
    
}
}