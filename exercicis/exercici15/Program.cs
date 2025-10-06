namespace exercici15;

// Assigna un nom i un cognom en variables. Imprimeix el nom complet, 
// assegurant-te que la primera lletra de cada paraula estigui en majúscula
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Introdueix el nom: ");
        string nom = Console.ReadLine() ?? "";

        Console.Write("Introdueix el cognom: ");
        string cognom = Console.ReadLine() ?? "";

        TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
        string nomComplet = textInfo.ToTitleCase(nom.ToLower()) + " " +
                            textInfo.ToTitleCase(cognom.ToLower());

        Console.WriteLine($"Nom complet: {nomComplet}");
    }
}
