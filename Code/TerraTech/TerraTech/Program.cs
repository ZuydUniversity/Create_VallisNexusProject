using VallisNexus.Models;

namespace VallisNexus
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Voorbeeld voorbeeld = new Voorbeeld();

            Console.WriteLine("Geef een getal:");
            int getal = int.Parse(Console.ReadLine());

            voorbeeld.Getal = getal;

            Console.WriteLine(voorbeeld.Tekst);
            voorbeeld.PasTekstAan("Nieuwe Tekst...");
            Console.WriteLine(voorbeeld.Tekst);
        }
    }
}
