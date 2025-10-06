namespace exercici2;

/* Declara variables per emmagatzemar l’adreça d’una persona: 
carrer, número, codi postal i població. Imprimeix el resultat 
en una sola línia */

using System;

namespace exercici1
{
    class ex2
    {
        static void Main(string[] args)
        {
            string carrer = "Si";
            int numero = 8;
            int Codi = 17943;
            string poble = "Roses";

            Console.WriteLine($"{carrer}, {numero}, {Codi}, {poble}");
        }
    }
}
