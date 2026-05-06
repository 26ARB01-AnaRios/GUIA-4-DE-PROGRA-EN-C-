internal class Program
{
    private static void Main(string[] args)
    {
        int cupo = 200;
        int autos;

        do
        {
            Console.Write("Autos que entran: ");
            autos = int.Parse(Console.ReadLine());

            cupo -= autos;

            if (cupo <= 0)
                Console.WriteLine("Ya no hay cajones libres");
            else
                Console.WriteLine("Disponibles: " + cupo);

        } while (cupo > 0);
    }
}