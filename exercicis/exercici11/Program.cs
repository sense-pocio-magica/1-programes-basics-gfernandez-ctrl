namespace exercici11;

// A partir de dues variables (nom d'usuari i domini), crea i imprimeix una adreça de correu electrònic completa.
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Introdueix el nom d'usuari: ");
        string usuari = Console.ReadLine() ?? "";

        Console.Write("Introdueix el domini (ex: exemple.com): ");
        string domini = Console.ReadLine() ?? "";

        string correu = usuari + "@" + domini;

        Console.WriteLine($"L'adreça de correu és: {correu}");
    }
}
