namespace exercici3;

/* Defineix quatre variables per al nom d’un producte, el seu preu 
i si està en estoc o no. Imprimeix la informació de forma clara. */
class Program
{
    static void Main(string[] args)
    {
        string producte = "pilota";
        double preu = 23;
        bool estoc = true;

        Console.WriteLine($"Aqui esta el producte {producte}, aquest es el seu preu {preu}, y en queda estoc {estoc}");
    }
}
