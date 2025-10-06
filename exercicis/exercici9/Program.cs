namespace exercici9;

/* Demana un valor en metres. Converteix el valor a peus (1 metre = 3,28084 metres) 
i imprimeix el resultat. */

class Program
{
    static void Main(string[] args)
    {
         Console.Write("Introdueix el valor en metres: ");
        double metres = double.Parse(Console.ReadLine());

        double peus = metres * 3.28084;
        Console.WriteLine($"{metres} metres són {peus:F2} peus.");
    }
}
