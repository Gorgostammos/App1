// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hva heter du?");
string username = Console.ReadLine();
Console.WriteLine("Hei " + username);
Console.WriteLine("Hvordan har du det? Velg 1 eller 2");
Console.WriteLine("1. Bra");
Console.WriteLine("2. Ikke bra");

string howAreYou = Console.ReadLine();

if (howAreYou == "2") // Sjekker om brukeren valgte "Ikke bra"
{
    Console.WriteLine("Hvorfor?");
    Console.ForegroundColor = ConsoleColor.Red; // Endrer tekstfargen til rød
    string why = Console.ReadLine();
    Console.WriteLine("Jeg ønsker at jeg kunne hjelpe deg.");
    Console.ResetColor(); // Tilbakestiller tekstfargen
}
else if (howAreYou == "1") // Sjekker om brukeren valgte "Bra"
{
    Console.WriteLine("Godt å høre!");
}
else
{
    Console.WriteLine("Ugyldig valg, prøv igjen.");
}


Console.WriteLine("Trykk på en knapp.");
Console.ReadKey();
Console.WriteLine("Ha det!");
Console.ForegroundColor = ConsoleColor.Green; // Endrer tekstfargen til grønn
Console.ResetColor(); // Tilbakestiller tekstfargen