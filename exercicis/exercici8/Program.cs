namespace exercici8;

/* Assigna un nombre total de minuts a una variable. 
Calcula quantes hores senceres i minuts restants són i imprimeix el resultat. */

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Introdueix un nombre total de minuts: ");
        int minutsTotals = int.Parse(Console.ReadLine());

        int hores = minutsTotals / 60;
        int minutsRestants = minutsTotals % 60;

        Console.WriteLine($"{minutsTotals} minuts són {hores} hores i {minutsRestants} minuts.");
    }
}
