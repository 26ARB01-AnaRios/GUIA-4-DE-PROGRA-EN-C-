internal class Program
{
    private static void Main(string[] args)
    {
        double peso, pesoTotal = 0;
        int contador = 0;

        while (pesoTotal < 1000)
        {
            Console.Write("Ingrese el peso de la manzana (en gramos): ");
            peso = Convert.ToDouble(Console.ReadLine());

            pesoTotal += peso;
            contador++;

            Console.WriteLine("Peso acumulado: " + pesoTotal + " g");
        }

        Console.WriteLine("---------------");
        Console.WriteLine("Ya alcanzaste 1 kilo o más");
        Console.WriteLine("Total de manzanas: " + contador);
        Console.WriteLine("Peso final: " + pesoTotal + " g");
    }
}