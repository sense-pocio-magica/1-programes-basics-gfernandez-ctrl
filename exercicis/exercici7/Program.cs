namespace exercici7;

/* Defineix tres variables amb tres notes numèriques. 
Calcula la mitjana i mostra el resultat per pantalla. */ 

class Program
{
    static void Main(string[] args)
    {
        int mates = 7;
        int ciencies = 5;
        int lectura = 0;

        int mitjana = (mates + ciencies + lectura) * 3;

        Console.WriteLine($"La mitjana total de les notes: {mitjana}"); 
    }
}
