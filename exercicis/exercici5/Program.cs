namespace exercici5;

/* Feu un programa que demani un nom i l’any de naixement i imprimeixi per pantalla 
“Hola [nom]!  Ja tens [edat] anys? 
nom i edat seran el nom introduït i l'edat la resta de l’any actual i l’any de naixement. */

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Diguem el teu nom");
        var nom = ConsoleReadLine();

        Console.WriteLine("Quina es la teva data de naixement?");
        int dataNaix = int.Parse(Console.ReadLine());

        int DataActual = DateTime.Now.Year;
        int edatAra = DataActual - dataNaix;

        Console.WriteLine($"Hola {nom}! Ja tens {edatAra} anys");
    }
}
